using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;

namespace Grafik
{
    [Serializable]
    public class Uczestnik : Czlowiek, INotifyPropertyChanged
    {
       
        

        public int iloscZajec
        {
            get { return _iloscZajec; }
            set
            {
                _iloscZajec = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("iloscZajec"));
                }
            }
        }
        private int _iloscZajec;
        public event PropertyChangedEventHandler PropertyChanged;
        public DateTime dataPrzystapienia
        {
            get;
            set;
        }
        public Uczestnik()
        {
            this._iloscZajec = 0;
            this.dataPrzystapienia = DateTime.Today;
        }
        public Uczestnik(String imie, String nazwisko, int pesel) : base(imie, nazwisko, pesel)
        {
            this._iloscZajec = 0;
            this.dataPrzystapienia = new DateTime();
        }
      
        public Uczestnik(String imie, String nazwisko, int pesel, int id) : base(imie, nazwisko, pesel, id) {
            this.iloscZajec = 5;
            this.dataPrzystapienia = new DateTime();
        }

        public void ZaladujKarnet(int karnet)
        {
            this.iloscZajec = karnet;
        }
        public void UaktualniKarnetPoZapisach()
        {
            this.iloscZajec -= 1;
        }
    }
}
