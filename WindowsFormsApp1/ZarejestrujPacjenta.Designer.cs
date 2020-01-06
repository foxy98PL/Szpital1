namespace WindowsFormsApp1
{
    partial class ZarejestrujPacjenta
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
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.tbDName = new System.Windows.Forms.TextBox();
            this.tbDSN = new System.Windows.Forms.TextBox();
            this.tbExamination = new System.Windows.Forms.TextBox();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbRegister = new System.Windows.Forms.Button();
            this.tbBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.aa = new System.Windows.Forms.Label();
            this.aaaa = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(43, 54);
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.Size = new System.Drawing.Size(140, 20);
            this.tbPesel.TabIndex = 0;
            // 
            // tbDName
            // 
            this.tbDName.Location = new System.Drawing.Point(43, 110);
            this.tbDName.Name = "tbDName";
            this.tbDName.Size = new System.Drawing.Size(140, 20);
            this.tbDName.TabIndex = 1;
            // 
            // tbDSN
            // 
            this.tbDSN.Location = new System.Drawing.Point(43, 170);
            this.tbDSN.Name = "tbDSN";
            this.tbDSN.Size = new System.Drawing.Size(140, 20);
            this.tbDSN.TabIndex = 2;
            // 
            // tbExamination
            // 
            this.tbExamination.Location = new System.Drawing.Point(274, 54);
            this.tbExamination.Name = "tbExamination";
            this.tbExamination.Size = new System.Drawing.Size(146, 20);
            this.tbExamination.TabIndex = 3;
            // 
            // tbRef
            // 
            this.tbRef.Location = new System.Drawing.Point(274, 170);
            this.tbRef.Name = "tbRef";
            this.tbRef.Size = new System.Drawing.Size(140, 20);
            this.tbRef.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(274, 110);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(140, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // tbRegister
            // 
            this.tbRegister.Location = new System.Drawing.Point(274, 253);
            this.tbRegister.Name = "tbRegister";
            this.tbRegister.Size = new System.Drawing.Size(75, 23);
            this.tbRegister.TabIndex = 6;
            this.tbRegister.Text = "Zarejestruj";
            this.tbRegister.UseVisualStyleBackColor = true;
            this.tbRegister.Click += new System.EventHandler(this.TbRegister_Click);
            // 
            // tbBack
            // 
            this.tbBack.Location = new System.Drawing.Point(108, 253);
            this.tbBack.Name = "tbBack";
            this.tbBack.Size = new System.Drawing.Size(75, 23);
            this.tbBack.TabIndex = 7;
            this.tbBack.Text = "Cofnij";
            this.tbBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pesel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ImieLekarza";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(69, 154);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(91, 13);
            this.a.TabIndex = 10;
            this.a.Text = "NazwiskoLekarza";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(307, 38);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(79, 13);
            this.v.TabIndex = 11;
            this.v.Text = "RodzajBadania";
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Location = new System.Drawing.Point(326, 94);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(32, 13);
            this.aa.TabIndex = 12;
            this.aa.Text = "Cena";
            // 
            // aaaa
            // 
            this.aaaa.AutoSize = true;
            this.aaaa.Location = new System.Drawing.Point(295, 154);
            this.aaaa.Name = "aaaa";
            this.aaaa.Size = new System.Drawing.Size(91, 13);
            this.aaaa.TabIndex = 13;
            this.aaaa.Text = "CzyRefundowane";
            this.aaaa.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(160, 218);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(140, 20);
            this.tbMail.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "eMail";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ZarejestrujPacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 306);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.aaaa);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.v);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBack);
            this.Controls.Add(this.tbRegister);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbRef);
            this.Controls.Add(this.tbExamination);
            this.Controls.Add(this.tbDSN);
            this.Controls.Add(this.tbDName);
            this.Controls.Add(this.tbPesel);
            this.Name = "ZarejestrujPacjenta";
            this.Text = "ZarejestrujPacjenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.TextBox tbDName;
        private System.Windows.Forms.TextBox tbDSN;
        private System.Windows.Forms.TextBox tbExamination;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button tbRegister;
        private System.Windows.Forms.Button tbBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.Label aaaa;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label3;
    }
}