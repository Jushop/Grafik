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
              //  spr("listaPracownikow");
            }
        }
     /*   public void spr(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        } */
        public Zajecia SelectedZajecia { get; set; }
        public Pracownik SelectedPracownik { get; set; }
      //  public event PropertyChangedEventHandler PropertyChanged;
       

        private void DodajGrafik()
        {
           // Grafik noweZajecie = new Grafik(SelectedPracownik, SelectedZajecia.zajeciaId, DateTime.Today);
           // CzytajXML.Zapiszgrafik(noweZajecie);
            //Zmniejsz etat pracownika
            listaPracownikow.Add(new Pracownik());
            listaPracownikow.Where(p => p == SelectedPracownik).Single().placa = 30;
            CzytajXML.ZapiszDane("listap.xml", listaPracownikow);
           
          //  Zapisz zmiany do pliku xml

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
            _listaPracownikow = CzytajXML.ReadLP("listap.xml");
            
            Console.WriteLine(listaPracownikow.Count());
            foreach(var lp in listaPracownikow)
            {
                Console.WriteLine(lp.imie + " " + Czlowiek.liczbaID);
            }
        }
    }
}
