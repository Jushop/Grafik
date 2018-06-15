using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using System.ComponentModel;

namespace Grafik
{
    public class PageGrafikViewModel : INotifyPropertyChanged
    {
        public ListaGrafik listaGrafik { get; set; }
        public ListaUzytkownikow _listaUczestnikow { get; set; }
        public ICommand DodajUczestnikowCommand { get; private set; }
      

        public Grafik selectedGrafik
        {
            get { return _selectedGrafik; }
            set
            {
                _selectedGrafik = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("selectedGrafik"));
                    DodajUczestnikow();
                }
            }
        }
        public Grafik _selectedGrafik { get; set; }
        public Uczestnik selectedUczestnik { get; set; }


        public ListaUzytkownikow listaUczestnikow
    {
            get { return _listaUczestnikow; }
            set
            {
                _listaUczestnikow = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("listaUczestnikow"));
                }
            }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;

        public PageGrafikViewModel() {
            Console.WriteLine("pobiera grafik");
            listaGrafik = CzytajXML.ReadLG("grafik.xml");
            DodajUczestnikowCommand = new DelegateCommand(DodajUczestnikowdoGrafiku);
           
        }
        public void DodajUczestnikow() {

           // listaUczestnikow = selectedGrafik.uczestnicyID;
            listaUczestnikow = CzytajXML.ReadLU("listau.xml");
            foreach (var u in selectedGrafik.uczestnicyID)
            {
                Uczestnik uczestnik = listaUczestnikow.Where(p => p.personID == u.personID).Single();
                listaUczestnikow.Remove(uczestnik);
            }
        }
        public void DodajUczestnikowdoGrafiku() {
            Console.WriteLine("mmm");
            //listaGrafik.Where(g => g == selectedGrafik).Single().uczestnicyID.Add(selectedUczestnik);
            //listaUczestnikow.Remove(selectedUczestnik);
           // CzytajXML.Zapiszgrafik2(listaGrafik);
           // CzytajXML.ZapiszUczestnikow(listaUczestnikow);

        }




    }
}
