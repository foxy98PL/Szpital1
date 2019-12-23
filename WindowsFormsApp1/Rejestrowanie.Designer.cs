namespace WindowsFormsApp1
{
    partial class Rejestrowanie
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
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.bRejestruj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassRepat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(30, 154);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(156, 20);
            this.tbPass.TabIndex = 1;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(30, 86);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(156, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // bRejestruj
            // 
            this.bRejestruj.Location = new System.Drawing.Point(30, 266);
            this.bRejestruj.Name = "bRejestruj";
            this.bRejestruj.Size = new System.Drawing.Size(156, 53);
            this.bRejestruj.TabIndex = 3;
            this.bRejestruj.Text = "Zarejestruj";
            this.bRejestruj.UseVisualStyleBackColor = true;
            this.bRejestruj.Click += new System.EventHandler(this.BRejestruj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Podaj Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Podaj Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PowtórzHasło";
            // 
            // tbPassRepat
            // 
            this.tbPassRepat.Location = new System.Drawing.Point(30, 213);
            this.tbPassRepat.Name = "tbPassRepat";
            this.tbPassRepat.Size = new System.Drawing.Size(156, 20);
            this.tbPassRepat.TabIndex = 7;
            // 
            // Rejestrowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 352);
            this.Controls.Add(this.tbPassRepat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRejestruj);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbPass);
            this.Name = "Rejestrowanie";
            this.Text = "Rejestrowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button bRejestruj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassRepat;
    }
}