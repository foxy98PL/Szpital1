using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class PatientFrom : Form
    {
        public PatientFrom()
        {
            InitializeComponent();
        }

        private void RPatientRegister_Click(object sender, EventArgs e)
        {
            rPatient nowy = new rPatient();
            this.Hide();
            nowy.ShowDialog();
            this.Close();
        }

        private void DodajDobadania_Click(object sender, EventArgs e)
        {
            ZarejestrujPacjenta nowy = new ZarejestrujPacjenta();
            this.Hide();
            nowy.ShowDialog();
            this.Close();
        }

        private void TbPodlicz_Click(object sender, EventArgs e)
        {
            
        }
    }
}
