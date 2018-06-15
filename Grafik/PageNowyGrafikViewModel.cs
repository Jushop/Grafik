using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Commands;
using System.Windows;
using System.ComponentModel;


namespace Grafik
{
    public class PageNowyGrafikViewModel 
    {
        public ListaZajec listaZajec
        {
            get { return CzytajXML.ReadLZ("listazajec.xml"); }
            set { }
        }
        private ListaPracownikow _listaPracownikow;
        public ListaPracownikow listaPracownikow
        {
            get
            {
                return _listaPracownikow;
            }
            set
            {
                _listaPracownikow = value;
            }
        }
   
        public Zajecia SelectedZajecia { get; set; }
        public Pracownik SelectedPracownik { get; set; }
      
       

        private void DodajGrafik()
        {
            Grafik noweZajecie = new Grafik(listaPracownikow.Where(p => p == SelectedPracownik).Single(), SelectedZajecia.zajeciaId, DateTime.Today);
            CzytajXML.Zapiszgrafik(noweZajecie);
            CzytajXML.ZapiszDane("listap.xml", listaPracownikow);
            MessageBox.Show("Zapisano!");
        }


        public ICommand DodajGrafikCommand { get; private set; }
      

        public PageNowyGrafikViewModel() {
            PobierzListe();
            DodajGrafikCommand = new DelegateCommand(DodajGrafik);
        }
        public void PobierzListe()
        {
            listaZajec = CzytajXML.ReadLZ("listazajec.xml");
            _listaPracownikow = CzytajXML.ReadLP("listap.xml");
        }
    }
}
