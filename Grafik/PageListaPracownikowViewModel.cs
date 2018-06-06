﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafik
{
    public class PageListaPracownikowViewModel
    {

        public ListaPracownikow ListaPracownikow
        {
            get; set;
        }
        public PageListaPracownikowViewModel() {
            PobierzListe();
        }
        
        public void PobierzListe()
        {
            ListaPracownikow = CzytajXML.ReadLP("listap.xml");
        }
    }
}
