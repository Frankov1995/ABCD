using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoNamespace;
using System.Windows.Forms;

namespace KontrolaOperacji
{
     class  Kontrola
    {
         /// <summary>
         /// Ścieżka dostępu do pliku przechowującego zapisane Seanse
         /// </summary>
         string path = @"DataKino.bin";

        public   Kino kino = new Kino();
        public   Seans WybranySeans;

 
        public Kontrola()
   {

       Wczytaj();
      
       WybranySeans = kino.listaSeans[0];

   }


        public void PrzypiszWybranySeans(Seans s)
        {
            WybranySeans=s;
        }

        public void RezerwacjaMiejsc(List<int> listaWybranych)
        {
            foreach (var item in listaWybranych)
            {
                foreach (var i in WybranySeans.listaMiejsc)
                {
                    if((item==i.NrMiejsca)&&(i.StanZakup==false))
                    {
                        i.StanRezerwacja = true;
                        i.ustawToken();
                    }
                }
            }
        }
        
        public List<int> ZwrocListeZarezerwowanych()
        {
            List<int> listTMP = new List<int>();
            foreach (var item in WybranySeans.listaMiejsc)
            {
                if (item.StanRezerwacja == true)
                    listTMP.Add(item.NrMiejsca);
            }
            
            return listTMP;
        }
         /// <summary>
         /// Metoda zakupu miejsc w wybranym seansie
         /// </summary>
         /// <param name="listaWybranych">jest to lista wybranych numerów miejsc do zakupu</param>
        public void ZakupMiejsc(List<int> listaWybranych)
        {
            foreach (var item in listaWybranych)
            {
                foreach (var i in WybranySeans.listaMiejsc)
                {
                    if ((item == i.NrMiejsca) && (i.StanZakup == false))
                    {
                        i.StanZakup = true;
                    }
                }
            }
        }
        /// <summary>
        /// Metoda zakupu miejsc w wybranym seansie
        /// Metoda ta ustawia zakup dla wszystkich zarezerwowanym miejsc z pasującym tokenem
        /// </summary>
        /// <param name="token">jest to token generowany podczas rezerwacji </param>
        public void ZakupMiejscToken(string token)
        {
            
                foreach (var i in WybranySeans.listaMiejsc)
                {
                    i.ZakupZarezerwowane(token);
                    
                }
            
        }
         /// <summary>
         /// Metoda przeszukująca liste miejsc i dodadjąca do listy numery miejsc ze stanem zakup ustawionym na True
         /// </summary>
         /// <returns>Zwraca liste typu <int> numerów zakupionych miejsc</returns>
        public List<int> ZwrocListeZakupionych()
        {
            List<int> listTMP = new List<int>();
            foreach (var item in WybranySeans.listaMiejsc)
            {
                if (item.StanZakup == true)
                    listTMP.Add(item.NrMiejsca);
            }

            return listTMP;
        }
         /// <summary>
         /// Metoda zapisująca do pliku obiekt typu kino
         /// </summary>
        public void Zapisz()
        {
            ZapisOdczyt<Kino>.Serializacja(path, kino);
        }
         /// <summary>
         /// Metoda wczytująca z pliku obiekt Kino
         /// </summary>
        public void Wczytaj()
        {
            kino=ZapisOdczyt<Kino>.Deserializacja(path);
        }

         /// <summary>
         /// Metoda przeszukuje liste seansów wd parametrów tytul,nrSali,data i przypisuje go do aktualnie wybranego seansu
         /// </summary>
         /// <param name="tytul">Tytul filmu</param>
         /// <param name="nrSali">Nr sali, w których grany jest film</param>
         /// <param name="data">Data seansu</param>
         public void PrzypiszWybranySeans(string tytul,string nrSali,string data)
        {
            foreach(Seans s in kino.listaSeans)
            {
                if(s.Tytul == tytul && s.NrSali == Convert.ToInt32(nrSali) && s.DataFilmu == Convert.ToDateTime(data))
                {
                    WybranySeans = s;
                }
            }
        }
         
         /// <summary>
         /// Metoda tworząca tymczasowy obiekt Seans i dodająca go do listy seansów
         /// </summary>
        public void DodajSeansKierownik(string tytul,string gatunek,string czas_trwania,string opis ,string data,string nrmiejsca)
        {
            Seans temp = new Seans(100);
            temp.Tytul = tytul;
            temp.Gatunek = gatunek;
            temp.CzasSeansu = Convert.ToInt32(czas_trwania);
            temp.OpisFilmu = opis;
            temp.DataFilmu = Convert.ToDateTime(data);
            temp.NrSali= Convert.ToInt32(nrmiejsca);









        }

        public void ZapiszDoKinaSeans()
        {


            for(int i= 0; i < kino.listaSeans.Count;i++)
            {
                if(kino.listaSeans[i].Tytul==WybranySeans.Tytul)
                    if(kino.listaSeans[i].NrSali==WybranySeans.NrSali)
                    {
                        WybranySeans= kino.listaSeans[i];
                       
                     
                        break;

                    }

            }
         







        }
     }
}
