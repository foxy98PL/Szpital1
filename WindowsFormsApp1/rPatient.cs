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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class rPatient : Form
    {
        public rPatient()
        {
            InitializeComponent();
       
           
        }

        private void BRegisterPatient_Click(object sender, EventArgs e)
        {
            Pacjent nowy = new Pacjent(tbName.Text, tbSName.Text, tbAge.Text, tbBdate.Text, tbEmail.Text, tbPhone.Text, tbPesel.Text, tbPolicy.Text, tbCountry.Text, tbCity.Text, tbPostalCode.Text, tbStreet.Text, tbHouse.Text);

            StreamWriter sw = new StreamWriter("Pacjent.txt");
            sw.Write("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|",nowy.Imie,nowy.Nazwisko,nowy.Wiek,nowy.Dataurodzenia,nowy.Email,nowy.NrTelefonu,nowy.Pesel,nowy.NrPolisy,nowy.Kraj,nowy.Miasto,nowy.Kodpocztowy,nowy.Ulica,nowy.NrDomu,DateTime.Now);
            sw.Flush();
            sw.Close();
            //wpisywanie do bazy danych
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VOF8MVF;Initial Catalog=Pacjent;database=Szpital;Integrated Security=True"); //Ustawianie scieżki połączenia

            SqlCommand cmd = new SqlCommand("INSERT INTO Pacjent" + "(Imie,Nazwisko,Wiek,DataUrodzenia,Email,Telefon,Pesel,NrPolisy,Kraj,Miasto,KodPocztowy,NrDomu,Ulica,Data)" + "Values(@Imie,@Nazwisko,@Wiek,@DataUrodzenia,@Email,@Telefon,@Pesel,@NrPolisy,@Kraj,@Miasto,@KodPocztowy,@NrDomu,@Ulica,@Data)", con); //Rządzanie SQL

            
         
            cmd.Parameters.Add("@Imie", System.Data.SqlDbType.VarChar);  //Ustawianie pustego pola
            cmd.Parameters.Add("@Nazwisko", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Wiek", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@DataUrodzenia", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Email", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Telefon", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Pesel", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@NrPolisy", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Kraj", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Miasto", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@KodPocztowy", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Ulica", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@NrDomu", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Data", System.Data.SqlDbType.VarChar);



            cmd.Parameters["@Imie"].Value = Convert.ToString(nowy.Imie);
            cmd.Parameters["@Nazwisko"].Value = Convert.ToString(nowy.Nazwisko);
            cmd.Parameters["@Wiek"].Value = Convert.ToString(nowy.Wiek);
            cmd.Parameters["@DataUrodzenia"].Value = Convert.ToString(nowy.Dataurodzenia);
            cmd.Parameters["@Email"].Value = Convert.ToString(nowy.Email);
            cmd.Parameters["@Telefon"].Value = Convert.ToString(nowy.NrTelefonu);
            cmd.Parameters["@Pesel"].Value = Convert.ToString(nowy.Pesel);
            cmd.Parameters["@NrPolisy"].Value = Convert.ToString(nowy.NrPolisy);
            cmd.Parameters["@Kraj"].Value = Convert.ToString(nowy.Kraj);
            cmd.Parameters["@Miasto"].Value = Convert.ToString(nowy.Miasto);
            cmd.Parameters["@KodPocztowy"].Value = Convert.ToString(nowy.Kodpocztowy);
            cmd.Parameters["@Ulica"].Value = Convert.ToString(nowy.Ulica);
            cmd.Parameters["@NrDomu"].Value = Convert.ToString(nowy.NrDomu);
            cmd.Parameters["@Data"].Value = Convert.ToString(DateTime.Now);
            con.Open();
            int RowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
         
        }
        #region Ustawiania możliwości wpisywania
        private void TbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbSName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbBdate_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

        private void TbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbPolicy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        

        private void TbCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbStreet_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TbHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       #endregion
    }
}
