using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Grafik
{
    [Serializable]
    public class Zajecia
    {
        
        public int limitOsob
        {
            get;
            set;
        }
        
        public String nazwaZajec
        {
            get;
            set;
        }

        public int zajeciaId
        {
            get;
            set;
        }
        private static int liczbaZajec = 0;

        public Zajecia() { }
        public Zajecia(int limitOsob, String nazwaZajec)
        {
            this.limitOsob = limitOsob;
            this.nazwaZajec = nazwaZajec;
            this.zajeciaId += liczbaZajec;
            liczbaZajec += 1;
        }

    }
}
