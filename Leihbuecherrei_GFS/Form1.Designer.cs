﻿namespace Leihbuecherrei_GFS
{
    partial class Form1
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
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            readers = new TabPage();
            addReader = new Button();
            books = new TabPage();
            addBook = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            readers.SuspendLayout();
            books.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 608;
            splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(readers);
            tabControl1.Controls.Add(books);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(188, 450);
            tabControl1.TabIndex = 0;
            // 
            // readers
            // 
            readers.Controls.Add(addReader);
            readers.Location = new Point(4, 24);
            readers.Name = "readers";
            readers.Padding = new Padding(3);
            readers.Size = new Size(180, 422);
            readers.TabIndex = 0;
            readers.Text = "Readers";
            readers.UseVisualStyleBackColor = true;
            // 
            // addReader
            // 
            addReader.Dock = DockStyle.Top;
            addReader.Location = new Point(3, 3);
            addReader.Name = "addReader";
            addReader.Size = new Size(174, 23);
            addReader.TabIndex = 0;
            addReader.Text = "Add new reader";
            addReader.UseVisualStyleBackColor = true;
            // 
            // books
            // 
            books.Controls.Add(addBook);
            books.Location = new Point(4, 24);
            books.Name = "books";
            books.Padding = new Padding(3);
            books.Size = new Size(180, 422);
            books.TabIndex = 1;
            books.Text = "Books";
            books.UseVisualStyleBackColor = true;
            // 
            // addBook
            // 
            addBook.Dock = DockStyle.Top;
            addBook.Location = new Point(3, 3);
            addBook.Name = "addBook";
            addBook.Size = new Size(174, 23);
            addBook.TabIndex = 0;
            addBook.Text = "add new Book";
            addBook.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            readers.ResumeLayout(false);
            books.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage readers;
        private Button addReader;
        private TabPage books;
        private Button addBook;
    }
}