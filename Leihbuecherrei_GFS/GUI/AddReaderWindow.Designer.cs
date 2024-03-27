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
            LblAdress = new Label();
            LblCity = new Label();
            label1 = new Label();
            TxtCity = new TextBox();
            TxtAdress = new TextBox();
            TxtName = new TextBox();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // DtpBirthday
            // 
            DtpBirthday.Format = DateTimePickerFormat.Short;
            DtpBirthday.Location = new Point(117, 184);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(148, 31);
            DtpBirthday.TabIndex = 0;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(39, 59);
            LblName.Name = "LblName";
            LblName.Size = new Size(63, 25);
            LblName.TabIndex = 1;
            LblName.Text = "Name:";
            // 
            // LblAdress
            // 
            LblAdress.AutoSize = true;
            LblAdress.Location = new Point(32, 103);
            LblAdress.Name = "LblAdress";
            LblAdress.Size = new Size(70, 25);
            LblAdress.TabIndex = 2;
            LblAdress.Text = "Adress:";
            // 
            // LblCity
            // 
            LblCity.AutoSize = true;
            LblCity.Location = new Point(56, 146);
            LblCity.Name = "LblCity";
            LblCity.Size = new Size(46, 25);
            LblCity.TabIndex = 3;
            LblCity.Text = "City:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 184);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 4;
            label1.Text = "Birthday:";
            // 
            // TxtCity
            // 
            TxtCity.Location = new Point(117, 146);
            TxtCity.Name = "TxtCity";
            TxtCity.Size = new Size(148, 31);
            TxtCity.TabIndex = 5;
            // 
            // TxtAdress
            // 
            TxtAdress.Location = new Point(117, 103);
            TxtAdress.Name = "TxtAdress";
            TxtAdress.Size = new Size(148, 31);
            TxtAdress.TabIndex = 6;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(117, 59);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(148, 31);
            TxtName.TabIndex = 7;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(97, 226);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 34);
            BtnSave.TabIndex = 8;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // AddReaderWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 272);
            Controls.Add(BtnSave);
            Controls.Add(TxtName);
            Controls.Add(TxtAdress);
            Controls.Add(TxtCity);
            Controls.Add(label1);
            Controls.Add(LblCity);
            Controls.Add(LblAdress);
            Controls.Add(LblName);
            Controls.Add(DtpBirthday);
            Name = "AddReaderWindow";
            Text = "Add reader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtpBirthday;
        private Label LblName;
        private Label LblAdress;
        private Label LblCity;
        private Label label1;
        private TextBox TxtCity;
        private TextBox TxtAdress;
        private TextBox TxtName;
        private Button BtnSave;
    }
}