namespace Leihbuecherrei_GFS.GUI
{
    partial class AddToWaitingListWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            GbReader = new GroupBox();
            LbReaders = new ListBox();
            TxtSearchReader = new TextBox();
            GbBook = new GroupBox();
            LbBooks = new ListBox();
            TxtSearchBook = new TextBox();
            LblMandetoryInfos = new Label();
            BtnOk = new Button();
            GbReader.SuspendLayout();
            GbBook.SuspendLayout();
            SuspendLayout();
            // 
            // GbReader
            // 
            GbReader.BackColor = SystemColors.ButtonShadow;
            GbReader.Controls.Add(LbReaders);
            GbReader.Controls.Add(TxtSearchReader);
            GbReader.Location = new Point(12, 12);
            GbReader.Name = "GbReader";
            GbReader.Size = new Size(206, 207);
            GbReader.TabIndex = 0;
            GbReader.TabStop = false;
            GbReader.Text = "*Reader";
            // 
            // LbReaders
            // 
            LbReaders.FormattingEnabled = true;
            LbReaders.ItemHeight = 25;
            LbReaders.Location = new Point(6, 67);
            LbReaders.Name = "LbReaders";
            LbReaders.Size = new Size(194, 129);
            LbReaders.TabIndex = 1;
            // 
            // TxtSearchReader
            // 
            TxtSearchReader.Location = new Point(6, 30);
            TxtSearchReader.Name = "TxtSearchReader";
            TxtSearchReader.PlaceholderText = "Search Reader";
            TxtSearchReader.Size = new Size(194, 31);
            TxtSearchReader.TabIndex = 0;
            TxtSearchReader.TextAlign = HorizontalAlignment.Center;
            TxtSearchReader.KeyPress += TxtSearchReader_KeyPress;
            // 
            // GbBook
            // 
            GbBook.BackColor = SystemColors.ButtonShadow;
            GbBook.Controls.Add(LbBooks);
            GbBook.Controls.Add(TxtSearchBook);
            GbBook.Location = new Point(259, 12);
            GbBook.Name = "GbBook";
            GbBook.Size = new Size(206, 207);
            GbBook.TabIndex = 1;
            GbBook.TabStop = false;
            GbBook.Text = "*Book";
            // 
            // LbBooks
            // 
            LbBooks.FormattingEnabled = true;
            LbBooks.ItemHeight = 25;
            LbBooks.Location = new Point(6, 67);
            LbBooks.Name = "LbBooks";
            LbBooks.Size = new Size(194, 129);
            LbBooks.TabIndex = 1;
            // 
            // TxtSearchBook
            // 
            TxtSearchBook.Location = new Point(6, 30);
            TxtSearchBook.Name = "TxtSearchBook";
            TxtSearchBook.PlaceholderText = "Search Book";
            TxtSearchBook.Size = new Size(194, 31);
            TxtSearchBook.TabIndex = 0;
            TxtSearchBook.TextAlign = HorizontalAlignment.Center;
            TxtSearchBook.KeyPress += TxtSearchBook_KeyPress;
            // 
            // LblMandetoryInfos
            // 
            LblMandetoryInfos.Anchor = AnchorStyles.Top;
            LblMandetoryInfos.AutoSize = true;
            LblMandetoryInfos.Location = new Point(173, 251);
            LblMandetoryInfos.Name = "LblMandetoryInfos";
            LblMandetoryInfos.Size = new Size(165, 25);
            LblMandetoryInfos.TabIndex = 12;
            LblMandetoryInfos.Text = "* = mandetory info";
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(353, 246);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(112, 34);
            BtnOk.TabIndex = 2;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // AddToWaitingListWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 292);
            Controls.Add(LblMandetoryInfos);
            Controls.Add(BtnOk);
            Controls.Add(GbReader);
            Controls.Add(GbBook);
            MaximizeBox = false;
            MaximumSize = new Size(499, 348);
            MinimizeBox = false;
            MinimumSize = new Size(499, 348);
            Name = "AddToWaitingListWindow";
            Text = "AddToWaitingListWindow";
            GbReader.ResumeLayout(false);
            GbReader.PerformLayout();
            GbBook.ResumeLayout(false);
            GbBook.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GbReader;
        private ListBox LbReaders;
        private TextBox TxtSearchReader;
        private GroupBox GbBook;
        private ListBox LbBooks;
        private TextBox TxtSearchBook;
        private Label LblMandetoryInfos;
        private Button BtnOk;
    }
}