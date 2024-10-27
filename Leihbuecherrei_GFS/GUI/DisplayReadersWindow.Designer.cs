namespace Leihbuecherrei_GFS.GUI
{
    partial class DisplayReadersWindow
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
            BtnSave = new Button();
            BtnClose = new Button();
            BtnSaveAndClose = new Button();
            BtnDelete = new Button();
            LblMandetoryInfos = new Label();
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
            // BtnSave
            // 
            BtnSave.Enabled = false;
            BtnSave.Location = new Point(410, 404);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 34);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(528, 404);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(112, 34);
            BtnClose.TabIndex = 11;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnSaveAndClose
            // 
            BtnSaveAndClose.Enabled = false;
            BtnSaveAndClose.Location = new Point(646, 404);
            BtnSaveAndClose.Name = "BtnSaveAndClose";
            BtnSaveAndClose.Size = new Size(142, 34);
            BtnSaveAndClose.TabIndex = 12;
            BtnSaveAndClose.Text = "Save and Close";
            BtnSaveAndClose.UseVisualStyleBackColor = true;
            BtnSaveAndClose.Click += BtnSaveAndClose_Click;
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
            // DisplayReadersWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblMandetoryInfos);
            Controls.Add(BtnDelete);
            Controls.Add(BtnSaveAndClose);
            Controls.Add(BtnClose);
            Controls.Add(BtnSave);
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
        private Button BtnSave;
        private Button BtnClose;
        private Button BtnSaveAndClose;
        private Button BtnDelete;
        private Label LblMandetoryInfos;
    }
}