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
    public class PageNowyGrafikViewModel
    {
        public ListaZajec listaZajec
        {
            get { return CzytajXML.ReadLZ("listazajec.xml"); }
            set { }
        }
        public ListaPracownikow listaPracownikow
        {
            get;
            set;
        }
        public Zajecia SelectedZajecia { get; set; }
        public Pracownik SelectedPracownik { get; set; }


        private void DodajGrafik()
        {
            Grafik noweZajecie = new Grafik(SelectedPracownik.personID, SelectedZajecia.zajeciaId, DateTime.Today);
            CzytajXML.Zapiszgrafik(noweZajecie);
            CzytajXML.ZmniejszEtat(SelectedPracownik.personID);
            MessageBox.Show(SelectedZajecia.zajeciaId.ToString());
        }


        public ICommand DodajGrafikCommand { get; private set; }
      

        public PageNowyGrafikViewModel() {
            Console.WriteLine("jestem tu");
            PobierzListe();
            Console.WriteLine("jestem niczej");
            DodajGrafikCommand = new DelegateCommand(DodajGrafik);
        }
        public void PobierzListe()
        {
            listaZajec = CzytajXML.ReadLZ("listazajec.xml");
            listaPracownikow = CzytajXML.ReadLP("listap.xml");
            
            Console.WriteLine(listaPracownikow.Count());
            foreach(var lp in listaPracownikow)
            {
                Console.WriteLine(lp.imie + " " + Czlowiek.liczbaID);
            }
        }
    }
}
