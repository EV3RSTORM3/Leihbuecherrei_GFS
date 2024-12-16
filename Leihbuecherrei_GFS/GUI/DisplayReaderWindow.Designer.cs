namespace Leihbuecherrei_GFS.GUI
{
    partial class DisplayReaderWindow
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
            components = new System.ComponentModel.Container();
            LblName = new Label();
            LblId = new Label();
            LblCity = new Label();
            LblAdress = new Label();
            LblBirthday = new Label();
            TxtName = new TextBox();
            TxtCity = new TextBox();
            TxtId = new TextBox();
            TxtAdress = new TextBox();
            DtpBirthday = new DateTimePicker();
            BtnApply = new Button();
            BtnCancel = new Button();
            BtnOk = new Button();
            BtnDelete = new Button();
            LblMandetoryInfos = new Label();
            GbReservationList = new GroupBox();
            LbReservations = new ListBox();
            BtnDeleteFromReservationList = new Button();
            BtnAddToReservationList = new Button();
            GbBorrowEntries = new GroupBox();
            BtnNewBorrowEntry = new Button();
            DgvBorrowEntries = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            borrowedOnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueToDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            returnedOnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            closedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            borrowEntryBindingSource = new BindingSource(components);
            GbFilters = new GroupBox();
            BtnReset = new Button();
            BtnBorrowEntrySearch = new Button();
            CbClosed = new CheckBox();
            CbReturned = new CheckBox();
            TxtSearchBorrowEntryBook = new TextBox();
            GbReservationList.SuspendLayout();
            GbBorrowEntries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBorrowEntries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borrowEntryBindingSource).BeginInit();
            GbFilters.SuspendLayout();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(12, 15);
            LblName.Name = "LblName";
            LblName.Size = new Size(71, 25);
            LblName.TabIndex = 0;
            LblName.Text = "*Name:";
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(382, 15);
            LblId.Name = "LblId";
            LblId.Size = new Size(34, 25);
            LblId.TabIndex = 1;
            LblId.Text = "ID:";
            // 
            // LblCity
            // 
            LblCity.AutoSize = true;
            LblCity.Location = new Point(12, 60);
            LblCity.Name = "LblCity";
            LblCity.Size = new Size(54, 25);
            LblCity.TabIndex = 2;
            LblCity.Text = "*City:";
            // 
            // LblAdress
            // 
            LblAdress.AutoSize = true;
            LblAdress.Location = new Point(230, 60);
            LblAdress.Name = "LblAdress";
            LblAdress.Size = new Size(78, 25);
            LblAdress.TabIndex = 3;
            LblAdress.Text = "*Adress:";
            // 
            // LblBirthday
            // 
            LblBirthday.AutoSize = true;
            LblBirthday.Location = new Point(472, 60);
            LblBirthday.Name = "LblBirthday";
            LblBirthday.Size = new Size(81, 25);
            LblBirthday.TabIndex = 4;
            LblBirthday.Text = "Birthday:";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(89, 12);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(259, 31);
            TxtName.TabIndex = 0;
            TxtName.TextChanged += ContentChanged;
            // 
            // TxtCity
            // 
            TxtCity.Location = new Point(72, 57);
            TxtCity.Name = "TxtCity";
            TxtCity.Size = new Size(150, 31);
            TxtCity.TabIndex = 1;
            TxtCity.TextChanged += ContentChanged;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(422, 12);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(150, 31);
            TxtId.TabIndex = 7;
            // 
            // TxtAdress
            // 
            TxtAdress.Location = new Point(314, 57);
            TxtAdress.Name = "TxtAdress";
            TxtAdress.Size = new Size(150, 31);
            TxtAdress.TabIndex = 2;
            TxtAdress.TextChanged += ContentChanged;
            // 
            // DtpBirthday
            // 
            DtpBirthday.Format = DateTimePickerFormat.Short;
            DtpBirthday.Location = new Point(559, 60);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(148, 31);
            DtpBirthday.TabIndex = 3;
            DtpBirthday.ValueChanged += ContentChanged;
            DtpBirthday.Enter += DtpBirthday_Enter;
            DtpBirthday.Leave += DtpBirthday_Leave;
            // 
            // BtnApply
            // 
            BtnApply.Enabled = false;
            BtnApply.Location = new Point(676, 591);
            BtnApply.Name = "BtnApply";
            BtnApply.Size = new Size(112, 34);
            BtnApply.TabIndex = 14;
            BtnApply.Text = "Apply";
            BtnApply.UseVisualStyleBackColor = true;
            BtnApply.Click += BtnApply_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(558, 591);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 34);
            BtnCancel.TabIndex = 13;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnOk
            // 
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(440, 591);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(112, 34);
            BtnOk.TabIndex = 12;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(646, 10);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(142, 34);
            BtnDelete.TabIndex = 13;
            BtnDelete.TabStop = false;
            BtnDelete.Text = "Delete Reader";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // LblMandetoryInfos
            // 
            LblMandetoryInfos.Anchor = AnchorStyles.Top;
            LblMandetoryInfos.AutoSize = true;
            LblMandetoryInfos.Location = new Point(623, 554);
            LblMandetoryInfos.Name = "LblMandetoryInfos";
            LblMandetoryInfos.Size = new Size(165, 25);
            LblMandetoryInfos.TabIndex = 15;
            LblMandetoryInfos.Text = "* = mandetory info";
            // 
            // GbReservationList
            // 
            GbReservationList.Controls.Add(LbReservations);
            GbReservationList.Controls.Add(BtnDeleteFromReservationList);
            GbReservationList.Controls.Add(BtnAddToReservationList);
            GbReservationList.Location = new Point(12, 100);
            GbReservationList.Name = "GbReservationList";
            GbReservationList.Size = new Size(209, 448);
            GbReservationList.TabIndex = 4;
            GbReservationList.TabStop = false;
            GbReservationList.Text = "Waiting List";
            // 
            // LbReservations
            // 
            LbReservations.Dock = DockStyle.Fill;
            LbReservations.FormattingEnabled = true;
            LbReservations.ItemHeight = 25;
            LbReservations.Location = new Point(3, 61);
            LbReservations.Name = "LbReservations";
            LbReservations.Size = new Size(203, 350);
            LbReservations.TabIndex = 1;
            // 
            // BtnDeleteFromReservationList
            // 
            BtnDeleteFromReservationList.Dock = DockStyle.Bottom;
            BtnDeleteFromReservationList.Location = new Point(3, 411);
            BtnDeleteFromReservationList.Name = "BtnDeleteFromReservationList";
            BtnDeleteFromReservationList.Size = new Size(203, 34);
            BtnDeleteFromReservationList.TabIndex = 2;
            BtnDeleteFromReservationList.Text = "Remove from waiting list";
            BtnDeleteFromReservationList.UseVisualStyleBackColor = true;
            BtnDeleteFromReservationList.Click += BtnDeleteFromReservationList_Click;
            // 
            // BtnAddToReservationList
            // 
            BtnAddToReservationList.Dock = DockStyle.Top;
            BtnAddToReservationList.Location = new Point(3, 27);
            BtnAddToReservationList.Name = "BtnAddToReservationList";
            BtnAddToReservationList.Size = new Size(203, 34);
            BtnAddToReservationList.TabIndex = 0;
            BtnAddToReservationList.Text = "Add to waiting list";
            BtnAddToReservationList.UseVisualStyleBackColor = true;
            BtnAddToReservationList.Click += BtnAddToReservationList_Click;
            // 
            // GbBorrowEntries
            // 
            GbBorrowEntries.Controls.Add(BtnNewBorrowEntry);
            GbBorrowEntries.Controls.Add(DgvBorrowEntries);
            GbBorrowEntries.Controls.Add(GbFilters);
            GbBorrowEntries.Location = new Point(230, 100);
            GbBorrowEntries.Name = "GbBorrowEntries";
            GbBorrowEntries.Size = new Size(561, 451);
            GbBorrowEntries.TabIndex = 29;
            GbBorrowEntries.TabStop = false;
            GbBorrowEntries.Text = "Borrow entries";
            // 
            // BtnNewBorrowEntry
            // 
            BtnNewBorrowEntry.Location = new Point(3, 414);
            BtnNewBorrowEntry.Name = "BtnNewBorrowEntry";
            BtnNewBorrowEntry.Size = new Size(165, 34);
            BtnNewBorrowEntry.TabIndex = 29;
            BtnNewBorrowEntry.Text = "New borrow entry";
            BtnNewBorrowEntry.UseVisualStyleBackColor = true;
            BtnNewBorrowEntry.Click += BtnNewBorrowEntry_Click;
            // 
            // DgvBorrowEntries
            // 
            DgvBorrowEntries.AllowUserToAddRows = false;
            DgvBorrowEntries.AllowUserToDeleteRows = false;
            DgvBorrowEntries.AllowUserToOrderColumns = true;
            DgvBorrowEntries.AutoGenerateColumns = false;
            DgvBorrowEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DgvBorrowEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBorrowEntries.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, bookDataGridViewTextBoxColumn, borrowedOnDataGridViewTextBoxColumn, dueToDataGridViewTextBoxColumn, returnedDataGridViewCheckBoxColumn, returnedOnDataGridViewTextBoxColumn, closedDataGridViewCheckBoxColumn });
            DgvBorrowEntries.DataSource = borrowEntryBindingSource;
            DgvBorrowEntries.Location = new Point(3, 132);
            DgvBorrowEntries.MultiSelect = false;
            DgvBorrowEntries.Name = "DgvBorrowEntries";
            DgvBorrowEntries.ReadOnly = true;
            DgvBorrowEntries.RowHeadersVisible = false;
            DgvBorrowEntries.RowHeadersWidth = 62;
            DgvBorrowEntries.RowTemplate.Height = 33;
            DgvBorrowEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvBorrowEntries.Size = new Size(555, 282);
            DgvBorrowEntries.TabIndex = 5;
            DgvBorrowEntries.DoubleClick += DgvBorrowEntries_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 64;
            // 
            // bookDataGridViewTextBoxColumn
            // 
            bookDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            bookDataGridViewTextBoxColumn.DataPropertyName = "Book";
            bookDataGridViewTextBoxColumn.HeaderText = "Book";
            bookDataGridViewTextBoxColumn.MinimumWidth = 8;
            bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            bookDataGridViewTextBoxColumn.ReadOnly = true;
            bookDataGridViewTextBoxColumn.Width = 200;
            // 
            // borrowedOnDataGridViewTextBoxColumn
            // 
            borrowedOnDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            borrowedOnDataGridViewTextBoxColumn.DataPropertyName = "BorrowedOn";
            borrowedOnDataGridViewTextBoxColumn.HeaderText = "BorrowedOn";
            borrowedOnDataGridViewTextBoxColumn.MinimumWidth = 8;
            borrowedOnDataGridViewTextBoxColumn.Name = "borrowedOnDataGridViewTextBoxColumn";
            borrowedOnDataGridViewTextBoxColumn.ReadOnly = true;
            borrowedOnDataGridViewTextBoxColumn.Width = 149;
            // 
            // dueToDataGridViewTextBoxColumn
            // 
            dueToDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dueToDataGridViewTextBoxColumn.DataPropertyName = "DueTo";
            dueToDataGridViewTextBoxColumn.HeaderText = "DueTo";
            dueToDataGridViewTextBoxColumn.MinimumWidth = 8;
            dueToDataGridViewTextBoxColumn.Name = "dueToDataGridViewTextBoxColumn";
            dueToDataGridViewTextBoxColumn.ReadOnly = true;
            dueToDataGridViewTextBoxColumn.Width = 98;
            // 
            // returnedDataGridViewCheckBoxColumn
            // 
            returnedDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            returnedDataGridViewCheckBoxColumn.DataPropertyName = "Returned";
            returnedDataGridViewCheckBoxColumn.HeaderText = "Returned";
            returnedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            returnedDataGridViewCheckBoxColumn.Name = "returnedDataGridViewCheckBoxColumn";
            returnedDataGridViewCheckBoxColumn.ReadOnly = true;
            returnedDataGridViewCheckBoxColumn.Width = 89;
            // 
            // returnedOnDataGridViewTextBoxColumn
            // 
            returnedOnDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            returnedOnDataGridViewTextBoxColumn.DataPropertyName = "ReturnedOn";
            returnedOnDataGridViewTextBoxColumn.HeaderText = "ReturnedOn";
            returnedOnDataGridViewTextBoxColumn.MinimumWidth = 8;
            returnedOnDataGridViewTextBoxColumn.Name = "returnedOnDataGridViewTextBoxColumn";
            returnedOnDataGridViewTextBoxColumn.ReadOnly = true;
            returnedOnDataGridViewTextBoxColumn.Width = 143;
            // 
            // closedDataGridViewCheckBoxColumn
            // 
            closedDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            closedDataGridViewCheckBoxColumn.DataPropertyName = "Closed";
            closedDataGridViewCheckBoxColumn.HeaderText = "Closed";
            closedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            closedDataGridViewCheckBoxColumn.Name = "closedDataGridViewCheckBoxColumn";
            closedDataGridViewCheckBoxColumn.ReadOnly = true;
            closedDataGridViewCheckBoxColumn.Width = 72;
            // 
            // borrowEntryBindingSource
            // 
            borrowEntryBindingSource.DataSource = typeof(BorrowEntry);
            // 
            // GbFilters
            // 
            GbFilters.BackColor = Color.Silver;
            GbFilters.Controls.Add(BtnReset);
            GbFilters.Controls.Add(BtnBorrowEntrySearch);
            GbFilters.Controls.Add(CbClosed);
            GbFilters.Controls.Add(CbReturned);
            GbFilters.Controls.Add(TxtSearchBorrowEntryBook);
            GbFilters.Dock = DockStyle.Top;
            GbFilters.Location = new Point(3, 27);
            GbFilters.Name = "GbFilters";
            GbFilters.Size = new Size(555, 105);
            GbFilters.TabIndex = 4;
            GbFilters.TabStop = false;
            GbFilters.Text = "Filters";
            // 
            // BtnReset
            // 
            BtnReset.Anchor = AnchorStyles.Right;
            BtnReset.Location = new Point(320, 65);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(111, 34);
            BtnReset.TabIndex = 6;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // BtnBorrowEntrySearch
            // 
            BtnBorrowEntrySearch.Anchor = AnchorStyles.Right;
            BtnBorrowEntrySearch.Location = new Point(438, 65);
            BtnBorrowEntrySearch.Name = "BtnBorrowEntrySearch";
            BtnBorrowEntrySearch.Size = new Size(111, 34);
            BtnBorrowEntrySearch.TabIndex = 7;
            BtnBorrowEntrySearch.Text = "Search";
            BtnBorrowEntrySearch.UseVisualStyleBackColor = true;
            BtnBorrowEntrySearch.Click += BtnBorrowEntrySearch_Click;
            // 
            // CbClosed
            // 
            CbClosed.AutoSize = true;
            CbClosed.Checked = true;
            CbClosed.CheckState = CheckState.Indeterminate;
            CbClosed.Location = new Point(320, 36);
            CbClosed.Name = "CbClosed";
            CbClosed.Size = new Size(92, 29);
            CbClosed.TabIndex = 3;
            CbClosed.Text = "Closed";
            CbClosed.ThreeState = true;
            CbClosed.UseVisualStyleBackColor = true;
            // 
            // CbReturned
            // 
            CbReturned.AutoSize = true;
            CbReturned.Checked = true;
            CbReturned.CheckState = CheckState.Indeterminate;
            CbReturned.Location = new Point(205, 36);
            CbReturned.Name = "CbReturned";
            CbReturned.Size = new Size(109, 29);
            CbReturned.TabIndex = 2;
            CbReturned.Text = "Retruned";
            CbReturned.ThreeState = true;
            CbReturned.UseVisualStyleBackColor = true;
            // 
            // TxtSearchBorrowEntryBook
            // 
            TxtSearchBorrowEntryBook.Location = new Point(10, 34);
            TxtSearchBorrowEntryBook.Margin = new Padding(10);
            TxtSearchBorrowEntryBook.Name = "TxtSearchBorrowEntryBook";
            TxtSearchBorrowEntryBook.PlaceholderText = "Book";
            TxtSearchBorrowEntryBook.Size = new Size(182, 31);
            TxtSearchBorrowEntryBook.TabIndex = 0;
            TxtSearchBorrowEntryBook.TextAlign = HorizontalAlignment.Center;
            // 
            // DisplayReaderWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
            Controls.Add(GbBorrowEntries);
            Controls.Add(GbReservationList);
            Controls.Add(LblMandetoryInfos);
            Controls.Add(BtnDelete);
            Controls.Add(BtnOk);
            Controls.Add(BtnCancel);
            Controls.Add(BtnApply);
            Controls.Add(DtpBirthday);
            Controls.Add(TxtAdress);
            Controls.Add(TxtId);
            Controls.Add(TxtCity);
            Controls.Add(TxtName);
            Controls.Add(LblBirthday);
            Controls.Add(LblAdress);
            Controls.Add(LblCity);
            Controls.Add(LblId);
            Controls.Add(LblName);
            MaximumSize = new Size(822, 693);
            MinimumSize = new Size(822, 693);
            Name = "DisplayReaderWindow";
            Text = "DisplayReaders";
            GbReservationList.ResumeLayout(false);
            GbBorrowEntries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvBorrowEntries).EndInit();
            ((System.ComponentModel.ISupportInitialize)borrowEntryBindingSource).EndInit();
            GbFilters.ResumeLayout(false);
            GbFilters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private Label LblId;
        private Label LblCity;
        private Label LblAdress;
        private Label LblBirthday;
        private TextBox TxtName;
        private TextBox TxtCity;
        private TextBox TxtId;
        private TextBox TxtAdress;
        private DateTimePicker DtpBirthday;
        private Button BtnApply;
        private Button BtnCancel;
        private Button BtnOk;
        private Button BtnDelete;
        private Label LblMandetoryInfos;
        private GroupBox GbReservationList;
        private Button BtnDeleteFromReservationList;
        private ListBox LbReservations;
        private Button BtnAddToReservationList;
        private GroupBox GbBorrowEntries;
        private Button BtnNewBorrowEntry;
        private DataGridView DgvBorrowEntries;
        private GroupBox GbFilters;
        private Button BtnReset;
        private Button BtnBorrowEntrySearch;
        private CheckBox CbClosed;
        private CheckBox CbReturned;
        private TextBox TxtSearchBorrowEntryBook;
        private Button BtnResetFilters;
        private BindingSource borrowEntryBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowedOnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueToDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn returnedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn returnedOnDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn closedDataGridViewCheckBoxColumn;
    }
}