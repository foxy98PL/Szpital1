namespace WindowsFormsApp1
{
    partial class Zaloguj
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bLogin = new System.Windows.Forms.Button();
            this.tLogin = new System.Windows.Forms.TextBox();
            this.tHaslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(22, 188);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(159, 36);
            this.bLogin.TabIndex = 0;
            this.bLogin.Text = "Zaloguj";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // tLogin
            // 
            this.tLogin.Location = new System.Drawing.Point(22, 63);
            this.tLogin.Name = "tLogin";
            this.tLogin.Size = new System.Drawing.Size(159, 20);
            this.tLogin.TabIndex = 1;
            // 
            // tHaslo
            // 
            this.tHaslo.Location = new System.Drawing.Point(22, 138);
            this.tHaslo.Name = "tHaslo";
            this.tHaslo.Size = new System.Drawing.Size(159, 20);
            this.tHaslo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Haslo";
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(22, 245);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(159, 40);
            this.bRegister.TabIndex = 5;
            this.bRegister.Text = "Zarejestruj";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.Zarejestruj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 297);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tHaslo);
            this.Controls.Add(this.tLogin);
            this.Controls.Add(this.bLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tLogin;
        private System.Windows.Forms.TextBox tHaslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bRegister;
    }
}

