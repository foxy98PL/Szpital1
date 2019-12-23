using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pacjent
    {   
        protected string imie;
        protected string nazwisko;
        protected string wiek;
        protected string dataurodzenia;
        protected string email;
        protected string nrTelefonu;
        protected string pesel;
        protected string nrPolisy;
        protected string kraj;

        protected string miasto;
        protected string kodpocztowy;
        protected string nrDomu;
        protected string ulica;

        public Pacjent(string imie, string nazwisko, string wiek, string dataurodzenia, string email, string nrTelefonu, string pesel, string nrPolisy, string kraj, string miasto, string kodpocztowy, string nrDomu, string ulica)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.dataurodzenia = dataurodzenia;
            this.email = email;
            this.nrTelefonu = nrTelefonu;
            this.pesel = pesel;
            this.nrPolisy = nrPolisy;
            this.kraj = kraj;
            this.miasto = miasto;
            this.kodpocztowy = kodpocztowy;
            this.nrDomu = nrDomu;
            this.ulica = ulica;
        }

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Wiek { get => wiek; set => wiek = value; }
        public string Dataurodzenia { get => dataurodzenia; set => dataurodzenia = value; }
        public string Email { get => email; set => email = value; }
        public string NrTelefonu { get => nrTelefonu; set => nrTelefonu = value; }
        public string Pesel { get => pesel; set => pesel = value; }
        public string NrPolisy { get => nrPolisy; set => nrPolisy = value; }
        public string Kraj { get => kraj; set => kraj = value; }
        public string Miasto { get => miasto; set => miasto = value; }
        public string Kodpocztowy { get => kodpocztowy; set => kodpocztowy = value; }
        public string NrDomu { get => nrDomu; set => nrDomu = value; }
        public string Ulica { get => ulica; set => ulica = value; }

       
    }
}
