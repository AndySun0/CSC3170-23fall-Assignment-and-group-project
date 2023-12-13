using System;
using System.Linq;
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
    partial class UserInfo
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
            this.components = new System.ComponentModel.Container();
            this.userNametext = new System.Windows.Forms.TextBox();
            this.phoneNumbertext = new System.Windows.Forms.TextBox();
            this.studentIDtext = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userName = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.User_Info = new System.Windows.Forms.Button();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userNametext
            // 
            this.userNametext.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.userNametext.Location = new System.Drawing.Point(412, 64);
            this.userNametext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNametext.Name = "userNametext";
            this.userNametext.ReadOnly = true;
            this.userNametext.Size = new System.Drawing.Size(438, 32);
            this.userNametext.TabIndex = 0;
            // 
            // phoneNumbertext
            // 
            this.phoneNumbertext.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.phoneNumbertext.Location = new System.Drawing.Point(412, 159);
            this.phoneNumbertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumbertext.Multiline = true;
            this.phoneNumbertext.Name = "phoneNumbertext";
            this.phoneNumbertext.ReadOnly = true;
            this.phoneNumbertext.Size = new System.Drawing.Size(438, 74);
            this.phoneNumbertext.TabIndex = 1;
            // 
            // studentIDtext
            // 
            this.studentIDtext.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.studentIDtext.Location = new System.Drawing.Point(412, 110);
            this.studentIDtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentIDtext.Name = "studentIDtext";
            this.studentIDtext.ReadOnly = true;
            this.studentIDtext.Size = new System.Drawing.Size(438, 32);
            this.studentIDtext.TabIndex = 2;
            this.studentIDtext.Tag = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 275);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(964, 284);
            this.dataGridView1.TabIndex = 6;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.userName.Location = new System.Drawing.Point(185, 60);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(157, 32);
            this.userName.TabIndex = 7;
            this.userName.Text = "Username";
            // 
            // studentID
            // 
            this.studentID.AutoSize = true;
            this.studentID.BackColor = System.Drawing.Color.Transparent;
            this.studentID.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.studentID.Location = new System.Drawing.Point(185, 106);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(177, 32);
            this.studentID.TabIndex = 8;
            this.studentID.Text = "Student_ID";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumber.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.phoneNumber.Location = new System.Drawing.Point(185, 155);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(220, 32);
            this.phoneNumber.TabIndex = 9;
            this.phoneNumber.Text = "PhoneNumber";
            // 
            // User_Info
            // 
            this.User_Info.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.User_Info.Location = new System.Drawing.Point(12, 11);
            this.User_Info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User_Info.Name = "User_Info";
            this.User_Info.Size = new System.Drawing.Size(146, 50);
            this.User_Info.TabIndex = 10;
            this.User_Info.Text = "SHOW";
            this.User_Info.UseVisualStyleBackColor = true;
            this.User_Info.Click += new System.EventHandler(this.User_Info_Click);
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataSource = typeof(LibrarySystem.UserInfo);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.background6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1291, 633);
            this.Controls.Add(this.User_Info);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.studentIDtext);
            this.Controls.Add(this.phoneNumbertext);
            this.Controls.Add(this.userNametext);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userNametext;
        private TextBox phoneNumbertext;
        private TextBox studentIDtext;
        private DataGridView dataGridView1;
        private Label userName;
        private Label studentID;
        private Label phoneNumber;
        private BindingSource bookInfoBindingSource;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowDateDataGridViewTextBoxColumn;
        private Button User_Info;
        private BindingSource userInfoBindingSource;
    }
}