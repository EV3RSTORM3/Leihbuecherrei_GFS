namespace Leihbuecherrei_GFS.GUI
{
    partial class AddBookWindow
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
            TxtTitle = new TextBox();
            TxtAuthor = new TextBox();
            TxtPublisher = new TextBox();
            LblAuthor = new Label();
            LblPublisher = new Label();
            LblTitle = new Label();
            LblMandatoryInfos = new Label();
            BtnOk = new Button();
            SuspendLayout();
            // 
            // TxtTitle
            // 
            TxtTitle.Anchor = AnchorStyles.Top;
            TxtTitle.Location = new Point(110, 20);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(148, 31);
            TxtTitle.TabIndex = 1;
            // 
            // TxtAuthor
            // 
            TxtAuthor.Anchor = AnchorStyles.Top;
            TxtAuthor.Location = new Point(110, 64);
            TxtAuthor.Name = "TxtAuthor";
            TxtAuthor.Size = new Size(148, 31);
            TxtAuthor.TabIndex = 2;
            // 
            // TxtPublisher
            // 
            TxtPublisher.Anchor = AnchorStyles.Top;
            TxtPublisher.Location = new Point(110, 107);
            TxtPublisher.Name = "TxtPublisher";
            TxtPublisher.Size = new Size(148, 31);
            TxtPublisher.TabIndex = 3;
            // 
            // LblAuthor
            // 
            LblAuthor.Anchor = AnchorStyles.Top;
            LblAuthor.AutoSize = true;
            LblAuthor.Location = new Point(37, 64);
            LblAuthor.Name = "LblAuthor";
            LblAuthor.Size = new Size(71, 25);
            LblAuthor.TabIndex = 10;
            LblAuthor.Text = "Author:";
            // 
            // LblPublisher
            // 
            LblPublisher.Anchor = AnchorStyles.Top;
            LblPublisher.AutoSize = true;
            LblPublisher.Location = new Point(16, 110);
            LblPublisher.Name = "LblPublisher";
            LblPublisher.Size = new Size(88, 25);
            LblPublisher.TabIndex = 9;
            LblPublisher.Text = "Publisher:";
            // 
            // LblTitle
            // 
            LblTitle.Anchor = AnchorStyles.Top;
            LblTitle.AutoSize = true;
            LblTitle.Location = new Point(48, 23);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(56, 25);
            LblTitle.TabIndex = 8;
            LblTitle.Text = "*Title:";
            // 
            // LblMandatoryInfos
            // 
            LblMandatoryInfos.Anchor = AnchorStyles.Top;
            LblMandatoryInfos.AutoSize = true;
            LblMandatoryInfos.Location = new Point(48, 141);
            LblMandatoryInfos.Name = "LblMandatoryInfos";
            LblMandatoryInfos.Size = new Size(165, 25);
            LblMandatoryInfos.TabIndex = 14;
            LblMandatoryInfos.Text = "* = mandatory info";
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Bottom;
            BtnOk.Location = new Point(76, 188);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(112, 34);
            BtnOk.TabIndex = 4;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // AddBookWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 234);
            Controls.Add(BtnOk);
            Controls.Add(LblMandatoryInfos);
            Controls.Add(TxtTitle);
            Controls.Add(TxtAuthor);
            Controls.Add(TxtPublisher);
            Controls.Add(LblAuthor);
            Controls.Add(LblPublisher);
            Controls.Add(LblTitle);
            MaximizeBox = false;
            MaximumSize = new Size(293, 290);
            MinimizeBox = false;
            MinimumSize = new Size(293, 290);
            Name = "AddBookWindow";
            Text = "Add book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtTitle;
        private TextBox TxtAuthor;
        private TextBox TxtPublisher;
        private Label LblAuthor;
        private Label LblPublisher;
        private Label LblTitle;
        private Label LblMandatoryInfos;
        private Button BtnOk;
    }
}