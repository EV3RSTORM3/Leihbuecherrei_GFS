namespace Leihbuecherrei_GFS.GUI
{
    partial class DisplayBorrowEntryWindow
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
            TxtId = new TextBox();
            LblId = new Label();
            BtnDelete = new Button();
            CbReturned = new CheckBox();
            CbClosed = new CheckBox();
            LblBorrowedOn = new Label();
            DtpBorrowedOn = new DateTimePicker();
            DtpDueTo = new DateTimePicker();
            LblDueTo = new Label();
            GbReturned = new GroupBox();
            DtpReturnedOn = new DateTimePicker();
            LblReturnedOn = new Label();
            BtnOk = new Button();
            BtnCancel = new Button();
            BtnApply = new Button();
            LblMandetoryInfos = new Label();
            GbReader.SuspendLayout();
            GbBook.SuspendLayout();
            GbReturned.SuspendLayout();
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
            TxtSearchReader.TextChanged += ContentChanged;
            TxtSearchReader.KeyPress += TxtSearchReader_KeyPress;
            // 
            // GbBook
            // 
            GbBook.BackColor = SystemColors.ButtonShadow;
            GbBook.Controls.Add(LbBooks);
            GbBook.Controls.Add(TxtSearchBook);
            GbBook.Location = new Point(12, 231);
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
            TxtSearchBook.TextChanged += ContentChanged;
            TxtSearchBook.KeyPress += TxtSearchBook_KeyPress;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(280, 12);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(150, 31);
            TxtId.TabIndex = 25;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(240, 15);
            LblId.Name = "LblId";
            LblId.Size = new Size(34, 25);
            LblId.TabIndex = 24;
            LblId.Text = "ID:";
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(547, 9);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(112, 34);
            BtnDelete.TabIndex = 26;
            BtnDelete.TabStop = false;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // CbReturned
            // 
            CbReturned.AutoSize = true;
            CbReturned.CheckAlign = ContentAlignment.MiddleRight;
            CbReturned.Location = new Point(6, 0);
            CbReturned.Name = "CbReturned";
            CbReturned.Size = new Size(113, 29);
            CbReturned.TabIndex = 0;
            CbReturned.Text = "Returned:";
            CbReturned.UseVisualStyleBackColor = true;
            CbReturned.CheckedChanged += CbReturned_CheckedChanged;
            // 
            // CbClosed
            // 
            CbClosed.AutoSize = true;
            CbClosed.CheckAlign = ContentAlignment.MiddleRight;
            CbClosed.Location = new Point(240, 298);
            CbClosed.Name = "CbClosed";
            CbClosed.Size = new Size(96, 29);
            CbClosed.TabIndex = 5;
            CbClosed.Text = "Closed:";
            CbClosed.UseVisualStyleBackColor = true;
            CbClosed.CheckedChanged += ContentChanged;
            // 
            // LblBorrowedOn
            // 
            LblBorrowedOn.AutoSize = true;
            LblBorrowedOn.Location = new Point(240, 79);
            LblBorrowedOn.Name = "LblBorrowedOn";
            LblBorrowedOn.Size = new Size(127, 25);
            LblBorrowedOn.TabIndex = 29;
            LblBorrowedOn.Text = "*Borrowed on:";
            // 
            // DtpBorrowedOn
            // 
            DtpBorrowedOn.Format = DateTimePickerFormat.Short;
            DtpBorrowedOn.Location = new Point(373, 74);
            DtpBorrowedOn.Name = "DtpBorrowedOn";
            DtpBorrowedOn.Size = new Size(143, 31);
            DtpBorrowedOn.TabIndex = 2;
            DtpBorrowedOn.ValueChanged += ContentChanged;
            // 
            // DtpDueTo
            // 
            DtpDueTo.Format = DateTimePickerFormat.Short;
            DtpDueTo.Location = new Point(324, 117);
            DtpDueTo.Name = "DtpDueTo";
            DtpDueTo.Size = new Size(143, 31);
            DtpDueTo.TabIndex = 3;
            DtpDueTo.ValueChanged += ContentChanged;
            // 
            // LblDueTo
            // 
            LblDueTo.AutoSize = true;
            LblDueTo.Location = new Point(240, 122);
            LblDueTo.Name = "LblDueTo";
            LblDueTo.Size = new Size(78, 25);
            LblDueTo.TabIndex = 31;
            LblDueTo.Text = "*Due to:";
            // 
            // GbReturned
            // 
            GbReturned.BackColor = SystemColors.ButtonShadow;
            GbReturned.Controls.Add(DtpReturnedOn);
            GbReturned.Controls.Add(LblReturnedOn);
            GbReturned.Controls.Add(CbReturned);
            GbReturned.Location = new Point(240, 177);
            GbReturned.Name = "GbReturned";
            GbReturned.Size = new Size(300, 87);
            GbReturned.TabIndex = 4;
            GbReturned.TabStop = false;
            // 
            // DtpReturnedOn
            // 
            DtpReturnedOn.Format = DateTimePickerFormat.Short;
            DtpReturnedOn.Location = new Point(128, 36);
            DtpReturnedOn.Name = "DtpReturnedOn";
            DtpReturnedOn.Size = new Size(143, 31);
            DtpReturnedOn.TabIndex = 1;
            // 
            // LblReturnedOn
            // 
            LblReturnedOn.AutoSize = true;
            LblReturnedOn.Location = new Point(9, 41);
            LblReturnedOn.Name = "LblReturnedOn";
            LblReturnedOn.Size = new Size(113, 25);
            LblReturnedOn.TabIndex = 33;
            LblReturnedOn.Text = "Returned on:";
            // 
            // BtnOk
            // 
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(311, 404);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(112, 34);
            BtnOk.TabIndex = 6;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(429, 404);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 34);
            BtnCancel.TabIndex = 7;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnApply
            // 
            BtnApply.Enabled = false;
            BtnApply.Location = new Point(547, 404);
            BtnApply.Name = "BtnApply";
            BtnApply.Size = new Size(112, 34);
            BtnApply.TabIndex = 8;
            BtnApply.Text = "Apply";
            BtnApply.UseVisualStyleBackColor = true;
            BtnApply.Click += BtnApply_Click;
            // 
            // LblMandetoryInfos
            // 
            LblMandetoryInfos.Anchor = AnchorStyles.Top;
            LblMandetoryInfos.AutoSize = true;
            LblMandetoryInfos.Location = new Point(494, 376);
            LblMandetoryInfos.Name = "LblMandetoryInfos";
            LblMandetoryInfos.Size = new Size(165, 25);
            LblMandetoryInfos.TabIndex = 37;
            LblMandetoryInfos.Text = "* = mandetory info";
            // 
            // DisplayBorrowEntryWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 450);
            Controls.Add(LblMandetoryInfos);
            Controls.Add(BtnOk);
            Controls.Add(BtnCancel);
            Controls.Add(BtnApply);
            Controls.Add(GbReturned);
            Controls.Add(DtpDueTo);
            Controls.Add(LblDueTo);
            Controls.Add(DtpBorrowedOn);
            Controls.Add(LblBorrowedOn);
            Controls.Add(CbClosed);
            Controls.Add(BtnDelete);
            Controls.Add(TxtId);
            Controls.Add(LblId);
            Controls.Add(GbReader);
            Controls.Add(GbBook);
            MaximizeBox = false;
            MaximumSize = new Size(693, 506);
            MinimizeBox = false;
            MinimumSize = new Size(693, 506);
            Name = "DisplayBorrowEntryWindow";
            Text = "DisplayBorrowEntryWindow";
            GbReader.ResumeLayout(false);
            GbReader.PerformLayout();
            GbBook.ResumeLayout(false);
            GbBook.PerformLayout();
            GbReturned.ResumeLayout(false);
            GbReturned.PerformLayout();
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
        private TextBox TxtId;
        private Label LblId;
        private Button BtnDelete;
        private CheckBox CbReturned;
        private CheckBox CbClosed;
        private Label LblBorrowedOn;
        private DateTimePicker DtpBorrowedOn;
        private DateTimePicker DtpDueTo;
        private Label LblDueTo;
        private GroupBox GbReturned;
        private Label LblReturnedOn;
        private Button BtnOk;
        private Button BtnCancel;
        private Button BtnApply;
        private Label LblMandetoryInfos;
        private DateTimePicker DtpReturnedOn;
    }
}