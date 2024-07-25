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
            tabControl1 = new TabControl();
            readers = new TabPage();
            TxtSearchReader = new TextBox();
            LbReaders = new ListBox();
            BtnAddReader = new Button();
            books = new TabPage();
            BtnAddBook = new Button();
            controlBindingSource = new BindingSource(components);
            readerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            readers.SuspendLayout();
            books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)controlBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(1143, 750);
            splitContainer1.SplitterDistance = 867;
            splitContainer1.SplitterWidth = 20;
            splitContainer1.TabIndex = 0;
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
            tabControl1.Size = new Size(256, 750);
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
            readers.Size = new Size(248, 712);
            readers.TabIndex = 0;
            readers.Text = "Readers";
            readers.UseVisualStyleBackColor = true;
            // 
            // TxtSearchReader
            // 
            TxtSearchReader.Location = new Point(4, 63);
            TxtSearchReader.Name = "TxtSearchReader";
            TxtSearchReader.PlaceholderText = "Search Reader";
            TxtSearchReader.Size = new Size(240, 31);
            TxtSearchReader.TabIndex = 2;
            TxtSearchReader.TextAlign = HorizontalAlignment.Center;
            // 
            // LbReaders
            // 
            LbReaders.DataSource = readerBindingSource;
            LbReaders.FormattingEnabled = true;
            LbReaders.ItemHeight = 25;
            LbReaders.Location = new Point(4, 100);
            LbReaders.Name = "LbReaders";
            LbReaders.Size = new Size(240, 604);
            LbReaders.TabIndex = 1;
            LbReaders.DoubleClick += LbReaders_DoubleClick;
            // 
            // BtnAddReader
            // 
            BtnAddReader.Dock = DockStyle.Top;
            BtnAddReader.Location = new Point(4, 5);
            BtnAddReader.Margin = new Padding(4, 5, 4, 5);
            BtnAddReader.Name = "BtnAddReader";
            BtnAddReader.Size = new Size(240, 38);
            BtnAddReader.TabIndex = 0;
            BtnAddReader.Text = "Add new reader";
            BtnAddReader.UseVisualStyleBackColor = true;
            BtnAddReader.Click += BtnAddReader_Click;
            // 
            // books
            // 
            books.Controls.Add(BtnAddBook);
            books.Location = new Point(4, 34);
            books.Margin = new Padding(4, 5, 4, 5);
            books.Name = "books";
            books.Padding = new Padding(4, 5, 4, 5);
            books.Size = new Size(248, 712);
            books.TabIndex = 1;
            books.Text = "Books";
            books.UseVisualStyleBackColor = true;
            // 
            // BtnAddBook
            // 
            BtnAddBook.Dock = DockStyle.Top;
            BtnAddBook.Location = new Point(4, 5);
            BtnAddBook.Margin = new Padding(4, 5, 4, 5);
            BtnAddBook.Name = "BtnAddBook";
            BtnAddBook.Size = new Size(240, 38);
            BtnAddBook.TabIndex = 0;
            BtnAddBook.Text = "Add new book";
            BtnAddBook.UseVisualStyleBackColor = true;
            BtnAddBook.Click += BtnAddBook_Click;
            // 
            // controlBindingSource
            // 
            controlBindingSource.DataSource = typeof(Control);
            // 
            // readerBindingSource
            // 
            readerBindingSource.DataSource = typeof(Reader);
            // 
            // LibraryWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LibraryWindow";
            Text = "Library";
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            readers.ResumeLayout(false);
            readers.PerformLayout();
            books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)controlBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).EndInit();
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
    }
}