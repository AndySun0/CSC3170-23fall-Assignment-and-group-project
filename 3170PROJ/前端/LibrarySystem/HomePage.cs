using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BorrowPic_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            PublicOperations.OpenForm(this, borrow);
        }

        private void ManagePic_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            PublicOperations.OpenForm(this, manage);
          
        }

        private void UserInfoPic_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            PublicOperations.OpenForm(this, userInfo);
        }
    }
}
