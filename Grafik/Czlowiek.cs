using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;


namespace Grafik
{
    [Serializable]
    public class Czlowiek
    {
       
        public String imie
        {
            get;
            set;
        }
        
        public String nazwisko
        {
            get;
           set;
        }
        
        public int Pesel
        {
            get;
            set;
        }
        public int personID { get;  }
        private static int liczbaID = 0;
       
        public Czlowiek() {
            this.imie = "Justyna";
            this.nazwisko = "Hoppe";
            this.Pesel = 940225031;
            this.personID = liczbaID;
            liczbaID += 1;
        }

        public Czlowiek(String imie, String nazwisko, int pesel) {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.Pesel = pesel;
            this.personID = liczbaID;
            liczbaID += 1;
        }
    }
}
