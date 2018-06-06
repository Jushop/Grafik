using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Grafik
{
    [Serializable]

    public class Pracownik : Czlowiek
    {
        
        public int placa { get; set; }
        
        public DateTime dataZatrudnienia{ get; set; }

        public int etaty { get; set; }

        public Pracownik() : base() {
            this.placa = 8000;
            this.dataZatrudnienia = DateTime.Today;
            this.etaty = 5;
            
        }
        public Pracownik(String imie, String nazwisko, int pesel, int placa) : base(imie, nazwisko, pesel) {
            this.placa = placa;
            this.dataZatrudnienia = DateTime.Today;
            this.etaty = 5;
        }

    }
}
