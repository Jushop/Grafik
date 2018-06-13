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
        { get; set;
        }
        public PageListaUczestnikowViewModel()
        {
            PobierzListe();
        }

        public void PobierzListe()
        {
            Console.WriteLine("Wczytuje");
            ListaUzytkownikow = CzytajXML.ReadLU("listau.xml");
            Console.WriteLine(CzytajXML.maxID + "  " );
        }
    }
}
