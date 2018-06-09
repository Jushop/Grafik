using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafik
{
    public class PageListaUczestnikowViewModel
    {
        public ListaUzytkownikow ListaUzytkownikow
        {
            get { return CzytajXML.ReadLU("listau.xml"); }
            set { }
        }
        public PageListaUczestnikowViewModel()
        {
            PobierzListe();
        }

        public void PobierzListe()
        {
            ListaUzytkownikow = CzytajXML.ReadLU("listau.xml");
        }
    }
}
