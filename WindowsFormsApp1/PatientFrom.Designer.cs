namespace WindowsFormsApp1
{
    partial class PatientFrom
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
            this.rPatientRegister = new System.Windows.Forms.Button();
            this.DodajDobadania = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rPatientRegister
            // 
            this.rPatientRegister.Location = new System.Drawing.Point(12, 37);
            this.rPatientRegister.Name = "rPatientRegister";
            this.rPatientRegister.Size = new System.Drawing.Size(237, 79);
            this.rPatientRegister.TabIndex = 0;
            this.rPatientRegister.Text = "Zarejestruj Pacjenta";
            this.rPatientRegister.UseVisualStyleBackColor = true;
            this.rPatientRegister.Click += new System.EventHandler(this.RPatientRegister_Click);
            // 
            // DodajDobadania
            // 
            this.DodajDobadania.Location = new System.Drawing.Point(12, 173);
            this.DodajDobadania.Name = "DodajDobadania";
            this.DodajDobadania.Size = new System.Drawing.Size(237, 79);
            this.DodajDobadania.TabIndex = 1;
            this.DodajDobadania.Text = "DodajLeczenie";
            this.DodajDobadania.UseVisualStyleBackColor = true;
            this.DodajDobadania.Click += new System.EventHandler(this.DodajDobadania_Click);
            // 
            // PatientFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DodajDobadania);
            this.Controls.Add(this.rPatientRegister);
            this.Name = "PatientFrom";
            this.Text = "PatientFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rPatientRegister;
        private System.Windows.Forms.Button DodajDobadania;
    }
}