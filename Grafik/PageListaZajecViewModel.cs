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
    public class PageListaZajecViewModel
    {
        public ListaZajec ListaZajecp
        {
            get { return CzytajXML.ReadLZ("listazajec.xml"); }
            set { }
        }
        public Zajecia SelectedUser { get; set; }
        
    

    private void  EditSelectedUser()
    {
            // some edit code here
            MessageBox.Show(SelectedUser.nazwaZajec);
    }

   
    public ICommand EditCommand { get; private set; }
    public PageListaZajecViewModel()
        {
            PobierzListe();
            EditCommand = new DelegateCommand(EditSelectedUser);
        }

        public void PobierzListe()
        {
            ListaZajecp = CzytajXML.ReadLZ("listazajec.xml");
        }
    }
}
