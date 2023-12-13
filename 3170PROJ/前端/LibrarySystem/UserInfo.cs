using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Drawing;

namespace LibrarySystem
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private async void User_Info_Click(object sender, EventArgs e) //HomePage
        {
            //UserInfo UserInfo = new UserInfo();
            //PublicOperations.OpenForm(this, UserInfo);//接到点击信号，打开info窗口

            List<string> userName = new List<string>();
            
            userName.Add( PublicOperations.myUID); //记得读取username////////////////////////////////
            
            var data = new Dictionary<string, List<string>>
            {
                { "username", userName }
            };   //data作为输入，内含《username，username》
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>(); //dictionary是函数networklist的返回值
            dictionary = await PublicOperations.NetWork("personal_info", data);  

            //上方接收数据，下方展示
            userNametext.Text = dictionary["username"][0];
            studentIDtext.Text = dictionary["student_id"][0];
            if (dictionary.ContainsKey("phone_number") && dictionary["phone_number"] != null)
            {
                // 将电话号码列表拼接为一个字符串，每个号码占一行
                string phoneNumbers = string.Join("\r\n", dictionary["phone_number"]);
                phoneNumbertext.Text = phoneNumbers;
            }
            else
            {
                // 如果没有电话号码，可以选择清空TextBox或显示默认文本
                phoneNumbertext.Text = "No Phone Numbers";
            }

            List<string> BookId = dictionary["book_id"];
            List<string> BookName = dictionary["book_name"];
            List<string> BorrowDate = dictionary["borrow_date"];

            BindingList<Book> books = new BindingList<Book>();
            for (int i = 0; i < BookId.Count; i++)
            {
                books.Add(new Book { BookId = BookId[i], BookName = BookName[i], BorrowDate = BorrowDate[i] });
            }


            // 将 BindingList 绑定到 DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = books;
            dataGridView1.Refresh();
            // 设置 DataGridView 控件的字体
            dataGridView1.Font = new Font("Arial", 14, FontStyle.Regular);




            /*            for (int i = 0; i < BookId.Count; i++)
                        {
                            // 创建一个新行
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1); // yourDataGridView 是你的 DataGridView 的实例名

                            // 设置每一列的值
                            row.Cells[0].Value = BookId[i];      // 假设书籍ID在第一列
                            row.Cells[1].Value = BookName[i];    // 假设书名在第二列
                            row.Cells[2].Value = BorrowDate[i];  // 假设借阅日期在第三列

                            // 将行添加到 DataGridView
                            dataGridView1.Rows.Add(row);
                        }*/
        }

        private void UserInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomePage homePage = new HomePage();
            PublicOperations.OpenForm(this, homePage);
        }
        private class Book
        {
            public string BookId { get; set; }
            public string BookName { get; set; }
            public string BorrowDate { get; set; }
        }
    }
}
