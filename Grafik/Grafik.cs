using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Grafik
{
    [Serializable]
    public class Grafik
    {
        
        public int instruktorID
        {
            get;
            set;
        }
        
        public int zajeciaID
        {
            get;
            set;
        }
        
        public DateTime dataZajec
        {
            get;
            set;
        }
        public int iloscZarezerwowanych
        {
            get;
            set;
        }
        [XmlArrayItem("idUczestnika")]
        public ListaUzytkownikow uczestnicyID { get;  set; }

        public Grafik() {
            this.dataZajec = DateTime.Today;
            this.instruktorID = -1;
            this.zajeciaID = -1;
            this.iloscZarezerwowanych = 0;
            this.uczestnicyID = new ListaUzytkownikow();
        }
        public Grafik(int pracownikID, int zajecia, DateTime dataZajec) {
            this.instruktorID = pracownikID;
            this.dataZajec = dataZajec;
            this.zajeciaID = zajecia;
            this.iloscZarezerwowanych = 0;
            this.uczestnicyID = new ListaUzytkownikow();
        }
        public bool DodajUczesnika(Uczestnik uczestnik)
        {
            if (uczestnik.iloscZajec > 0)
            {
                Console.WriteLine(uczestnik.iloscZajec);
                this.iloscZarezerwowanych += 1;
                this.uczestnicyID.Add(uczestnik);
               uczestnik.iloscZajec = 10;
                Console.WriteLine(uczestnik.iloscZajec);
                return true;
            } else
            {
                return false;
            }
           
        }
        
       
    }
}
