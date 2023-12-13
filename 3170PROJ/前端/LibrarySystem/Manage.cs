using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void Add_button_Click(object sender, EventArgs e)
        {
            List<string> book_name = new List<string>();
            List<string> book_author = new List<string>();
            List<string> book_publisher = new List<string>();
            List<string> book_isbn = new List<string>();
            List<string> book_price = new List<string>();
            List<string> book_description = new List<string>();
            book_name.Add(textBox1.Text);
            book_author.Add(textBox2.Text);
            book_publisher.Add(textBox3.Text);
            book_isbn.Add(textBox4.Text);
            book_price.Add(textBox5.Text);
            book_description.Add(textBox6.Text);

            var data = new Dictionary<string, List<string>>
            {
                { "book_name", book_name },
                { "book_author", book_author },
                { "book_publisher", book_publisher },
                { "book_isbn", book_isbn },
                { "book_price", book_price },
                { "book_description", book_description }
            };

            Dictionary<string, List<string>> Result = await PublicOperations.NetWork("add_book", data);
            if (Result["status"][0] == "True") { MessageBox.Show("Successfully add book."); }
            else { MessageBox.Show("Add book failed."); }
        }

        private async void Delete_button_Click(object sender, EventArgs e)
        {
            List<string> delete_book_name = new List<string>();
            delete_book_name.Add(textBox7.Text);
            var data = new Dictionary<string, List<string>>
            {
                { "book_name", delete_book_name } };


            Dictionary<string, List<string>> Result = await PublicOperations.NetWork("delete_book", data);
            if (Result["status"][0] == "True") { MessageBox.Show("Successfully delete book."); }
            else { MessageBox.Show("Delete book failed."); }
        }

        private void Manage_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomePage homePage = new HomePage();
            PublicOperations.OpenForm(this, homePage);
        }
    }
    /*   public class PlaceholderTextBox : System.Windows.Forms.TextBox
       {
           private string placeholderText;
           this.SetStyle(ControlStyles.UserPaint, true);

           public string PlaceholderText
           {
               get { return placeholderText; }
               set { placeholderText = value; Invalidate(); }
           }

           protected override void OnPaint(PaintEventArgs e)
           {
               base.OnPaint(e);
               if (String.IsNullOrEmpty(this.Text) && !String.IsNullOrEmpty(this.PlaceholderText))
               {
                   Graphics g = e.Graphics;
                   g.DrawString(this.PlaceholderText, this.Font, Brushes.Gray, new PointF(3, 3));
               }
           }
       }*/

    /*    public class PlaceholderTextBox : TextBox
        {

            public String PlaceholderText { get; set; }

            protected override void OnPaint(PaintEventArgs e)
            {
                //
                if (!String.IsNullOrEmpty(this.PlaceholderText))
                {
                    //坐标位置 0,0 需要根据对齐方式重新计算.
                    e.Graphics.DrawString(this.PlaceholderText, this.Font, new SolidBrush(Color.LightGray), 0, 0);
                }
                else
                {
                    base.OnPaint(e);
                }
            }

        }*/


    public class PlaceholderTextBox : TextBox
    {
        private string placeholderText;

        public string PlaceholderText
        {
            get { return placeholderText; }
            set { placeholderText = value; Invalidate(); }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        const int WM_PAINT = 0x000F;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT && String.IsNullOrEmpty(this.Text))
            {
                DrawPlaceholder();
            }
        }

        private void DrawPlaceholder()
        {
            IntPtr hDC = GetWindowDC(this.Handle);
            using (Graphics g = Graphics.FromHdc(hDC))
            {
                if (String.IsNullOrEmpty(this.Text) && !String.IsNullOrEmpty(this.PlaceholderText))
                {
                    g.DrawString(PlaceholderText, this.Font, Brushes.Gray, new Point(3, 4));
                }
            }
            ReleaseDC(this.Handle, hDC);
        }
    }

}
