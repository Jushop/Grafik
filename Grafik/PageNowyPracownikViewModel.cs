using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using System.Windows;
using System.Collections.ObjectModel;

namespace Grafik
{
    public class PageNowyPracownikViewModel
    {
        public ICommand MyButtonCommand2 { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Pesel { get; set; }
        public int Placa { get; set; }


        public ListaPracownikow Listap
        {
            get; set;
        }


        public void PobierzListe()
        {
            Listap = CzytajXML.ReadLP("listap.xml");
        }

        public void DodajPracownika()
        {
            PobierzListe();
            Listap.Add(new Pracownik(Imie, Nazwisko, Pesel, Placa));
            CzytajXML.ZapiszDane("listap.xml", Listap);
        }
        public PageNowyPracownikViewModel()
        {
          //  MyButtonCommand2 = new DelegateCommand(DodajPracownika);
        }
    }
}
