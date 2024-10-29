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
            LblMandetoryInfos = new Label();
            CbAvailable = new CheckBox();
            GbReservationList = new GroupBox();
            BtnDeleteFromReservationList = new Button();
            LbReservations = new ListBox();
            BtnAddToReservationList = new Button();
            GbReservationList.SuspendLayout();
            SuspendLayout();
            // 
            // BtnOk
            // 
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(440, 404);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(112, 34);
            BtnOk.TabIndex = 15;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(558, 404);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 34);
            BtnCancel.TabIndex = 14;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnApply
            // 
            BtnApply.Enabled = false;
            BtnApply.Location = new Point(676, 404);
            BtnApply.Name = "BtnApply";
            BtnApply.Size = new Size(112, 34);
            BtnApply.TabIndex = 13;
            BtnApply.Text = "Apply";
            BtnApply.UseVisualStyleBackColor = true;
            BtnApply.Click += BtnApply_Click;
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
            TxtAuthor.Location = new Point(385, 57);
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
            // CbAvailable
            // 
            CbAvailable.AutoSize = true;
            CbAvailable.CheckAlign = ContentAlignment.MiddleRight;
            CbAvailable.Location = new Point(592, 59);
            CbAvailable.Name = "CbAvailable";
            CbAvailable.Size = new Size(113, 29);
            CbAvailable.TabIndex = 28;
            CbAvailable.Text = "Available:";
            CbAvailable.UseVisualStyleBackColor = true;
            // 
            // GbReservationList
            // 
            GbReservationList.Controls.Add(BtnDeleteFromReservationList);
            GbReservationList.Controls.Add(LbReservations);
            GbReservationList.Controls.Add(BtnAddToReservationList);
            GbReservationList.Location = new Point(15, 109);
            GbReservationList.Name = "GbReservationList";
            GbReservationList.Size = new Size(209, 329);
            GbReservationList.TabIndex = 29;
            GbReservationList.TabStop = false;
            GbReservationList.Text = "Waiting List";
            // 
            // BtnDeleteFromReservationList
            // 
            BtnDeleteFromReservationList.Dock = DockStyle.Top;
            BtnDeleteFromReservationList.Location = new Point(3, 290);
            BtnDeleteFromReservationList.Name = "BtnDeleteFromReservationList";
            BtnDeleteFromReservationList.Size = new Size(203, 34);
            BtnDeleteFromReservationList.TabIndex = 1;
            BtnDeleteFromReservationList.Text = "Remove from waiting list";
            BtnDeleteFromReservationList.UseVisualStyleBackColor = true;
            // 
            // LbReservations
            // 
            LbReservations.Dock = DockStyle.Top;
            LbReservations.FormattingEnabled = true;
            LbReservations.ItemHeight = 25;
            LbReservations.Location = new Point(3, 61);
            LbReservations.Name = "LbReservations";
            LbReservations.Size = new Size(203, 229);
            LbReservations.TabIndex = 2;
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
            // 
            // DisplayBookWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GbReservationList);
            Controls.Add(CbAvailable);
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
            Controls.Add(BtnOk);
            Controls.Add(BtnCancel);
            Controls.Add(BtnApply);
            MaximizeBox = false;
            MaximumSize = new Size(822, 506);
            MinimizeBox = false;
            MinimumSize = new Size(822, 506);
            Name = "DisplayBookWindow";
            Text = "DisplayBooks";
            GbReservationList.ResumeLayout(false);
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
        private Label LblMandetoryInfos;
        private CheckBox CbAvailable;
        private GroupBox GbReservationList;
        private Button BtnDeleteFromReservationList;
        private ListBox LbReservations;
        private Button BtnAddToReservationList;
    }
}