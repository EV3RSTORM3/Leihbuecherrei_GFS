namespace Leihbuecherrei_GFS.GUI
{
    partial class AddBorrowEntryWindow
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
            GbBook = new GroupBox();
            LbBooks = new ListBox();
            TxtSearchBook = new TextBox();
            GbReader = new GroupBox();
            LbReaders = new ListBox();
            TxtSearchReader = new TextBox();
            BtnAddEntry = new Button();
            LblDueTo = new Label();
            DtpDueTo = new DateTimePicker();
            LblMandetoryInfos = new Label();
            GbBook.SuspendLayout();
            GbReader.SuspendLayout();
            SuspendLayout();
            // 
            // GbBook
            // 
            GbBook.BackColor = SystemColors.ButtonShadow;
            GbBook.Controls.Add(LbBooks);
            GbBook.Controls.Add(TxtSearchBook);
            GbBook.Location = new Point(255, 12);
            GbBook.Name = "GbBook";
            GbBook.Size = new Size(206, 207);
            GbBook.TabIndex = 4;
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
            TxtSearchBook.TabIndex = 1;
            TxtSearchBook.TextAlign = HorizontalAlignment.Center;
            TxtSearchBook.KeyPress += TxtSearchBook_KeyPress;
            // 
            // GbReader
            // 
            GbReader.BackColor = SystemColors.ButtonShadow;
            GbReader.Controls.Add(LbReaders);
            GbReader.Controls.Add(TxtSearchReader);
            GbReader.Location = new Point(12, 12);
            GbReader.Name = "GbReader";
            GbReader.Size = new Size(206, 207);
            GbReader.TabIndex = 5;
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
            // BtnAddEntry
            // 
            BtnAddEntry.Location = new Point(349, 288);
            BtnAddEntry.Name = "BtnAddEntry";
            BtnAddEntry.Size = new Size(112, 34);
            BtnAddEntry.TabIndex = 3;
            BtnAddEntry.Text = "Add entry";
            BtnAddEntry.UseVisualStyleBackColor = true;
            BtnAddEntry.Click += BtnAddEntry_Click;
            // 
            // LblDueTo
            // 
            LblDueTo.AutoSize = true;
            LblDueTo.Location = new Point(12, 232);
            LblDueTo.Name = "LblDueTo";
            LblDueTo.Size = new Size(78, 25);
            LblDueTo.TabIndex = 7;
            LblDueTo.Text = "*Due to:";
            // 
            // DtpDueTo
            // 
            DtpDueTo.Format = DateTimePickerFormat.Short;
            DtpDueTo.Location = new Point(96, 227);
            DtpDueTo.Name = "DtpDueTo";
            DtpDueTo.Size = new Size(144, 31);
            DtpDueTo.TabIndex = 2;
            // 
            // LblMandetoryInfos
            // 
            LblMandetoryInfos.Anchor = AnchorStyles.Top;
            LblMandetoryInfos.AutoSize = true;
            LblMandetoryInfos.Location = new Point(169, 293);
            LblMandetoryInfos.Name = "LblMandetoryInfos";
            LblMandetoryInfos.Size = new Size(165, 25);
            LblMandetoryInfos.TabIndex = 10;
            LblMandetoryInfos.Text = "* = mandetory info";
            // 
            // AddBorrowEntryWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 334);
            Controls.Add(LblMandetoryInfos);
            Controls.Add(DtpDueTo);
            Controls.Add(LblDueTo);
            Controls.Add(BtnAddEntry);
            Controls.Add(GbReader);
            Controls.Add(GbBook);
            Name = "AddBorrowEntryWindow";
            Text = "New borrow entry";
            GbBook.ResumeLayout(false);
            GbBook.PerformLayout();
            GbReader.ResumeLayout(false);
            GbReader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox GbBook;
        private TextBox TxtSearchBook;
        private ListBox LbBooks;
        private GroupBox GbReader;
        private ListBox LbReaders;
        private TextBox TxtSearchReader;
        private Button BtnAddEntry;
        private Label LblDueTo;
        private DateTimePicker DtpDueTo;
        private Label LblMandetoryInfos;
    }
}