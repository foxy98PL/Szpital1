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
    public partial class Rejestrowanie : Form
    {
     
        
        public Rejestrowanie()
        {
            InitializeComponent();
        }

        private void BRejestruj_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VOF8MVF;Initial Catalog=Logowanie;database=Szpital;Integrated Security=True"); //Ustawianie scieżki połączenia
            
            SqlCommand command = new SqlCommand("INSERT INTO Logowanie" +"(Login,Haslo)"+"Values(@Login,@Haslo)",con); //Rządzanie SQL

            string haslo = tbPass.Text.ToString();  //Haslo do string z texbox
            string powHaslo = tbPassRepat.Text.ToString();  //Haslo do string z texbox
            command.Parameters.Add("@Login", System.Data.SqlDbType.VarChar);  //Ustawianie pustego pola
            command.Parameters.Add("@Haslo", System.Data.SqlDbType.VarChar); //Ustawianie pustego pola
           

            if (haslo == powHaslo)
            {
                command.Parameters["@Login"].Value = Convert.ToString(tbLogin.Text);   //Nadawanie wartosci
                command.Parameters["@Haslo"].Value = Convert.ToString(tbPass.Text);
                con.Open();
                int RowsAffected = command.ExecuteNonQuery();
                con.Close();

                Zaloguj logowanie = new Zaloguj();
                this.Hide();
                logowanie.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hasla sie nie zgadzają");
            }
        



        }
    }
}
