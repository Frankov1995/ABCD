using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoNamespace
{
    [Serializable]
    class Seans
    {
        /// <summary>
        /// Lista przechowująca obiekty typu Miejsca
        /// </summary>
        public List<Miejsce> listaMiejsc = new List<Miejsce>();
       
        public string Tytul{get;set;}
        public string Gatunek{get;set;}
        public int CzasSeansu { get; set; }
        public string OpisFilmu { get; set; }
        public int CenaFilmu { get; set; }
        public int NrSali { get; set; }
        public DateTime DataFilmu { get; set; }
        /// <summary>
        /// Konstruktor obiektu inicjalizuje listę
        /// obiektami Miejsce
        /// </summary>
        /// <param name="n">Ilosc miejsc w sali
        /// przekazywany z obiektu klasy Sala</param>
       public Seans(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Miejsce tmp = new Miejsce();
                tmp.NrMiejsca = i;
                listaMiejsc.Add(tmp);
            }
        }
    }
    }


