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
            BtnDeleteFromReservationList = new Button();
            LbReservations = new ListBox();
            BtnAddToReservationList = new Button();
            GbReservationList.SuspendLayout();
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
            TxtName.Size = new Size(150, 31);
            TxtName.TabIndex = 5;
            TxtName.TextChanged += ContentChanged;
            // 
            // TxtCity
            // 
            TxtCity.Location = new Point(72, 57);
            TxtCity.Name = "TxtCity";
            TxtCity.Size = new Size(150, 31);
            TxtCity.TabIndex = 6;
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
            TxtAdress.TabIndex = 8;
            TxtAdress.TextChanged += ContentChanged;
            // 
            // DtpBirthday
            // 
            DtpBirthday.Format = DateTimePickerFormat.Short;
            DtpBirthday.Location = new Point(559, 60);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(148, 31);
            DtpBirthday.TabIndex = 9;
            DtpBirthday.ValueChanged += ContentChanged;
            DtpBirthday.Enter += DtpBirthday_Enter;
            DtpBirthday.Leave += DtpBirthday_Leave;
            // 
            // BtnApply
            // 
            BtnApply.Enabled = false;
            BtnApply.Location = new Point(676, 404);
            BtnApply.Name = "BtnApply";
            BtnApply.Size = new Size(112, 34);
            BtnApply.TabIndex = 10;
            BtnApply.Text = "Apply";
            BtnApply.UseVisualStyleBackColor = true;
            BtnApply.Click += BtnApply_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(558, 404);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 34);
            BtnCancel.TabIndex = 11;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnOk
            // 
            BtnOk.Enabled = false;
            BtnOk.Location = new Point(440, 404);
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
            BtnDelete.Text = "Delete Reader";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // LblMandetoryInfos
            // 
            LblMandetoryInfos.Anchor = AnchorStyles.Top;
            LblMandetoryInfos.AutoSize = true;
            LblMandetoryInfos.Location = new Point(623, 367);
            LblMandetoryInfos.Name = "LblMandetoryInfos";
            LblMandetoryInfos.Size = new Size(165, 25);
            LblMandetoryInfos.TabIndex = 15;
            LblMandetoryInfos.Text = "* = mandetory info";
            // 
            // GbReservationList
            // 
            GbReservationList.Controls.Add(BtnDeleteFromReservationList);
            GbReservationList.Controls.Add(LbReservations);
            GbReservationList.Controls.Add(BtnAddToReservationList);
            GbReservationList.Location = new Point(12, 109);
            GbReservationList.Name = "GbReservationList";
            GbReservationList.Size = new Size(209, 329);
            GbReservationList.TabIndex = 30;
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
            // DisplayReadersWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "DisplayReadersWindow";
            Text = "DisplayReaders";
            GbReservationList.ResumeLayout(false);
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
    }
}