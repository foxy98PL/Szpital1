﻿namespace WindowsFormsApp1
{
    partial class Menu
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
            this.lWitaj = new System.Windows.Forms.Label();
            this.bPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lWitaj
            // 
            this.lWitaj.AutoSize = true;
            this.lWitaj.Location = new System.Drawing.Point(715, 428);
            this.lWitaj.Name = "lWitaj";
            this.lWitaj.Size = new System.Drawing.Size(35, 13);
            this.lWitaj.TabIndex = 0;
            this.lWitaj.Text = "label1";
            // 
            // bPatient
            // 
            this.bPatient.Location = new System.Drawing.Point(35, 47);
            this.bPatient.Name = "bPatient";
            this.bPatient.Size = new System.Drawing.Size(75, 23);
            this.bPatient.TabIndex = 1;
            this.bPatient.Text = "Pacjent";
            this.bPatient.UseVisualStyleBackColor = true;
            this.bPatient.Click += new System.EventHandler(this.BPatient_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bPatient);
            this.Controls.Add(this.lWitaj);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWitaj;
        private System.Windows.Forms.Button bPatient;
    }
}