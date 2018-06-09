using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafik
{
    public class PageListaZajecViewModel
    {
        public ListaZajec ListaZajec
        {
            get { return CzytajXML.ReadLZ("listazajec.xml"); }
            set { }
        }
        public PageListaZajecViewModel()
        {
            PobierzListe();
        }

        public void PobierzListe()
        {
            ListaZajec = CzytajXML.ReadLZ("listazajec.xml");
        }
    }
}
