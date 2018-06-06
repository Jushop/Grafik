using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace Grafik
{
    class CzytajXML
    {
        public static void Main1()
        {
            // Read and write purchase orders.  
            CzytajXML t = new CzytajXML();
            t.CreatePO("listap.xml", "listau.xml", "grafik.xml", "listazajec.xml");
            // t.ReadPO("listap.xml","listau.xml","grafik.xml");
        }
        public static void ZapiszDane(string filename, ListaPracownikow lista)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ListaPracownikow));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, lista);
            writer.Close();
        }
        [STAThread]
        public void CreatePO(string filename1, string filename2, string filename3, string filename4)
        {
            // Creates an instance of the XmlSerializer class;  
            // specifies the type of object to serialize.  
            //dodajemy 3 pracownikow
            // Person.Start(0);
            ListaPracownikow lp = new ListaPracownikow();
            for (int i = 0; i < 3; i++)
            {
                Pracownik p = new Pracownik("Basia" + i, "Nowak", 942666454, 1000 * i);
                //lp.listaPracownikow.Add(p);
                lp.Add(p);
            }


            XmlSerializer serializer = new XmlSerializer(typeof(ListaPracownikow));
            TextWriter writer = new StreamWriter(filename1);
            serializer.Serialize(writer, lp);
            writer.Close();
            //dodajemy 3 uzytkonikow
            ListaUzytkownikow lu = new ListaUzytkownikow();
            for (int i = 0; i < 3; i++)
            {
                Uczestnik u = new Uczestnik("Ela" + i, "Bocian", 123 * i);
                lu.Add(u);
            }
            XmlSerializer serializer2 = new XmlSerializer(typeof(ListaUzytkownikow));
            TextWriter writer2 = new StreamWriter(filename2);
            serializer2.Serialize(writer2, lu);
            writer2.Close();

            Zajecia zajecia1 = new Zajecia(20, "Zumba");
            Zajecia zajecia2 = new Zajecia(10, "Salsa");

            XmlSerializer serializer4 = new XmlSerializer(typeof(ListaZajec));
            TextWriter writer4 = new StreamWriter(filename4);
            // Grafik po = new Grafik(pracownik1, zajecia1, DateTime.Today);

            ListaZajec listaZ = new ListaZajec();
            listaZ.Add(zajecia1);
            listaZ.Add(zajecia2);

            serializer4.Serialize(writer4, listaZ);
            // Sets ShipTo and BillTo to the same addressee.  

            XmlSerializer serializer3 = new XmlSerializer(typeof(ListaGrafik));
            TextWriter writer3 = new StreamWriter(filename3);
            // Grafik po = new Grafik(pracownik1, zajecia1, DateTime.Today);
            Grafik g1 = new Grafik(lp[1].personID, 0, DateTime.Today);
            g1.DodajUczesnika(lu[1]);
            Grafik g2 = new Grafik(lp[2].personID, 1, DateTime.Today);
            g2.DodajUczesnika(lu[2]);


            ListaGrafik grafik = new ListaGrafik();
            grafik.Add(g1);
            grafik.Add(g2);



            serializer3.Serialize(writer3, grafik);
            writer3.Close();


        }

        public void ReadPO(string filename1, string filename2, string filename3)
        {

            //Lista pracownikow
            XmlSerializer serializer1 = new XmlSerializer(typeof(ListaPracownikow));
            serializer1.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
            serializer1.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);

            FileStream fslp = new FileStream(filename1, FileMode.Open);
            // Declares an object variable of the type to be deserialized.  
            ListaPracownikow aktualnalp;

            aktualnalp = (ListaPracownikow)serializer1.Deserialize(fslp);

            //Lista uzytkownikow
            XmlSerializer serializer2 = new XmlSerializer(typeof(ListaUzytkownikow));
            serializer2.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
            serializer2.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);

            FileStream fslu = new FileStream(filename2, FileMode.Open);
            // Declares an object variable of the type to be deserialized.  
            ListaUzytkownikow aktualnalu;

            aktualnalu = (ListaUzytkownikow)serializer2.Deserialize(fslu);

            //GRAFIK
            XmlSerializer serializer3 = new XmlSerializer(typeof(ListaGrafik));
            serializer3.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
            serializer3.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);

            FileStream fs = new FileStream(filename3, FileMode.Open);
            // Declares an object variable of the type to be deserialized.  
            ListaGrafik aktualnygrafik;

            aktualnygrafik = (ListaGrafik)serializer3.Deserialize(fs);

            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(aktualnalp[aktualnygrafik[j].instruktorID]);
            }




        }

        public static ListaPracownikow ReadLP(string filename1)
        {

            //Lista pracownikow
            XmlSerializer serializer1 = new XmlSerializer(typeof(ListaPracownikow));
            serializer1.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
            serializer1.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);

            FileStream fslp = new FileStream(filename1, FileMode.Open);
            // Declares an object variable of the type to be deserialized.  
            ListaPracownikow aktualnalp;

            aktualnalp = (ListaPracownikow)serializer1.Deserialize(fslp);
            fslp.Close();
            return aktualnalp;

        }
        protected static void serializer_UnknownNode
        (object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        protected static void serializer_UnknownAttribute
        (object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }
    }
}

