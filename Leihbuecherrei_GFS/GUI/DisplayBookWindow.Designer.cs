namespace Leihbuecherrei_GFS.GUI
{
    partial class DisplayBookWindow
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
            BtnOk = new Button();
            BtnCancel = new Button();
            BtnApply = new Button();
            BtnDelete = new Button();
            TxtAuthor = new TextBox();
            TxtId = new TextBox();
            TxtPublisher = new TextBox();
            TxtTitle = new TextBox();
            LblAuthor = new Label();
            LblPublisher = new Label();
            LblId = new Label();
            LblTitle = new Label();
            LblMandatoryInfos = new Label();
            CbAvailable = new CheckBox();
            GbReservationList = new GroupBox();
            LbReservations = new ListBox();
            BtnAddToReservationList = new Button();
            BtnDeleteFromReservationList = new Button();
            GbBorrowEntries = new GroupBox();
            BtnNewBorrowEntry = new Button();
            DgvBorrowEntries = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            readerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            TxtSearchBorrowEntryReader = new TextBox();
            GbReservationList.SuspendLayout();
            GbBorrowEntries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBorrowEntries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borrowEntryBindingSource).BeginInit();
            GbFilters.SuspendLayout();
            SuspendLayout();
            // 
            // BtnOk
            // 
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(440, 591);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(112, 34);
            BtnOk.TabIndex = 15;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(558, 591);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 34);
            BtnCancel.TabIndex = 16;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnApply
            // 
            BtnApply.Enabled = false;
            BtnApply.Location = new Point(676, 591);
            BtnApply.Name = "BtnApply";
            BtnApply.Size = new Size(112, 34);
            BtnApply.TabIndex = 17;
            BtnApply.Text = "Apply";
            BtnApply.UseVisualStyleBackColor = true;
            BtnApply.Click += BtnApply_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(649, 10);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(142, 34);
            BtnDelete.TabIndex = 3;
            BtnDelete.TabStop = false;
            BtnDelete.Text = "Delete Book";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // TxtAuthor
            // 
            TxtAuthor.Location = new Point(385, 57);
            TxtAuthor.Name = "TxtAuthor";
            TxtAuthor.Size = new Size(150, 31);
            TxtAuthor.TabIndex = 3;
            TxtAuthor.TextChanged += ContentChanged;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(466, 12);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(150, 31);
            TxtId.TabIndex = 23;
            // 
            // TxtPublisher
            // 
            TxtPublisher.Location = new Point(109, 57);
            TxtPublisher.Name = "TxtPublisher";
            TxtPublisher.Size = new Size(150, 31);
            TxtPublisher.TabIndex = 2;
            TxtPublisher.TextChanged += ContentChanged;
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(77, 12);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(336, 31);
            TxtTitle.TabIndex = 1;
            TxtTitle.TextChanged += ContentChanged;
            // 
            // LblAuthor
            // 
            LblAuthor.AutoSize = true;
            LblAuthor.Location = new Point(308, 60);
            LblAuthor.Name = "LblAuthor";
            LblAuthor.Size = new Size(71, 25);
            LblAuthor.TabIndex = 19;
            LblAuthor.Text = "Author:";
            // 
            // LblPublisher
            // 
            LblPublisher.AutoSize = true;
            LblPublisher.Location = new Point(15, 60);
            LblPublisher.Name = "LblPublisher";
            LblPublisher.Size = new Size(88, 25);
            LblPublisher.TabIndex = 18;
            LblPublisher.Text = "Publisher:";
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(426, 15);
            LblId.Name = "LblId";
            LblId.Size = new Size(34, 25);
            LblId.TabIndex = 17;
            LblId.Text = "ID:";
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Location = new Point(15, 15);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(56, 25);
            LblTitle.TabIndex = 16;
            LblTitle.Text = "*Title:";
            // 
            // LblMandatoryInfos
            // 
            LblMandatoryInfos.Anchor = AnchorStyles.Top;
            LblMandatoryInfos.AutoSize = true;
            LblMandatoryInfos.Location = new Point(623, 563);
            LblMandatoryInfos.Name = "LblMandatoryInfos";
            LblMandatoryInfos.Size = new Size(165, 25);
            LblMandatoryInfos.TabIndex = 27;
            LblMandatoryInfos.Text = "* = mandatory info";
            // 
            // CbAvailable
            // 
            CbAvailable.AutoSize = true;
            CbAvailable.CheckAlign = ContentAlignment.MiddleRight;
            CbAvailable.Location = new Point(592, 59);
            CbAvailable.Name = "CbAvailable";
            CbAvailable.Size = new Size(113, 29);
            CbAvailable.TabIndex = 4;
            CbAvailable.Text = "Available:";
            CbAvailable.UseVisualStyleBackColor = true;
            // 
            // GbReservationList
            // 
            GbReservationList.Controls.Add(LbReservations);
            GbReservationList.Controls.Add(BtnAddToReservationList);
            GbReservationList.Controls.Add(BtnDeleteFromReservationList);
            GbReservationList.Location = new Point(15, 109);
            GbReservationList.Name = "GbReservationList";
            GbReservationList.Size = new Size(209, 451);
            GbReservationList.TabIndex = 5;
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
            LbReservations.Size = new Size(203, 353);
            LbReservations.TabIndex = 1;
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
            // BtnDeleteFromReservationList
            // 
            BtnDeleteFromReservationList.Dock = DockStyle.Bottom;
            BtnDeleteFromReservationList.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDeleteFromReservationList.Location = new Point(3, 414);
            BtnDeleteFromReservationList.Name = "BtnDeleteFromReservationList";
            BtnDeleteFromReservationList.Size = new Size(203, 34);
            BtnDeleteFromReservationList.TabIndex = 2;
            BtnDeleteFromReservationList.Text = "Remove from waiting list";
            BtnDeleteFromReservationList.UseVisualStyleBackColor = true;
            BtnDeleteFromReservationList.Click += BtnDeleteFromReservationList_Click;
            // 
            // GbBorrowEntries
            // 
            GbBorrowEntries.Controls.Add(BtnNewBorrowEntry);
            GbBorrowEntries.Controls.Add(DgvBorrowEntries);
            GbBorrowEntries.Controls.Add(GbFilters);
            GbBorrowEntries.Location = new Point(230, 109);
            GbBorrowEntries.Name = "GbBorrowEntries";
            GbBorrowEntries.Size = new Size(561, 451);
            GbBorrowEntries.TabIndex = 28;
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
            DgvBorrowEntries.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, readerDataGridViewTextBoxColumn, borrowedOnDataGridViewTextBoxColumn, dueToDataGridViewTextBoxColumn, returnedDataGridViewCheckBoxColumn, returnedOnDataGridViewTextBoxColumn, closedDataGridViewCheckBoxColumn });
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
            // readerDataGridViewTextBoxColumn
            // 
            readerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            readerDataGridViewTextBoxColumn.DataPropertyName = "Reader";
            readerDataGridViewTextBoxColumn.HeaderText = "Reader";
            readerDataGridViewTextBoxColumn.MinimumWidth = 8;
            readerDataGridViewTextBoxColumn.Name = "readerDataGridViewTextBoxColumn";
            readerDataGridViewTextBoxColumn.ReadOnly = true;
            readerDataGridViewTextBoxColumn.Width = 200;
            // 
            // borrowedOnDataGridViewTextBoxColumn
            // 
            borrowedOnDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            borrowedOnDataGridViewTextBoxColumn.DataPropertyName = "BorrowedOn";
            borrowedOnDataGridViewTextBoxColumn.HeaderText = "Borrowed on";
            borrowedOnDataGridViewTextBoxColumn.MinimumWidth = 8;
            borrowedOnDataGridViewTextBoxColumn.Name = "borrowedOnDataGridViewTextBoxColumn";
            borrowedOnDataGridViewTextBoxColumn.ReadOnly = true;
            borrowedOnDataGridViewTextBoxColumn.Width = 151;
            // 
            // dueToDataGridViewTextBoxColumn
            // 
            dueToDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dueToDataGridViewTextBoxColumn.DataPropertyName = "DueTo";
            dueToDataGridViewTextBoxColumn.HeaderText = "Due to";
            dueToDataGridViewTextBoxColumn.MinimumWidth = 8;
            dueToDataGridViewTextBoxColumn.Name = "dueToDataGridViewTextBoxColumn";
            dueToDataGridViewTextBoxColumn.ReadOnly = true;
            dueToDataGridViewTextBoxColumn.Width = 102;
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
            returnedOnDataGridViewTextBoxColumn.HeaderText = "Returned on";
            returnedOnDataGridViewTextBoxColumn.MinimumWidth = 8;
            returnedOnDataGridViewTextBoxColumn.Name = "returnedOnDataGridViewTextBoxColumn";
            returnedOnDataGridViewTextBoxColumn.ReadOnly = true;
            returnedOnDataGridViewTextBoxColumn.Width = 145;
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
            GbFilters.Controls.Add(TxtSearchBorrowEntryReader);
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
            BtnReset.TabIndex = 4;
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
            BtnBorrowEntrySearch.TabIndex = 5;
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
            CbReturned.Text = "Returned";
            CbReturned.ThreeState = true;
            CbReturned.UseVisualStyleBackColor = true;
            // 
            // TxtSearchBorrowEntryReader
            // 
            TxtSearchBorrowEntryReader.Location = new Point(10, 34);
            TxtSearchBorrowEntryReader.Margin = new Padding(10);
            TxtSearchBorrowEntryReader.Name = "TxtSearchBorrowEntryReader";
            TxtSearchBorrowEntryReader.PlaceholderText = "Reader";
            TxtSearchBorrowEntryReader.Size = new Size(182, 31);
            TxtSearchBorrowEntryReader.TabIndex = 0;
            TxtSearchBorrowEntryReader.TextAlign = HorizontalAlignment.Center;
            // 
            // DisplayBookWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
            Controls.Add(GbBorrowEntries);
            Controls.Add(GbReservationList);
            Controls.Add(CbAvailable);
            Controls.Add(LblMandatoryInfos);
            Controls.Add(BtnDelete);
            Controls.Add(TxtAuthor);
            Controls.Add(TxtId);
            Controls.Add(TxtPublisher);
            Controls.Add(TxtTitle);
            Controls.Add(LblAuthor);
            Controls.Add(LblPublisher);
            Controls.Add(LblId);
            Controls.Add(LblTitle);
            Controls.Add(BtnOk);
            Controls.Add(BtnCancel);
            Controls.Add(BtnApply);
            MaximizeBox = false;
            MaximumSize = new Size(822, 693);
            MinimizeBox = false;
            MinimumSize = new Size(822, 693);
            Name = "DisplayBookWindow";
            Text = "DisplayBook";
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

        private Button BtnOk;
        private Button BtnCancel;
        private Button BtnApply;
        private Button BtnDelete;
        private TextBox TxtAuthor;
        private TextBox TxtId;
        private TextBox TxtPublisher;
        private TextBox TxtTitle;
        private Label LblAuthor;
        private Label LblPublisher;
        private Label LblId;
        private Label LblTitle;
        private Label LblMandatoryInfos;
        private CheckBox CbAvailable;
        private GroupBox GbReservationList;
        private Button BtnDeleteFromReservationList;
        private ListBox LbReservations;
        private Button BtnAddToReservationList;
        private GroupBox GbBorrowEntries;
        private DataGridView DgvBorrowEntries;
        private GroupBox GbFilters;
        private Button BtnReset;
        private Button BtnBorrowEntrySearch;
        private CheckBox CbClosed;
        private CheckBox CbReturned;
        private TextBox TxtSearchBorrowEntryReader;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn readerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowedOnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueToDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn returnedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn returnedOnDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn closedDataGridViewCheckBoxColumn;
        private BindingSource borrowEntryBindingSource;
        private Button BtnNewBorrowEntry;
    }
}