using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Grafik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void ZobaczPlan(object sender, RoutedEventArgs e)
        {
            PageGrafik pageGrafik = new PageGrafik();
            framePlace.Navigate(pageGrafik);
        }

        private void ZobaczZajecia(object sender, RoutedEventArgs e)
        {
            PageListaZajec pageListaZajec = new PageListaZajec();
            framePlace.Navigate(pageListaZajec);
        }

        private void DodajZajecia(object sender, RoutedEventArgs e)
        {
            
        }

        private void DodajPracownika(object sender, RoutedEventArgs e)
        {
            //addPerson person = new addPerson();
            PageNowyPracownik pageNowyPracownik = new PageNowyPracownik();
            framePlace.Navigate(pageNowyPracownik);
        }

        private void UstalGrafik(object sender, RoutedEventArgs e)
        {
            PageNowyGrafik pageNowyGrafik = new PageNowyGrafik();
            framePlace.Navigate(pageNowyGrafik);
        }

        private void ZobaczPracownikow(object sender, RoutedEventArgs e)
        {
            PageListaPracownikowViewModel pageListaPracownikow = new PageListaPracownikowViewModel();
            framePlace.Navigate(pageListaPracownikow);
        }
    }
}
