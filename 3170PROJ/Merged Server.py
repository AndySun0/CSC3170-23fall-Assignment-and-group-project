from flask import Flask, request, jsonify
import pymysql
from datetime import datetime, timedelta

app = Flask(__name__)

def connect_db():
    return pymysql.connect(host='localhost', user="root", password="sunyuxuan", db="mydb")

def connect_db2():
    return pymysql.connect(host='localhost', user="root", password="sunyuxuan", db="mydb")


@app.route("/find_book", methods=["Post"])
def find_book():
    data = request.get_json()
    keyword = data.get("book_name")
    keyword = keyword[0]

    category = data.get("category")
    category =category [0]
    
    page = int(request.form.get("page", 1))
    per_page = int(request.form.get("per_page", 10)) #分页功能, page当前页, per_page每页数目默认值为5, 可以不提供page与per_page使用默认值
    offset = (page - 1) * per_page
    with connect_db() as db:
        with db.cursor() as cursor:
            if keyword and category:
                cursor.execute('SELECT Title, Author, Publisher, ISBN, Price, Description, Book_id, Status FROM book WHERE Title LIKE %s AND Category = %s LIMIT %s OFFSET %s', ('%' + keyword + '%', category, per_page, offset))
            elif keyword:
                
                cursor.execute('SELECT Title, Author, Publisher, ISBN, Price, Description, Book_id, Status FROM book WHERE Title LIKE %s LIMIT %s OFFSET %s', ('%' + keyword + '%', per_page, offset))

            elif category:
                cursor.execute('SELECT Title, Author, Publisher, ISBN, Price, Description, Book_id, Status FROM book WHERE Category = %s LIMIT %s OFFSET %s', (category, per_page, offset))
            else:
                return jsonify({"status" : ['False'], "reason" : ["Missing keyword or category"]})
            results = cursor.fetchall()
            booksTitle_list = []
            booksAuthor_list = []
            booksPublisher_list = []
            booksISBN_list = []
            booksPrice_list = []
            booksDescription_list = []
            booksID_list=[]
            booksstatus_list=[]
            for row in results:
                booksTitle_list.append(row[0])
                booksAuthor_list.append(row[1])
                booksPublisher_list.append(row[2])
                booksISBN_list.append(row[3])
                booksPrice_list.append(row[4])
                booksDescription_list.append(row[5])
                booksID_list.append(row[6])
                booksstatus_list.append(row[7])
            
    return jsonify({"status" : ['True'], 'book_status':booksstatus_list, 'book_name': booksTitle_list, 'book_author': booksAuthor_list, 'book_publisher': booksPublisher_list, 'book_isbn': booksISBN_list, 'book_price': booksPrice_list, 'book_description': booksDescription_list, 'book_id': booksID_list})

@app.route("/borrow", methods=["POST"])
def borrow():
    data = request.get_json()
    user_id = data.get("user_id")
    book_id = data.get("book_id")
    user_id = user_id[0]
    book_id = book_id[0]
  
    try:
        db = connect_db()
        cursor = db.cursor()
        cursor.execute('START TRANSACTION')
    
        # Check if the book is available
        cursor.execute("SELECT Status FROM book WHERE Book_id = %s FOR UPDATE", (book_id,))
        Status = cursor.fetchone()[0]
        
        if not Status:
            db.rollback()
            return jsonify({"status": ["False"], "reason" : ["The book has been borrowed!"]})

        #Check if the user has reached the borrow limit
        cursor.execute("SELECT COUNT(*) FROM borrowrecord WHERE user_id = %s AND ReturnDate IS NULL FOR UPDATE", (user_id,))

        borrow_count = cursor.fetchone()[0]

        # cursor.execute("SELECT Limit FROM borrowlimit WHERE user_id = %s FOR UPDATE", (user_id,))
        # borrow_limit = cursor.fetchone()[0]

        if borrow_count >= 3:
            db.rollback()
            return jsonify({"status": ["False"], "reason": ["You have reached the borrow limit 3!"]})
        

        #If not, check if the book is available
        
        borrow_date = datetime.now()
        cursor.execute('INSERT INTO borrowrecord (user_id, book_id, BorrowDate) VALUES (%s, %s, %s)', (user_id, book_id, borrow_date))
        cursor.execute('UPDATE book SET Status = False WHERE book_id = %s', (book_id,))
        db.commit()
        return jsonify({"status": ["True"], "reason": ["You have borrowed this book!"]})
    except Exception as e:
        db.rollback()
        return jsonify({"status": ["False"], "reason": [str(e)]})
    finally:
        db.close()

@app.route("/return_book", methods=["POST"])
def return_book():
    data = request.get_json()
    user_id = data.get("user_id")[0]
    book_id = data.get("book_id")[0]
    return_date = datetime.now()
    db = connect_db()
    cursor = db.cursor()
    
    # Check if the book is borrowed by the user
    cursor.execute("SELECT Status FROM book WHERE Book_id = %s FOR UPDATE", (book_id,))
    #cursor.execute("SELECT COUNT(*) FROM borrowrecord WHERE user_id = %s AND Book_id = %s", (user_id, book_id))
    Status = cursor.fetchone()[0]
    if Status:
        return jsonify({"status": ['False'], 'reason' : ['The book is not borrowed by you!']})

    # Get the borrow date and the book price
    cursor.execute('SELECT BorrowDate, Price FROM borrowrecord JOIN book ON borrowrecord.book_id = book.book_id WHERE user_id = %s AND borrowrecord.book_id = %s', (user_id, book_id))
    try:
        borrow_date, book_price = cursor.fetchone()
    except:
        return jsonify({"status": ['False'], 'reason' : ['The book is not borrowed by you!']})

    # Calculate the fine 七天之内还书不罚款，超过七天赔偿all书本费
    '''if return_date > borrow_date + timedelta(days=7):
        fine_amount = book_price
    else:
        fine_amount = 0
    '''
    cursor.execute('UPDATE borrowrecord SET ReturnDate = %s WHERE user_id = %s AND book_id = %s', (return_date, user_id, book_id))
    cursor.execute('UPDATE book SET Status = True WHERE Book_id = %s', (book_id,))
    #cursor.execute("DELETE FROM borrowrecord WHERE Book_id = %s", (book_id,))
    db.commit()
    db.close()
    
    formatted_time = return_date.strftime('%Y-%m-%d %H:%M:%S')
    return jsonify({"status": ['True'], 'reason': ['You return the book at\n' + str(formatted_time)]})



