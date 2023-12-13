using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibrarySystem
{
    public partial class LoginForm : Form
    {
        string username;
        string password;

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            //点击Login时触发
            var usernameL = new List<string>();
            var passwordL = new List<string>();
            usernameL.Add(username);
            passwordL.Add(password);
            var values = new Dictionary<string, List<string>>
            {
                { "username", usernameL},
                { "password", passwordL},
            };
            var result = await PublicOperations.NetWork("login", values);

            if (result["status"][0] == "True")
            {
                PublicOperations.myUID = result["user_id"][0];
                HomePage homePage = new HomePage();
                PublicOperations.OpenForm(this, homePage);
            }
            else
            {
                MessageBox.Show("Wrong Password!", "Login Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {
            username = UserNameText.Text;

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            password = PasswordText.Text;

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            PublicOperations.OpenForm(this, register);
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            //仅作占位用，没有实际意义
            /*var connectL = new List<string>();
            connectL.Add("connect");
            var values = new Dictionary<string, List<string>>
            {
                { "connect", connectL},
            };
            //窗体启动时先尝试连接，减少卡顿
            bool successful = false;
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    var result = await PublicOperations.NetWork("connect", values);
                    successful = true;
                    break;
                }
                catch (Exception exception)
                {
                    await Task.Delay(500);
                }
            }
            if (successful == false)
            {
                MessageBox.Show("Fail to connect to the server! Please check your network!", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }


}
