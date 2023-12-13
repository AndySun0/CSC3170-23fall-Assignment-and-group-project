using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystem
{
    partial class Manage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.textBox7 = new LibrarySystem.PlaceholderTextBox();
            this.textBox6 = new LibrarySystem.PlaceholderTextBox();
            this.textBox5 = new LibrarySystem.PlaceholderTextBox();
            this.textBox4 = new LibrarySystem.PlaceholderTextBox();
            this.textBox3 = new LibrarySystem.PlaceholderTextBox();
            this.textBox2 = new LibrarySystem.PlaceholderTextBox();
            this.textBox1 = new LibrarySystem.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.label1.Location = new System.Drawing.Point(86, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Book Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.label2.Location = new System.Drawing.Point(697, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delete Book Here";
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Add_button.Location = new System.Drawing.Point(347, 329);
            this.Add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(205, 39);
            this.Add_button.TabIndex = 9;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.Delete_button.Location = new System.Drawing.Point(697, 160);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(205, 39);
            this.Delete_button.TabIndex = 10;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.textBox7.Location = new System.Drawing.Point(697, 103);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "book_name";
            this.textBox7.Size = new System.Drawing.Size(205, 39);
            this.textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.textBox6.Location = new System.Drawing.Point(86, 386);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "book_description";
            this.textBox6.Size = new System.Drawing.Size(466, 185);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.textBox5.Location = new System.Drawing.Point(86, 329);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "book_price";
            this.textBox5.Size = new System.Drawing.Size(205, 39);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.textBox4.Location = new System.Drawing.Point(86, 272);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "book_isbn";
            this.textBox4.Size = new System.Drawing.Size(205, 39);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.textBox3.Location = new System.Drawing.Point(86, 216);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "book_publisher";
            this.textBox3.Size = new System.Drawing.Size(205, 39);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.textBox2.Location = new System.Drawing.Point(86, 160);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "book_author";
            this.textBox2.Size = new System.Drawing.Size(205, 39);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.textBox1.Location = new System.Drawing.Point(86, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "book_name";
            this.textBox1.Size = new System.Drawing.Size(205, 39);
            this.textBox1.TabIndex = 0;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 633);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manage";
            this.Text = "Manage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /*  PlaceholderTextBox myTextBox = new PlaceholderTextBox();
          myT  textBox.PlaceholderText = "";请输入姓名";
        this.Controls.Add(myTextBox);*/

        private PlaceholderTextBox textBox1;
        private PlaceholderTextBox textBox2;
        private PlaceholderTextBox textBox3;
        private PlaceholderTextBox textBox4;
        private PlaceholderTextBox textBox5;
        private LibrarySystem.PlaceholderTextBox textBox6;
        private Label label1;
        private Label label2;
        private PlaceholderTextBox textBox7;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
    }

}