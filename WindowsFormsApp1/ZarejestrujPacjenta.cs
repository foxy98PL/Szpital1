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
using System.Net.Mail;
using System.Net;
namespace WindowsFormsApp1
{
    public partial class ZarejestrujPacjenta : Form
    {
        public ZarejestrujPacjenta()
        {
            InitializeComponent();
        }

        private void TbRegister_Click(object sender, EventArgs e)
        {
            DoctorPatient nowy = new DoctorPatient(tbPesel.Text, tbDName.Text
                , tbDSN.Text, tbExamination.Text, tbPrice.Text, tbRef.Text, tbMail.Text);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VOF8MVF;Initial Catalog=RejestracjaLekarz;database=Szpital;Integrated Security=True"); //Ustawianie scieżki połączenia
            SqlCommand cmd = new SqlCommand("INSERT INTO RejestracjaLekarz" +
                "(Pesel,LekarzImie,LekarzNazwisko,Rodzajbadania,Cena,CzyRefundowane,Email)"
                + "VALUES(@Pesel,@LekarzImie,@LekarzNazwisko,@Rodzajbadania,@Cena,@CzyRefundowane,@Email)", con);

            cmd.Parameters.Add("@Pesel", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@LekarzImie", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@LekarzNazwisko", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@RodzajBadania", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Cena", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@CzyRefundowane", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Email", System.Data.SqlDbType.VarChar);

            cmd.Parameters["@Pesel"].Value = Convert.ToString(nowy.pesel);
            cmd.Parameters["@LekarzImie"].Value = Convert.ToString(nowy.docName);
            cmd.Parameters["@LekarzNazwisko"].Value = Convert.ToString(nowy.docSName);
            cmd.Parameters["@RodzajBadania"].Value = Convert.ToString(nowy.medEx);
            cmd.Parameters["@Cena"].Value = Convert.ToString(nowy.price);
            cmd.Parameters["@CzyRefundowane"].Value = Convert.ToString(nowy.refun);
            cmd.Parameters["@Email"].Value = Convert.ToString(nowy.email);
            con.Open();
            int RowsAffected = cmd.ExecuteNonQuery();
            con.Close();


            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); //stmp serwera
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("login", "haslo");  //moj login haslo do poczty
                SmtpServer.EnableSsl = true;

                mail.From = new MailAddress("mail");  //mail z mojej poczty
                mail.To.Add(nowy.email.ToString());
                mail.Subject = "Rejestracja Pacjenta" + nowy.pesel.ToString(); ;
                mail.Body = "Zarejestrowano do dr. " + nowy.docName.ToString() + nowy.docSName.ToString() + " na badanie" + nowy.medEx.ToString()
                    + "koszt" + nowy.price.ToString() + "dla pacjenta o peselu" + nowy.pesel.ToString() + " W razie błędnej wiadomości proszę usunąc maila";



                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();


        }
    }
}