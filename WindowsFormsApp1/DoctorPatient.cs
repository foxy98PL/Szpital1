using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DoctorPatient
    {
        public string pesel;
        public string docName;
        public string docSName;
        public string medEx;
        public string price;
        public string refun;
        public string email;



        public DoctorPatient(string pesel, string docName, string docSName, string medEx, string price, string refun, string email)
        {
            this.pesel = pesel;
            this.docName = docName;
            this.docSName = docSName;
            this.medEx = medEx;
            this.price = price;
            this.refun = refun;
            this.email = email;
        }
    }
}
