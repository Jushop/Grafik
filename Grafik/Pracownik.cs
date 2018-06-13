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

    public class Pracownik : Czlowiek, INotifyPropertyChanged
    {
        
        public int placa { get; set; }
        
        public DateTime dataZatrudnienia{ get; set; }

        public int etaty { get { return _etaty; } set {
                _etaty = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("etaty"));
                }
            } }
        private int _etaty;
        public event PropertyChangedEventHandler PropertyChanged;


        public Pracownik() : base() {
            this.placa = 8000;
            this.dataZatrudnienia = DateTime.Today;
            this._etaty = 5;
            
        }
        
        public Pracownik(String imie, String nazwisko, int pesel, int placa, int id) : base(imie, nazwisko, pesel, id)
        {
            this.placa = placa;
            this.dataZatrudnienia = DateTime.Today;
            this._etaty = 5;
        }
        public Pracownik(String imie, String nazwisko, int pesel, int placa) : base(imie, nazwisko, pesel)
        {
            this.placa = placa;
            this.dataZatrudnienia = DateTime.Today;
            this.etaty = 5;
        }
    }
}
