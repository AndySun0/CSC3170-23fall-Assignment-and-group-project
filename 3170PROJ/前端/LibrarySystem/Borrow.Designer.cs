
namespace LibrarySystem
{
    partial class Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow));
            this.splitContainerOfHomePage = new System.Windows.Forms.SplitContainer();
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.CategorySearch = new System.Windows.Forms.Label();
            this.BookList = new System.Windows.Forms.ListBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.BookInfoLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BookNameText = new System.Windows.Forms.TextBox();
            this.ExactSearch = new System.Windows.Forms.Label();
            this.DetailInfoText = new System.Windows.Forms.TextBox();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.BookCover = new System.Windows.Forms.PictureBox();
            this.BookDetailInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOfHomePage)).BeginInit();
            this.splitContainerOfHomePage.Panel1.SuspendLayout();
            this.splitContainerOfHomePage.Panel2.SuspendLayout();
            this.splitContainerOfHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerOfHomePage
            // 
            resources.ApplyResources(this.splitContainerOfHomePage, "splitContainerOfHomePage");
            this.splitContainerOfHomePage.Name = "splitContainerOfHomePage";
            // 
            // splitContainerOfHomePage.Panel1
            // 
            this.splitContainerOfHomePage.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainerOfHomePage.Panel1.BackgroundImage = global::LibrarySystem.Properties.Resources.background2;
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.CategoryText);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.CategorySearch);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BookList);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.ReturnButton);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.Status);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BorrowButton);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BookInfoLabel);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.SearchButton);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BookNameText);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.ExactSearch);
            this.splitContainerOfHomePage.Panel1.Tag = "";
            // 
            // splitContainerOfHomePage.Panel2
            // 
            this.splitContainerOfHomePage.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.DetailInfoText);
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.PictureLabel);
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.BookCover);
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.BookDetailInfo);
            // 
            // CategoryText
            // 
            resources.ApplyResources(this.CategoryText, "CategoryText");
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.TextChanged += new System.EventHandler(this.CategoryText_TextChanged);
            // 
            // CategorySearch
            // 
            resources.ApplyResources(this.CategorySearch, "CategorySearch");
            this.CategorySearch.BackColor = System.Drawing.Color.Transparent;
            this.CategorySearch.Name = "CategorySearch";
            // 
            // BookList
            // 
            resources.ApplyResources(this.BookList, "BookList");
            this.BookList.FormattingEnabled = true;
            this.BookList.Name = "BookList";
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.BookList_SelectedIndexChanged);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ReturnButton, "ReturnButton");
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Status.ForeColor = System.Drawing.Color.Red;
            this.Status.Name = "Status";
            // 
            // BorrowButton
            // 
            this.BorrowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BorrowButton, "BorrowButton");
            this.BorrowButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // BookInfoLabel
            // 
            resources.ApplyResources(this.BookInfoLabel, "BookInfoLabel");
            this.BookInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookInfoLabel.Name = "BookInfoLabel";
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.SearchButton, "SearchButton");
            this.SearchButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BookNameText
            // 
            resources.ApplyResources(this.BookNameText, "BookNameText");
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.TextChanged += new System.EventHandler(this.BookNameText_TextChanged);
            // 
            // ExactSearch
            // 
            resources.ApplyResources(this.ExactSearch, "ExactSearch");
            this.ExactSearch.BackColor = System.Drawing.Color.Transparent;
            this.ExactSearch.Name = "ExactSearch";
            // 
            // DetailInfoText
            // 
            resources.ApplyResources(this.DetailInfoText, "DetailInfoText");
            this.DetailInfoText.Name = "DetailInfoText";
            // 
            // PictureLabel
            // 
            resources.ApplyResources(this.PictureLabel, "PictureLabel");
            this.PictureLabel.Name = "PictureLabel";
            // 
            // BookCover
            // 
            this.BookCover.Image = global::LibrarySystem.Properties.Resources.Coverage;
            resources.ApplyResources(this.BookCover, "BookCover");
            this.BookCover.Name = "BookCover";
            this.BookCover.TabStop = false;
            // 
            // BookDetailInfo
            // 
            resources.ApplyResources(this.BookDetailInfo, "BookDetailInfo");
            this.BookDetailInfo.Name = "BookDetailInfo";
            // 
            // Borrow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.splitContainerOfHomePage);
            this.Name = "Borrow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Borrow_FormClosing);
            this.splitContainerOfHomePage.Panel1.ResumeLayout(false);
            this.splitContainerOfHomePage.Panel1.PerformLayout();
            this.splitContainerOfHomePage.Panel2.ResumeLayout(false);
            this.splitContainerOfHomePage.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOfHomePage)).EndInit();
            this.splitContainerOfHomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerOfHomePage;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox BookNameText;
        private System.Windows.Forms.Label ExactSearch;
        private System.Windows.Forms.Label BookInfoLabel;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label BookDetailInfo;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.PictureBox BookCover;
        private System.Windows.Forms.Label PictureLabel;
        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.TextBox DetailInfoText;
        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.Label CategorySearch;
    }
}