using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class PacjentWydatki
    {

        public string pesel;
        public string badanie;
        public int cena;
        


        public PacjentWydatki(string pesel, string badanie,int cena)
        {
            this.pesel = pesel;
            this.badanie = badanie;
            this.cena = cena;
        }

     
        

    }
}
