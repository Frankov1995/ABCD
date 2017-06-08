using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoNamespace
{
[Serializable]
     class Kino
    {
       //ilosc Sal w kinie
        public const int iloscSal = 4;
       //nazwa kina
        public string NazwaKina { get; set; }
    /// <summary>
    /// Lista przechowująca aktualne seanse w kinie
    /// </summary>
        public List<Seans> listaSeans = new List<Seans>(100);
    /// <summary>
    /// Metoda dodawania i metoda usuwania seansu z listaSeans
    /// </summary>
    /// <param name="s"> Jest to obiekt typu Seans</param>
        public void DodajSeans(Seans s)
        {
            listaSeans.Add(s);
        }
        public void UsunSeans(Seans s)
        {
            listaSeans.Remove(s);
        }
        
        public Kino()
        {
            //Przykladowe
            Seans s1 = new Seans(100);
            s1.Tytul = "Piraci z Karaibow";
            s1.NrSali = 1;
            s1.DataFilmu = new DateTime(2008, 3, 1, 7, 0, 0);
            Seans s2 = new Seans(100);
            s2.Tytul = "Azyl";
            s2.NrSali = 2;
            s2.DataFilmu = new DateTime(2008, 3, 1, 7, 0, 0);
            Seans s3 = new Seans(100);
            s3.Tytul = "Szybcy i wsciekli";
            s3.NrSali = 3;
            s3.DataFilmu = new DateTime(2008, 3, 1, 7, 0, 0);
            Seans s4 = new Seans(100);
            s4.Tytul = "Piraci z Karaibow";
            s4.NrSali = 2;
            s4.DataFilmu = new DateTime(2008, 3, 1, 7, 0, 0);
            Seans s5 = new Seans(100);
            s5.Tytul = "Jakis Film";
            s5.NrSali = 5;
            s5.DataFilmu = new DateTime(2008, 3, 1, 7, 0, 0);
            Seans s6 = new Seans(100);
            s6.Tytul = "To jest inny";
            s6.NrSali = 2;
            s6.DataFilmu = new DateTime(2008, 3, 1, 7, 0, 0);
            listaSeans.Add(s1);
            listaSeans.Add(s2);
            listaSeans.Add(s3);
            listaSeans.Add(s4);
            listaSeans.Add(s5);
            listaSeans.Add(s6);

        }
    }
}

