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
        
        [XmlAttribute("id")]
        public int personID { get; set; }

        public static int liczbaID ;
     
        public Czlowiek() {
            this.imie = "Justyna";
            this.nazwisko = "Hoppe";
            this.Pesel = 940225031;
            this.personID = liczbaID;
            
            Console.WriteLine("może to");
        }

        public Czlowiek(String imie, String nazwisko, int pesel, int id) {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.Pesel = pesel;
            this.personID = id;
            Console.WriteLine("KOnstruktor");

        }
        //gdy nie ma id przypisanego
        public Czlowiek(String imie, String nazwisko, int pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.Pesel = pesel;
            this.personID = liczbaID+1;
            liczbaID += 1;
            Console.WriteLine("inny Konstruktor");
        }

    }
}

