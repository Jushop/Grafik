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
    /// Interaction logic for PageGrafik.xaml
    /// </summary>
    public partial class PageNowyGrafik : Page
    {
        public PageNowyGrafik()
        {
           ListaZajec ListaZajec = CzytajXML.ReadLZ("listazajec.xml");
            ListaPracownikow listaPracownikow = CzytajXML.ReadLP("listap.xml");
            InitializeComponent();
            listBox.ItemsSource = ListaZajec;
            listBox1.ItemsSource = listaPracownikow;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
