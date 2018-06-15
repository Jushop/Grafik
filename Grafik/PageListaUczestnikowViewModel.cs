using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Threading.Tasks;
using System.ComponentModel;
using Prism.Commands;

namespace Grafik
{
    public class PageListaUczestnikowViewModel : INotifyPropertyChanged
    {
        private ListaUzytkownikow _ListaUzytkownikow
        { get; set;
        }
        public ListaUzytkownikow ListaUzytkownikow
        {
            get { return _ListaUzytkownikow; }
            set
            {
                _ListaUzytkownikow = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ListaUzytkownikow"));

                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public Uczestnik SelectedUser { get; set; }
        public int Karnet { get; set; }
        private void EdytujKarnetUser()
        {
             ListaUzytkownikow.Where(u => u.personID== SelectedUser.personID).Single().ZaladujKarnet(Karnet);
             CzytajXML.ZapiszUczestnikow(ListaUzytkownikow);
        }

       
        public ICommand EditCommand { get; private set; }
        public PageListaUczestnikowViewModel()
        {
            PobierzListe();
            EditCommand = new DelegateCommand(EdytujKarnetUser);
        }

        public void PobierzListe()
        {
           
            ListaUzytkownikow = CzytajXML.ReadLU("listau.xml");
           
        }
    }
}
