using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using System.Windows;
using System.Collections.ObjectModel;

namespace Grafik
{
    public class PageNowyUzytkownikViewModel
    {
        public ICommand MyButtonCommand2 { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Pesel { get; set; }


        public ListaUzytkownikow Listau
        {
            get; set;
        }


        public void PobierzListe()
        {
            Listau = CzytajXML.ReadLU("listau.xml");
        }

        public void DodajUzytkownika()
        {
            PobierzListe();
            Listau.Add(new Uczestnik(Imie, Nazwisko, Pesel));
            CzytajXML.ZapiszUczestnikow(Listau);
        }
        public PageNowyUzytkownikViewModel()
        {
           MyButtonCommand2 = new DelegateCommand(DodajUzytkownika);
        }
    }
}
