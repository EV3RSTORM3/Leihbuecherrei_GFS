namespace Leihbuecherrei_GFS.GUI
{
    partial class AddReaderWindow
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
            DtpBirthday = new DateTimePicker();
            LblName = new Label();
            LblAddress = new Label();
            LblCity = new Label();
            LblBirthday = new Label();
            TxtCity = new TextBox();
            TxtAddress = new TextBox();
            TxtName = new TextBox();
            BtnOk = new Button();
            LblMandatoryInfos = new Label();
            SuspendLayout();
            // 
            // DtpBirthday
            // 
            DtpBirthday.Anchor = AnchorStyles.Top;
            DtpBirthday.Format = DateTimePickerFormat.Short;
            DtpBirthday.Location = new Point(96, 145);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(148, 31);
            DtpBirthday.TabIndex = 3;
            DtpBirthday.Enter += DtpBirthday_Enter;
            DtpBirthday.Leave += DtpBirthday_Leave;
            // 
            // LblName
            // 
            LblName.Anchor = AnchorStyles.Top;
            LblName.AutoSize = true;
            LblName.Location = new Point(19, 23);
            LblName.Name = "LblName";
            LblName.Size = new Size(71, 25);
            LblName.TabIndex = 1;
            LblName.Text = "*Name:";
            // 
            // LblAddress
            // 
            LblAddress.Anchor = AnchorStyles.Top;
            LblAddress.AutoSize = true;
            LblAddress.Location = new Point(12, 67);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(89, 25);
            LblAddress.TabIndex = 2;
            LblAddress.Text = "*Address:";
            // 
            // LblCity
            // 
            LblCity.Anchor = AnchorStyles.Top;
            LblCity.AutoSize = true;
            LblCity.Location = new Point(36, 110);
            LblCity.Name = "LblCity";
            LblCity.Size = new Size(54, 25);
            LblCity.TabIndex = 3;
            LblCity.Text = "*City:";
            // 
            // LblBirthday
            // 
            LblBirthday.Anchor = AnchorStyles.Top;
            LblBirthday.AutoSize = true;
            LblBirthday.Location = new Point(9, 150);
            LblBirthday.Name = "LblBirthday";
            LblBirthday.Size = new Size(81, 25);
            LblBirthday.TabIndex = 4;
            LblBirthday.Text = "Birthday:";
            // 
            // TxtCity
            // 
            TxtCity.Anchor = AnchorStyles.Top;
            TxtCity.Location = new Point(96, 107);
            TxtCity.Name = "TxtCity";
            TxtCity.Size = new Size(148, 31);
            TxtCity.TabIndex = 2;
            // 
            // TxtAddress
            // 
            TxtAddress.Anchor = AnchorStyles.Top;
            TxtAddress.Location = new Point(96, 64);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(148, 31);
            TxtAddress.TabIndex = 1;
            // 
            // TxtName
            // 
            TxtName.Anchor = AnchorStyles.Top;
            TxtName.Location = new Point(96, 20);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(148, 31);
            TxtName.TabIndex = 0;
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Top;
            BtnOk.Location = new Point(76, 226);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(112, 34);
            BtnOk.TabIndex = 4;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // LblMandatoryInfos
            // 
            LblMandatoryInfos.Anchor = AnchorStyles.Top;
            LblMandatoryInfos.AutoSize = true;
            LblMandatoryInfos.Location = new Point(50, 179);
            LblMandatoryInfos.Name = "LblMandatoryInfos";
            LblMandatoryInfos.Size = new Size(165, 25);
            LblMandatoryInfos.TabIndex = 9;
            LblMandatoryInfos.Text = "* = mandatory info";
            // 
            // AddReaderWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 272);
            Controls.Add(LblMandatoryInfos);
            Controls.Add(BtnOk);
            Controls.Add(TxtName);
            Controls.Add(TxtAddress);
            Controls.Add(TxtCity);
            Controls.Add(LblBirthday);
            Controls.Add(LblCity);
            Controls.Add(LblAddress);
            Controls.Add(LblName);
            Controls.Add(DtpBirthday);
            MaximizeBox = false;
            MaximumSize = new Size(288, 328);
            MinimizeBox = false;
            MinimumSize = new Size(288, 328);
            Name = "AddReaderWindow";
            Text = "Add reader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtpBirthday;
        private Label LblName;
        private Label LblAddress;
        private Label LblCity;
        private Label LblBirthday;
        private TextBox TxtCity;
        private TextBox TxtAddress;
        private TextBox TxtName;
        private Button BtnOk;
        private Label LblMandatoryInfos;
    }
}