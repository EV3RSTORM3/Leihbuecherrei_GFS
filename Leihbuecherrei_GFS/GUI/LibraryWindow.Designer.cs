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
            BtnNewBorrowEntry = new Button();
            listView1 = new ListView();
            tabControl1 = new TabControl();
            readers = new TabPage();
            TxtSearchReader = new TextBox();
            LbReaders = new ListBox();
            readerBindingSource = new BindingSource(components);
            BtnAddReader = new Button();
            books = new TabPage();
            TxtSearchBook = new TextBox();
            LbBooks = new ListBox();
            bookBindingSource = new BindingSource(components);
            BtnAddBook = new Button();
            controlBindingSource = new BindingSource(components);
            readerBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            readers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).BeginInit();
            books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controlBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource1).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(BtnNewBorrowEntry);
            splitContainer1.Panel1.Controls.Add(listView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(1143, 749);
            splitContainer1.SplitterDistance = 839;
            splitContainer1.SplitterWidth = 20;
            splitContainer1.TabIndex = 0;
            // 
            // BtnNewBorrowEntry
            // 
            BtnNewBorrowEntry.Location = new Point(12, 12);
            BtnNewBorrowEntry.Name = "BtnNewBorrowEntry";
            BtnNewBorrowEntry.Size = new Size(164, 34);
            BtnNewBorrowEntry.TabIndex = 1;
            BtnNewBorrowEntry.Text = "New borrow entry";
            BtnNewBorrowEntry.UseVisualStyleBackColor = true;
            BtnNewBorrowEntry.Click += BtnNewBorrowEntry_Click;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Bottom;
            listView1.Location = new Point(0, 202);
            listView1.Name = "listView1";
            listView1.Size = new Size(839, 547);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
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
            tabControl1.Size = new Size(284, 749);
            tabControl1.TabIndex = 0;
            // 
            // readers
            // 
            readers.Controls.Add(TxtSearchReader);
            readers.Controls.Add(LbReaders);
            readers.Controls.Add(BtnAddReader);
            readers.Location = new Point(4, 34);
            readers.Margin = new Padding(4, 5, 4, 5);
            readers.Name = "readers";
            readers.Padding = new Padding(4, 5, 4, 5);
            readers.Size = new Size(276, 711);
            readers.TabIndex = 0;
            readers.Text = "Readers";
            readers.UseVisualStyleBackColor = true;
            // 
            // TxtSearchReader
            // 
            TxtSearchReader.Dock = DockStyle.Bottom;
            TxtSearchReader.Location = new Point(4, 46);
            TxtSearchReader.Margin = new Padding(10);
            TxtSearchReader.Name = "TxtSearchReader";
            TxtSearchReader.PlaceholderText = "Search Reader";
            TxtSearchReader.Size = new Size(268, 31);
            TxtSearchReader.TabIndex = 1;
            TxtSearchReader.TextAlign = HorizontalAlignment.Center;
            TxtSearchReader.KeyPress += TxtSearchReader_KeyPress;
            // 
            // LbReaders
            // 
            LbReaders.DataSource = readerBindingSource;
            LbReaders.Dock = DockStyle.Bottom;
            LbReaders.FormattingEnabled = true;
            LbReaders.ItemHeight = 25;
            LbReaders.Location = new Point(4, 77);
            LbReaders.Name = "LbReaders";
            LbReaders.Size = new Size(268, 629);
            LbReaders.TabIndex = 2;
            LbReaders.DoubleClick += LbReaders_DoubleClick;
            // 
            // readerBindingSource
            // 
            readerBindingSource.DataSource = typeof(Reader);
            // 
            // BtnAddReader
            // 
            BtnAddReader.Dock = DockStyle.Top;
            BtnAddReader.Location = new Point(4, 5);
            BtnAddReader.Margin = new Padding(4, 5, 4, 5);
            BtnAddReader.Name = "BtnAddReader";
            BtnAddReader.Size = new Size(268, 38);
            BtnAddReader.TabIndex = 0;
            BtnAddReader.Text = "Add new reader";
            BtnAddReader.UseVisualStyleBackColor = true;
            BtnAddReader.Click += BtnAddReader_Click;
            // 
            // books
            // 
            books.Controls.Add(TxtSearchBook);
            books.Controls.Add(LbBooks);
            books.Controls.Add(BtnAddBook);
            books.Location = new Point(4, 34);
            books.Margin = new Padding(4, 5, 4, 5);
            books.Name = "books";
            books.Padding = new Padding(4, 5, 4, 5);
            books.Size = new Size(276, 711);
            books.TabIndex = 1;
            books.Text = "Books";
            books.UseVisualStyleBackColor = true;
            // 
            // TxtSearchBook
            // 
            TxtSearchBook.Dock = DockStyle.Bottom;
            TxtSearchBook.Location = new Point(4, 46);
            TxtSearchBook.Name = "TxtSearchBook";
            TxtSearchBook.PlaceholderText = "Search Book";
            TxtSearchBook.Size = new Size(268, 31);
            TxtSearchBook.TabIndex = 3;
            TxtSearchBook.TextAlign = HorizontalAlignment.Center;
            TxtSearchBook.KeyPress += TxtSearchBook_KeyPress;
            // 
            // LbBooks
            // 
            LbBooks.DataSource = bookBindingSource;
            LbBooks.Dock = DockStyle.Bottom;
            LbBooks.FormattingEnabled = true;
            LbBooks.ItemHeight = 25;
            LbBooks.Location = new Point(4, 77);
            LbBooks.Name = "LbBooks";
            LbBooks.Size = new Size(268, 629);
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
            BtnAddBook.Size = new Size(268, 38);
            BtnAddBook.TabIndex = 0;
            BtnAddBook.Text = "Add new book";
            BtnAddBook.UseVisualStyleBackColor = true;
            BtnAddBook.Click += BtnAddBook_Click;
            // 
            // controlBindingSource
            // 
            controlBindingSource.DataSource = typeof(Control);
            // 
            // readerBindingSource1
            // 
            readerBindingSource1.DataSource = typeof(Reader);
            // 
            // LibraryWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 749);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LibraryWindow";
            Text = "Library";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            readers.ResumeLayout(false);
            readers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).EndInit();
            books.ResumeLayout(false);
            books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)controlBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource1).EndInit();
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
        private BindingSource controlBindingSource;
        private BindingSource readerBindingSource;
        private TextBox TxtSearchBook;
        private ListBox LbBooks;
        private BindingSource readerBindingSource1;
        private BindingSource bookBindingSource;
        private Button BtnNewBorrowEntry;
        private ListView listView1;
    }
}