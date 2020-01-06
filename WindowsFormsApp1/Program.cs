using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Zaloguj login = new Zaloguj();
            
            Application.Run(login);


            string linia;
            StreamReader sr = new StreamReader("Pacjent.txt");
        
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VOF8MVF;Initial Catalog=Pacjent;database=Szpital;Integrated Security=True"); //Ustawianie scieżki połączenia
            SqlCommand cmd = new SqlCommand("Select * FROM Pacjent WHERE NOT Imie = @Imie OR NOT Nazwisko = @Nazwisko OR NOT Wiek = @Wiek OR NOT DataUrodzenia = @DataUrodzenia OR NOT Email=@Email OR NOT Telefon=@Telefon OR" +
                " NOT Pesel = @Pesel OR NOT NrPolisy = @NrPolisy OR NOT Kraj = @Kraj OR NOT Miasto = @Miasto OR NOT KodPocztowy = @KodPocztowy OR NOT NrDomu = @NrDomu OR" +
                " NOT Ulica = @Ulica OR NOT Data = @Data" +
                " Insert INTO Pacjent(Imie,Nazwisko,Wiek,DataUrodzenia,Email,Telefon,Pesel,NrPolisy,Kraj,Miasto,KodPocztowy,NrDomu,Ulica,Data)" +
                "Values(@Imie,@Nazwisko,@Wiek,@DataUrodzenia,@Email,@Telefon,@Pesel,@NrPolisy,@Kraj,@Miasto,@KodPocztowy,@NrDomu,@Ulica,@Data)", con); //Rządzanie SQL



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
            while ((linia = sr.ReadLine()) != null)
            {
          

                string[] tablica = linia.Split('|');


                cmd.Parameters["@Imie"].Value = Convert.ToString(tablica[0]);
                cmd.Parameters["@Nazwisko"].Value = Convert.ToString(tablica[1]);
                cmd.Parameters["@Wiek"].Value = Convert.ToString(tablica[2]);
                cmd.Parameters["@DataUrodzenia"].Value = Convert.ToString(tablica[3]);
                cmd.Parameters["@Email"].Value = Convert.ToString(tablica[4]);
                cmd.Parameters["@Telefon"].Value = Convert.ToString(tablica[5]);
                cmd.Parameters["@Pesel"].Value = Convert.ToString(tablica[6]);
                cmd.Parameters["@NrPolisy"].Value = Convert.ToString(tablica[7]);
                cmd.Parameters["@Kraj"].Value = Convert.ToString(tablica[8]);
                cmd.Parameters["@Miasto"].Value = Convert.ToString(tablica[9]);
                cmd.Parameters["@KodPocztowy"].Value = Convert.ToString(tablica[10]);
                cmd.Parameters["@Ulica"].Value = Convert.ToString(tablica[11]);
                cmd.Parameters["@NrDomu"].Value = Convert.ToString(tablica[12]);
                cmd.Parameters["@Data"].Value = Convert.ToString(tablica[13]);


                con.Open();
                 int RowsAffected = cmd.ExecuteNonQuery();
                    con.Close();


                

            }


        }
    }
}
