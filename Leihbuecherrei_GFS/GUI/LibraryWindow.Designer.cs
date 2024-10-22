namespace Leihbuecherrei_GFS
{
    partial class LibraryWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            DgvBorrowEntries = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            readerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            borrowedOnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueToDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            returnedOnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            closedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            borrowEntryBindingSource = new BindingSource(components);
            GbFilters = new GroupBox();
            BtnBorrowEntrySearch = new Button();
            CbClosed = new CheckBox();
            CbReturned = new CheckBox();
            TxtSearchBorrowEntryBook = new TextBox();
            TxtSearchBorrowEntryReader = new TextBox();
            tabPage2 = new TabPage();
            BtnNewBorrowEntry = new Button();
            tabControl1 = new TabControl();
            readers = new TabPage();
            TxtSearchReader = new TextBox();
            BtnAddReader = new Button();
            LbReaders = new ListBox();
            readerBindingSource = new BindingSource(components);
            books = new TabPage();
            TxtSearchBook = new TextBox();
            LbBooks = new ListBox();
            bookBindingSource = new BindingSource(components);
            BtnAddBook = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBorrowEntries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borrowEntryBindingSource).BeginInit();
            GbFilters.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            readers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).BeginInit();
            books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(1254, 749);
            splitContainer1.SplitterDistance = 920;
            splitContainer1.SplitterWidth = 20;
            splitContainer1.TabIndex = 0;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(920, 749);
            tabControl2.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DgvBorrowEntries);
            tabPage1.Controls.Add(GbFilters);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(912, 711);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DgvBorrowEntries
            // 
            DgvBorrowEntries.AllowUserToAddRows = false;
            DgvBorrowEntries.AllowUserToDeleteRows = false;
            DgvBorrowEntries.AutoGenerateColumns = false;
            DgvBorrowEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBorrowEntries.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, bookDataGridViewTextBoxColumn, readerDataGridViewTextBoxColumn, borrowedOnDataGridViewTextBoxColumn, dueToDataGridViewTextBoxColumn, returnedDataGridViewCheckBoxColumn, returnedOnDataGridViewTextBoxColumn, closedDataGridViewCheckBoxColumn });
            DgvBorrowEntries.DataSource = borrowEntryBindingSource;
            DgvBorrowEntries.Dock = DockStyle.Fill;
            DgvBorrowEntries.Location = new Point(3, 127);
            DgvBorrowEntries.Name = "DgvBorrowEntries";
            DgvBorrowEntries.ReadOnly = true;
            DgvBorrowEntries.RowHeadersWidth = 62;
            DgvBorrowEntries.RowTemplate.Height = 33;
            DgvBorrowEntries.Size = new Size(906, 581);
            DgvBorrowEntries.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookDataGridViewTextBoxColumn
            // 
            bookDataGridViewTextBoxColumn.DataPropertyName = "Book";
            bookDataGridViewTextBoxColumn.HeaderText = "Book";
            bookDataGridViewTextBoxColumn.MinimumWidth = 8;
            bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            bookDataGridViewTextBoxColumn.ReadOnly = true;
            bookDataGridViewTextBoxColumn.Width = 150;
            // 
            // readerDataGridViewTextBoxColumn
            // 
            readerDataGridViewTextBoxColumn.DataPropertyName = "Reader";
            readerDataGridViewTextBoxColumn.HeaderText = "Reader";
            readerDataGridViewTextBoxColumn.MinimumWidth = 8;
            readerDataGridViewTextBoxColumn.Name = "readerDataGridViewTextBoxColumn";
            readerDataGridViewTextBoxColumn.ReadOnly = true;
            readerDataGridViewTextBoxColumn.Width = 150;
            // 
            // borrowedOnDataGridViewTextBoxColumn
            // 
            borrowedOnDataGridViewTextBoxColumn.DataPropertyName = "BorrowedOn";
            borrowedOnDataGridViewTextBoxColumn.HeaderText = "BorrowedOn";
            borrowedOnDataGridViewTextBoxColumn.MinimumWidth = 8;
            borrowedOnDataGridViewTextBoxColumn.Name = "borrowedOnDataGridViewTextBoxColumn";
            borrowedOnDataGridViewTextBoxColumn.ReadOnly = true;
            borrowedOnDataGridViewTextBoxColumn.Width = 150;
            // 
            // dueToDataGridViewTextBoxColumn
            // 
            dueToDataGridViewTextBoxColumn.DataPropertyName = "DueTo";
            dueToDataGridViewTextBoxColumn.HeaderText = "DueTo";
            dueToDataGridViewTextBoxColumn.MinimumWidth = 8;
            dueToDataGridViewTextBoxColumn.Name = "dueToDataGridViewTextBoxColumn";
            dueToDataGridViewTextBoxColumn.ReadOnly = true;
            dueToDataGridViewTextBoxColumn.Width = 150;
            // 
            // returnedDataGridViewCheckBoxColumn
            // 
            returnedDataGridViewCheckBoxColumn.DataPropertyName = "Returned";
            returnedDataGridViewCheckBoxColumn.HeaderText = "Returned";
            returnedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            returnedDataGridViewCheckBoxColumn.Name = "returnedDataGridViewCheckBoxColumn";
            returnedDataGridViewCheckBoxColumn.ReadOnly = true;
            returnedDataGridViewCheckBoxColumn.Width = 150;
            // 
            // returnedOnDataGridViewTextBoxColumn
            // 
            returnedOnDataGridViewTextBoxColumn.DataPropertyName = "ReturnedOn";
            returnedOnDataGridViewTextBoxColumn.HeaderText = "ReturnedOn";
            returnedOnDataGridViewTextBoxColumn.MinimumWidth = 8;
            returnedOnDataGridViewTextBoxColumn.Name = "returnedOnDataGridViewTextBoxColumn";
            returnedOnDataGridViewTextBoxColumn.ReadOnly = true;
            returnedOnDataGridViewTextBoxColumn.Width = 150;
            // 
            // closedDataGridViewCheckBoxColumn
            // 
            closedDataGridViewCheckBoxColumn.DataPropertyName = "Closed";
            closedDataGridViewCheckBoxColumn.HeaderText = "Closed";
            closedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            closedDataGridViewCheckBoxColumn.Name = "closedDataGridViewCheckBoxColumn";
            closedDataGridViewCheckBoxColumn.ReadOnly = true;
            closedDataGridViewCheckBoxColumn.Width = 150;
            // 
            // borrowEntryBindingSource
            // 
            borrowEntryBindingSource.DataSource = typeof(BorrowEntry);
            // 
            // GbFilters
            // 
            GbFilters.BackColor = Color.Silver;
            GbFilters.Controls.Add(BtnBorrowEntrySearch);
            GbFilters.Controls.Add(CbClosed);
            GbFilters.Controls.Add(CbReturned);
            GbFilters.Controls.Add(TxtSearchBorrowEntryBook);
            GbFilters.Controls.Add(TxtSearchBorrowEntryReader);
            GbFilters.Dock = DockStyle.Top;
            GbFilters.Location = new Point(3, 3);
            GbFilters.Name = "GbFilters";
            GbFilters.Size = new Size(906, 124);
            GbFilters.TabIndex = 3;
            GbFilters.TabStop = false;
            GbFilters.Text = "Filters";
            // 
            // BtnBorrowEntrySearch
            // 
            BtnBorrowEntrySearch.Anchor = AnchorStyles.Right;
            BtnBorrowEntrySearch.Location = new Point(760, 84);
            BtnBorrowEntrySearch.Name = "BtnBorrowEntrySearch";
            BtnBorrowEntrySearch.Size = new Size(140, 34);
            BtnBorrowEntrySearch.TabIndex = 9;
            BtnBorrowEntrySearch.Text = "Search";
            BtnBorrowEntrySearch.UseVisualStyleBackColor = true;
            BtnBorrowEntrySearch.Click += BtnBorrowEntrySearch_Click;
            // 
            // CbClosed
            // 
            CbClosed.AutoSize = true;
            CbClosed.Checked = true;
            CbClosed.CheckState = CheckState.Indeterminate;
            CbClosed.Location = new Point(125, 81);
            CbClosed.Name = "CbClosed";
            CbClosed.Size = new Size(92, 29);
            CbClosed.TabIndex = 7;
            CbClosed.Text = "Closed";
            CbClosed.ThreeState = true;
            CbClosed.UseVisualStyleBackColor = true;
            // 
            // CbReturned
            // 
            CbReturned.AutoSize = true;
            CbReturned.Checked = true;
            CbReturned.CheckState = CheckState.Indeterminate;
            CbReturned.Location = new Point(10, 81);
            CbReturned.Name = "CbReturned";
            CbReturned.Size = new Size(109, 29);
            CbReturned.TabIndex = 6;
            CbReturned.Text = "Retruned";
            CbReturned.ThreeState = true;
            CbReturned.UseVisualStyleBackColor = true;
            // 
            // TxtSearchBorrowEntryBook
            // 
            TxtSearchBorrowEntryBook.Location = new Point(215, 37);
            TxtSearchBorrowEntryBook.Margin = new Padding(10);
            TxtSearchBorrowEntryBook.Name = "TxtSearchBorrowEntryBook";
            TxtSearchBorrowEntryBook.PlaceholderText = "Book";
            TxtSearchBorrowEntryBook.Size = new Size(182, 31);
            TxtSearchBorrowEntryBook.TabIndex = 5;
            TxtSearchBorrowEntryBook.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtSearchBorrowEntryReader
            // 
            TxtSearchBorrowEntryReader.Location = new Point(13, 37);
            TxtSearchBorrowEntryReader.Margin = new Padding(10);
            TxtSearchBorrowEntryReader.Name = "TxtSearchBorrowEntryReader";
            TxtSearchBorrowEntryReader.PlaceholderText = "Reader";
            TxtSearchBorrowEntryReader.Size = new Size(182, 31);
            TxtSearchBorrowEntryReader.TabIndex = 4;
            TxtSearchBorrowEntryReader.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnNewBorrowEntry);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(912, 711);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnNewBorrowEntry
            // 
            BtnNewBorrowEntry.Location = new Point(442, 197);
            BtnNewBorrowEntry.Name = "BtnNewBorrowEntry";
            BtnNewBorrowEntry.Size = new Size(164, 34);
            BtnNewBorrowEntry.TabIndex = 1;
            BtnNewBorrowEntry.Text = "New borrow entry";
            BtnNewBorrowEntry.UseVisualStyleBackColor = true;
            BtnNewBorrowEntry.Click += BtnNewBorrowEntry_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(readers);
            tabControl1.Controls.Add(books);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(314, 749);
            tabControl1.TabIndex = 0;
            // 
            // readers
            // 
            readers.Controls.Add(LbReaders);
            readers.Controls.Add(TxtSearchReader);
            readers.Controls.Add(BtnAddReader);
            readers.Location = new Point(4, 34);
            readers.Margin = new Padding(4, 5, 4, 5);
            readers.Name = "readers";
            readers.Padding = new Padding(4, 5, 4, 5);
            readers.Size = new Size(306, 711);
            readers.TabIndex = 0;
            readers.Text = "Readers";
            readers.UseVisualStyleBackColor = true;
            // 
            // TxtSearchReader
            // 
            TxtSearchReader.Dock = DockStyle.Top;
            TxtSearchReader.Location = new Point(4, 43);
            TxtSearchReader.Margin = new Padding(10);
            TxtSearchReader.Name = "TxtSearchReader";
            TxtSearchReader.PlaceholderText = "Search Reader";
            TxtSearchReader.Size = new Size(298, 31);
            TxtSearchReader.TabIndex = 1;
            TxtSearchReader.TextAlign = HorizontalAlignment.Center;
            TxtSearchReader.KeyPress += TxtSearchReader_KeyPress;
            // 
            // BtnAddReader
            // 
            BtnAddReader.Dock = DockStyle.Top;
            BtnAddReader.Location = new Point(4, 5);
            BtnAddReader.Margin = new Padding(4, 5, 4, 5);
            BtnAddReader.Name = "BtnAddReader";
            BtnAddReader.Size = new Size(298, 38);
            BtnAddReader.TabIndex = 0;
            BtnAddReader.Text = "Add new reader";
            BtnAddReader.UseVisualStyleBackColor = true;
            BtnAddReader.Click += BtnAddReader_Click;
            // 
            // LbReaders
            // 
            LbReaders.BorderStyle = BorderStyle.FixedSingle;
            LbReaders.DataSource = readerBindingSource;
            LbReaders.Dock = DockStyle.Fill;
            LbReaders.FormattingEnabled = true;
            LbReaders.ItemHeight = 25;
            LbReaders.Location = new Point(4, 74);
            LbReaders.Name = "LbReaders";
            LbReaders.Size = new Size(298, 632);
            LbReaders.TabIndex = 4;
            LbReaders.DoubleClick += LbReaders_DoubleClick;
            // 
            // readerBindingSource
            // 
            readerBindingSource.DataSource = typeof(Reader);
            // 
            // books
            // 
            books.Controls.Add(LbBooks);
            books.Controls.Add(TxtSearchBook);
            books.Controls.Add(BtnAddBook);
            books.Location = new Point(4, 34);
            books.Margin = new Padding(4, 5, 4, 5);
            books.Name = "books";
            books.Padding = new Padding(4, 5, 4, 5);
            books.Size = new Size(306, 711);
            books.TabIndex = 1;
            books.Text = "Books";
            books.UseVisualStyleBackColor = true;
            // 
            // TxtSearchBook
            // 
            TxtSearchBook.Dock = DockStyle.Top;
            TxtSearchBook.Location = new Point(4, 43);
            TxtSearchBook.Name = "TxtSearchBook";
            TxtSearchBook.PlaceholderText = "Search Book";
            TxtSearchBook.Size = new Size(298, 31);
            TxtSearchBook.TabIndex = 3;
            TxtSearchBook.TextAlign = HorizontalAlignment.Center;
            TxtSearchBook.KeyPress += TxtSearchBook_KeyPress;
            // 
            // LbBooks
            // 
            LbBooks.DataSource = bookBindingSource;
            LbBooks.Dock = DockStyle.Fill;
            LbBooks.FormattingEnabled = true;
            LbBooks.ItemHeight = 25;
            LbBooks.Location = new Point(4, 74);
            LbBooks.Name = "LbBooks";
            LbBooks.Size = new Size(298, 632);
            LbBooks.TabIndex = 2;
            LbBooks.DoubleClick += LbBooks_DoubleClick;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // BtnAddBook
            // 
            BtnAddBook.Dock = DockStyle.Top;
            BtnAddBook.Location = new Point(4, 5);
            BtnAddBook.Margin = new Padding(4, 5, 4, 5);
            BtnAddBook.Name = "BtnAddBook";
            BtnAddBook.Size = new Size(298, 38);
            BtnAddBook.TabIndex = 0;
            BtnAddBook.Text = "Add new book";
            BtnAddBook.UseVisualStyleBackColor = true;
            BtnAddBook.Click += BtnAddBook_Click;
            // 
            // LibraryWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 749);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LibraryWindow";
            Text = "Library";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvBorrowEntries).EndInit();
            ((System.ComponentModel.ISupportInitialize)borrowEntryBindingSource).EndInit();
            GbFilters.ResumeLayout(false);
            GbFilters.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            readers.ResumeLayout(false);
            readers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).EndInit();
            books.ResumeLayout(false);
            books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage readers;
        private Button BtnAddReader;
        private TabPage books;
        private Button BtnAddBook;
        private TextBox TxtSearchReader;
        private ListBox LbReaders;
        private BindingSource readerBindingSource;
        private TextBox TxtSearchBook;
        private ListBox LbBooks;
        private BindingSource bookBindingSource;
        private Button BtnNewBorrowEntry;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox GbFilters;
        private CheckBox CbReturned;
        private TextBox TxtSearchBorrowEntryBook;
        private TextBox TxtSearchBorrowEntryReader;
        private CheckBox CbClosed;
        private Button BtnBorrowEntrySearch;
        private DataGridView DgvBorrowEntries;
        private BindingSource borrowEntryBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn readerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowedOnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueToDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn returnedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn returnedOnDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn closedDataGridViewCheckBoxColumn;
    }
}