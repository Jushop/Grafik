using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using System.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;



namespace Grafik
{
    public class PageListaZajecViewModel : INotifyPropertyChanged
    {
        public ListaZajec _ListaZajecp
        { get; set; }
        public ListaZajec ListaZajecp
        {
            get { return _ListaZajecp; }
            set {
                _ListaZajecp = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ListaZajecp"));
                    
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public Zajecia SelectedUser { get; set; }
        public String NazwaZajec { get; set; }
        public int LimitZajec { get; set; }
        
    

    private void  EditSelectedUser()
    {
            // some edit code here
            MessageBox.Show(SelectedUser.nazwaZajec);
    }

        public ICommand DodajCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
    public PageListaZajecViewModel()
        {
            PobierzListe();
            EditCommand = new DelegateCommand(EditSelectedUser);
            DodajCommand = new DelegateCommand(DodajZajecia);
        }

        public void PobierzListe()
        {
            _ListaZajecp = CzytajXML.ReadLZ("listazajec.xml");
        }

        public void DodajZajecia()
        {
            ListaZajecp.Add(new Zajecia(LimitZajec, NazwaZajec));
            CzytajXML.ZapiszZajecia(ListaZajecp);
        }
    }

}