@app.route('/add_book', methods=['POST'])
def addbook():
    
    data = request.get_json()
    book_name = data.get('book_name')
    book_author = data.get('book_author')
    book_publisher = data.get('book_publisher')
    book_isbn = data.get('book_isbn')
    book_price = data.get('book_price')
    book_description = data.get('book_description')

    with connect_db2() as db:
        with db.cursor() as cursor:
                
           
            # Add book to the database
            query_add_book = "INSERT INTO book (title, author, publisher, isbn, price, description) VALUES (%s, %s, %s, %s, %s, %s)"
            cursor.execute(query_add_book, (book_name[0], book_author[0], book_publisher[0], book_isbn[0], book_price[0], book_description[0]))
            response = {"status": ["True"] }
            db.commit()
            
    return jsonify(response)

def validate_login(username, password):
    with connect_db2() as db:
        with db.cursor() as cursor:
            cursor.execute('SELECT * FROM user WHERE username = %s AND password = %s', (username, password))
            user_data = cursor.fetchone()

    return user_data

@app.route('/login', methods=['POST'])
def login():
    data = request.get_json()
    username = data.get("username")
    password = data.get("password")

    if not username or not password:
        return jsonify({'status': ["False"], 'reason': ["Missing username or password"]})
    
    user_data = validate_login(username, password)
   
    if user_data != None:
        return jsonify({'status': ["True"], 'user_id':[user_data[0]]} )
    else:
        return jsonify({'status': ["False"]})

@app.route('/register', methods=['POST'])
def register():
    data = request.get_json()
    username = data.get("username")
    password = data.get("password")
    phone_number = data.get("phone_number")
    student_id = data.get("student_id")
    if not username or not password or not phone_number or not student_id:
        return jsonify({'status': ["False"], 'reason': ["Missing registration details"]})

    with connect_db2() as db:
        with db.cursor() as cursor:
            # Check if username already exists
            cursor.execute('SELECT * FROM user WHERE username = %s', (username,))
            existing_user = cursor.fetchone()
            
            if existing_user:
                return jsonify({'status': ["False"], 'reason': ["Username already exists"]})
            

            cursor.execute('INSERT INTO user (Username, Password, PhoneNumber, User_id) VALUES ( %s, %s, %s,%s)',
                                         (username[0], password[0], phone_number[0], student_id[0]))#需要改#########

            db.commit()
            # cursor.close()
            # db.close()
    return jsonify({'status': ["True"]})

@app.route("/personal_info", methods=["POST"])
def personal_info():
    data = request.get_json()
    userid = data.get("username")

    if not userid:
        return jsonify({'status': ["False"], 'reason': ["Missing username"]})

    with connect_db2() as db:
        with db.cursor() as cursor:
            cursor.execute('SELECT username, PhoneNumber, User_id  FROM user WHERE User_id = %s', (userid,))
            user_data = cursor.fetchall()
            cursor.execute('SELECT Book_id, BorrowDate FROM borrowrecord WHERE user_id = %s AND ReturnDate IS NULL', (userid,))
            borrow_data = cursor.fetchall() 
            
            if not user_data:
                return jsonify({'status': ["False"], 'reason': ["User not found"]})
            
            username_list = []
            phone_number_list = []
            student_id_list = []
            book_id_list = []
            book_name_list = []
            borrow_date_list = []
            for row in user_data:
                username_list.append(row[0])
                phone_number_list.append(row[1])
                student_id_list.append(row[2])
                
            for row in borrow_data:
                book_id_list.append(row[0])
                cursor.execute('SELECT * FROM book WHERE book_id = %s', (row[0]))
                book_name = cursor.fetchone()[1]
                book_name_list.append(book_name)
                formatted_time = row[1].strftime('%Y-%m-%d %H:%M:%S')
                borrow_date_list.append(formatted_time)
                
            # Assuming the database schema has columns like PhoneNumber, student_id, etc.
            '''
            personal_info = {
                "username": user_data[1],
                "phone_number": user_data[3],
                "student_id": user_data[0],
                "book_id": user_data["book_id"],
                "book_name": user_data["book_name"],
                "borrow_date": user_data["borrow_date"]
            }
            print(personal_info)
            '''

    #return jsonify(personal_info)
    return jsonify({"status" : ['True'], 'username': username_list, 'phone_number': phone_number_list, 'student_id': student_id_list, 'book_id': book_id_list, 'book_name': book_name_list, 'borrow_date': borrow_date_list})


@app.route('/delete_book', methods=['POST'])
def delete_book():
    data = request.get_json()
    book_name = data['book_name'][0]

    # Delete book from the database
    
    with connect_db2() as db:
        with db.cursor() as cursor:
                
       
            # del book to the database
            query_delete_book = "DELETE FROM book WHERE Book_id = %s"
          
            cursor.execute(query_delete_book, (book_name))
            response = {"status": ["True"] if query_delete_book else ["False"]}
            db.commit()
            
    return jsonify(response)

if __name__ == "__main__":
    app.run(debug=True)

