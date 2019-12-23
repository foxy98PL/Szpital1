using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            lWitaj.Text = "Witaj " + Zaloguj.Login;
           
        }

        private void BPatient_Click(object sender, EventArgs e)
        {
            PatientFrom patient = new PatientFrom();
            this.Hide();
            patient.ShowDialog();
            this.Close();

        }
    }
}
