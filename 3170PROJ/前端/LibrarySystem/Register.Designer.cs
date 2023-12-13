
namespace LibrarySystem
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.checkPasswordLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordCheckText = new System.Windows.Forms.TextBox();
            this.phoneNumberText = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(39, 24);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(211, 25);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Enter your username:";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkPasswordLabel
            // 
            this.checkPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.checkPasswordLabel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPasswordLabel.Location = new System.Drawing.Point(39, 103);
            this.checkPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkPasswordLabel.Name = "checkPasswordLabel";
            this.checkPasswordLabel.Size = new System.Drawing.Size(211, 25);
            this.checkPasswordLabel.TabIndex = 2;
            this.checkPasswordLabel.Text = "Check the password:";
            this.checkPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idLabel
            // 
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(39, 244);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(211, 25);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "Enter your studentID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneLabel
            // 
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(39, 140);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(211, 25);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Enter phone numbers:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(39, 64);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(211, 25);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Enter the password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("宋体", 13F);
            this.usernameText.Location = new System.Drawing.Point(263, 24);
            this.usernameText.Margin = new System.Windows.Forms.Padding(2);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(328, 27);
            this.usernameText.TabIndex = 1;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // idText
            // 
            this.idText.Font = new System.Drawing.Font("宋体", 13F);
            this.idText.Location = new System.Drawing.Point(263, 244);
            this.idText.Margin = new System.Windows.Forms.Padding(2);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(328, 27);
            this.idText.TabIndex = 8;
            this.idText.TextChanged += new System.EventHandler(this.idText_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("宋体", 13F);
            this.passwordText.Location = new System.Drawing.Point(263, 64);
            this.passwordText.Margin = new System.Windows.Forms.Padding(2);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(328, 27);
            this.passwordText.TabIndex = 9;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // passwordCheckText
            // 
            this.passwordCheckText.Font = new System.Drawing.Font("宋体", 13F);
            this.passwordCheckText.Location = new System.Drawing.Point(263, 103);
            this.passwordCheckText.Margin = new System.Windows.Forms.Padding(2);
            this.passwordCheckText.Name = "passwordCheckText";
            this.passwordCheckText.Size = new System.Drawing.Size(328, 27);
            this.passwordCheckText.TabIndex = 10;
            this.passwordCheckText.UseSystemPasswordChar = true;
            this.passwordCheckText.TextChanged += new System.EventHandler(this.passwordCheckText_TextChanged);
            // 
            // phoneNumberText
            // 
            this.phoneNumberText.Font = new System.Drawing.Font("宋体", 13F);
            this.phoneNumberText.Location = new System.Drawing.Point(263, 140);
            this.phoneNumberText.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumberText.Multiline = true;
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.phoneNumberText.Size = new System.Drawing.Size(328, 92);
            this.phoneNumberText.TabIndex = 11;
            this.phoneNumberText.UseSystemPasswordChar = true;
            this.phoneNumberText.TextChanged += new System.EventHandler(this.phoneNumberText_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.Coral;
            this.registerButton.Location = new System.Drawing.Point(260, 298);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(120, 45);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Sign up";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(661, 368);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.phoneNumberText);
            this.Controls.Add(this.passwordCheckText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.checkPasswordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label checkPasswordLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox passwordCheckText;
        private System.Windows.Forms.TextBox phoneNumberText;
        private System.Windows.Forms.Button registerButton;
    }
}