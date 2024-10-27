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
            BtnSaveAndClose = new Button();
            BtnClose = new Button();
            BtnSave = new Button();
            BtnDelete = new Button();
            TxtAuthor = new TextBox();
            TxtId = new TextBox();
            TxtPublisher = new TextBox();
            TxtTitle = new TextBox();
            LblAuthor = new Label();
            LblPublisher = new Label();
            LblId = new Label();
            LblTitle = new Label();
            LblMandetoryInfos = new Label();
            SuspendLayout();
            // 
            // BtnSaveAndClose
            // 
            BtnSaveAndClose.Enabled = false;
            BtnSaveAndClose.Location = new Point(646, 404);
            BtnSaveAndClose.Name = "BtnSaveAndClose";
            BtnSaveAndClose.Size = new Size(142, 34);
            BtnSaveAndClose.TabIndex = 15;
            BtnSaveAndClose.Text = "Save and Close";
            BtnSaveAndClose.UseVisualStyleBackColor = true;
            BtnSaveAndClose.Click += BtnSaveAndClose_Click;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(528, 404);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(112, 34);
            BtnClose.TabIndex = 14;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnSave
            // 
            BtnSave.Enabled = false;
            BtnSave.Location = new Point(410, 404);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 34);
            BtnSave.TabIndex = 13;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(649, 10);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(142, 34);
            BtnDelete.TabIndex = 26;
            BtnDelete.Text = "Delete Book";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // TxtAuthor
            // 
            TxtAuthor.Location = new Point(385, 60);
            TxtAuthor.Name = "TxtAuthor";
            TxtAuthor.Size = new Size(150, 31);
            TxtAuthor.TabIndex = 24;
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
            TxtPublisher.TabIndex = 22;
            TxtPublisher.TextChanged += ContentChanged;
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(77, 12);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(336, 31);
            TxtTitle.TabIndex = 21;
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
            // LblMandetoryInfos
            // 
            LblMandetoryInfos.Anchor = AnchorStyles.Top;
            LblMandetoryInfos.AutoSize = true;
            LblMandetoryInfos.Location = new Point(623, 376);
            LblMandetoryInfos.Name = "LblMandetoryInfos";
            LblMandetoryInfos.Size = new Size(165, 25);
            LblMandetoryInfos.TabIndex = 27;
            LblMandetoryInfos.Text = "* = mandetory info";
            // 
            // DisplayBookWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblMandetoryInfos);
            Controls.Add(BtnDelete);
            Controls.Add(TxtAuthor);
            Controls.Add(TxtId);
            Controls.Add(TxtPublisher);
            Controls.Add(TxtTitle);
            Controls.Add(LblAuthor);
            Controls.Add(LblPublisher);
            Controls.Add(LblId);
            Controls.Add(LblTitle);
            Controls.Add(BtnSaveAndClose);
            Controls.Add(BtnClose);
            Controls.Add(BtnSave);
            Name = "DisplayBookWindow";
            Text = "DisplayBooks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSaveAndClose;
        private Button BtnClose;
        private Button BtnSave;
        private Button BtnDelete;
        private TextBox TxtAuthor;
        private TextBox TxtId;
        private TextBox TxtPublisher;
        private TextBox TxtTitle;
        private Label LblAuthor;
        private Label LblPublisher;
        private Label LblId;
        private Label LblTitle;
        private Label LblMandetoryInfos;
    }
}