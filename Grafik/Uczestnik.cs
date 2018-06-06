﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Grafik
{
    [Serializable]
    public class Uczestnik : Czlowiek
    {
       
        public int iloscZajec
        {
            get;
             set;
        }
        
        public DateTime dataPrzystapienia
        {
            get;
            set;
        }
        public Uczestnik()
        {
            this.iloscZajec = 0;
            this.dataPrzystapienia = DateTime.Today;
        }
        public Uczestnik(String imie, String nazwisko, int pesel) : base(imie, nazwisko, pesel) {
            this.iloscZajec = 0;
            this.dataPrzystapienia = new DateTime();
        }
    }
}
