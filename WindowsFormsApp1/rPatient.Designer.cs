namespace WindowsFormsApp1
{
    partial class rPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPolicy = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbBdate = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bRegisterPatient = new System.Windows.Forms.Button();
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbHouse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(40, 55);
            this.tbName.MaxLength = 20;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(194, 20);
            this.tbName.TabIndex = 0;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbName_KeyPress);
            // 
            // tbPolicy
            // 
            this.tbPolicy.Location = new System.Drawing.Point(276, 128);
            this.tbPolicy.MaxLength = 20;
            this.tbPolicy.Name = "tbPolicy";
            this.tbPolicy.Size = new System.Drawing.Size(195, 20);
            this.tbPolicy.TabIndex = 1;
            this.tbPolicy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPolicy_KeyPress);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(276, 55);
            this.tbPhone.MaxLength = 15;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(195, 20);
            this.tbPhone.TabIndex = 2;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPhone_KeyPress);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(40, 321);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(194, 20);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbEmail_KeyPress);
            // 
            // tbBdate
            // 
            this.tbBdate.Location = new System.Drawing.Point(40, 262);
            this.tbBdate.MaxLength = 10;
            this.tbBdate.Name = "tbBdate";
            this.tbBdate.Size = new System.Drawing.Size(194, 20);
            this.tbBdate.TabIndex = 4;
            this.tbBdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbBdate_KeyPress);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(40, 197);
            this.tbAge.MaxLength = 3;
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(194, 20);
            this.tbAge.TabIndex = 5;
            this.tbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAge_KeyPress);
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(40, 128);
            this.tbSName.MaxLength = 20;
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(194, 20);
            this.tbSName.TabIndex = 6;
            this.tbSName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSName_KeyPress);
            // 
            // Imie
            // 
            this.Imie.AutoSize = true;
            this.Imie.Location = new System.Drawing.Point(119, 28);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(26, 13);
            this.Imie.TabIndex = 9;
            this.Imie.Text = "Imie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "NrPolisy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "DataUrodzenia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Wiek";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nazwisko";
            // 
            // bRegisterPatient
            // 
            this.bRegisterPatient.Location = new System.Drawing.Point(276, 251);
            this.bRegisterPatient.Name = "bRegisterPatient";
            this.bRegisterPatient.Size = new System.Drawing.Size(195, 90);
            this.bRegisterPatient.TabIndex = 18;
            this.bRegisterPatient.Text = "Zarejestruj";
            this.bRegisterPatient.UseVisualStyleBackColor = true;
            this.bRegisterPatient.Click += new System.EventHandler(this.BRegisterPatient_Click);
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(276, 197);
            this.tbPesel.MaxLength = 20;
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.Size = new System.Drawing.Size(195, 20);
            this.tbPesel.TabIndex = 19;
            this.tbPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPesel_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pesel";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(517, 55);
            this.tbCountry.MaxLength = 20;
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(195, 20);
            this.tbCountry.TabIndex = 21;
            this.tbCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCountry_KeyPress);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(517, 128);
            this.tbCity.MaxLength = 20;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(195, 20);
            this.tbCity.TabIndex = 22;
            this.tbCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCity_KeyPress);
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(517, 197);
            this.tbPostalCode.MaxLength = 20;
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(195, 20);
            this.tbPostalCode.TabIndex = 23;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(517, 262);
            this.tbStreet.MaxLength = 20;
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(195, 20);
            this.tbStreet.TabIndex = 24;
            this.tbStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbStreet_KeyPress);
            // 
            // tbHouse
            // 
            this.tbHouse.Location = new System.Drawing.Point(517, 321);
            this.tbHouse.MaxLength = 20;
            this.tbHouse.Name = "tbHouse";
            this.tbHouse.Size = new System.Drawing.Size(195, 20);
            this.tbHouse.TabIndex = 25;
            this.tbHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbHouse_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "NrDomu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(602, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(588, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "KodPocztowy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(602, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Miasto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(602, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Kraj";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(602, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Ulica";
            // 
            // rPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 386);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHouse);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbPostalCode);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesel);
            this.Controls.Add(this.bRegisterPatient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.tbSName);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbBdate);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbPolicy);
            this.Controls.Add(this.tbName);
            this.Name = "rPatient";
            this.Text = "RejestracjaPacjenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPolicy;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbBdate;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Label Imie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bRegisterPatient;
        private System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbHouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}