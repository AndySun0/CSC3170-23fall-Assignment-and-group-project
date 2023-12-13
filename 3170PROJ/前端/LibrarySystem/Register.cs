using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Register : Form
    {
        string username;
        string password;
        string passwordCheck;
        List<string> phoneNumbers;
        string studentID;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            username = usernameText.Text;
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            password = passwordText.Text;
        }

        private void passwordCheckText_TextChanged(object sender, EventArgs e)
        {
            passwordCheck = passwordCheckText.Text;
        }

        private void phoneNumberText_TextChanged(object sender, EventArgs e)
        {
            string texttmp = phoneNumberText.Text;
            string[] lines = texttmp.Split(new[] { Environment.NewLine }, StringSplitOptions.None); 
            phoneNumbers = new List<string>(lines); 
        }

        private void idText_TextChanged(object sender, EventArgs e)
        {
            studentID = idText.Text;
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            if(password!=passwordCheck)
                MessageBox.Show("Two passwords did not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            List<string> usernameL = new List<string>();
            List<string> passwordL = new List<string>();
            List<string> studentIDL = new List<string>();
            usernameL.Add(username);
            passwordL.Add(password);
            studentIDL.Add(studentID);

            var values = new Dictionary<string, List<string>>
            {
                { "username", usernameL},
                { "password", passwordL},
                { "phone_number", phoneNumbers},
                { "student_id", studentIDL},
            };
            var result = await PublicOperations.NetWork("register", values);

            if (result["status"][0] == "True")
            {
                MessageBox.Show("Success!","注册成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Register failed!", result["reason"][0], MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
