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
    public partial class Zaloguj : Form
    {

        public static string Login;
        public Zaloguj()
        {   
            InitializeComponent();

          

        }


        private void BLogin_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VOF8MVF;Initial Catalog=Logowanie;database=Szpital;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Logowanie WHERE Login='" + tLogin.Text + "' AND Haslo='" + tHaslo.Text + "'", con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);

            Login = tLogin.Text;



            if (dt.Rows[0][0].ToString() == "1")
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Zły Login lub Hasło");

        }

      

        private void Zarejestruj_Click(object sender, EventArgs e)
        {
            Rejestrowanie rejestracja = new Rejestrowanie();
            this.Hide();
            rejestracja.ShowDialog();
            this.Close();

        }
    }
}
