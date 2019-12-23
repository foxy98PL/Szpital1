using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PobytWSzpitalu : Pacjent
    {
        protected string sala;
        protected string oddział;
        protected string lekarz;
        protected string uczulenia;
        protected string leki;
        protected string chorobyprzewlekle;
        protected string choroba;

   

        public PobytWSzpitalu(string imie, string nazwisko, string wiek, string dataurodzenia, string email, string nrTelefonu, string pesel, string nrPolisy, string kraj, string miasto, string kodpocztowy, string nrDomu, string ulica, string sala, string oddział, string lekarz, string uczulenia, string leki, string chorobyprzewlekle, string choroba) :
            base(imie,nazwisko,wiek,dataurodzenia,email,nrTelefonu,pesel,nrPolisy,kraj,miasto,kodpocztowy,nrDomu,ulica)
        {
            this.sala = sala;
            this.oddział = oddział;
            this.lekarz = lekarz;
            this.uczulenia = uczulenia;
            this.leki = leki;
            this.chorobyprzewlekle = chorobyprzewlekle;
            this.choroba = choroba;
        }
    }
}
