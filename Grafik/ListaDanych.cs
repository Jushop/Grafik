using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Grafik
{
    [Serializable]
    public class ListaPracownikow : ObservableCollection<Pracownik>
    {
       
        public ListaPracownikow() : base() { }
    }

    [Serializable]
    public class ListaUzytkownikow : ObservableCollection<Uczestnik>
    {
        
        public ListaUzytkownikow() : base() { }
        
    }

    [Serializable]
    public class ListaZajec : ObservableCollection<Zajecia>
    {

        public ListaZajec() : base() { }

    }

    [Serializable]
    public class ListaGrafik : ObservableCollection<Grafik>
    {

        public ListaGrafik() : base() { }

    }
}
