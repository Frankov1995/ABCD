using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KontrolaOperacji
{
    class SZBD
    {
        public OleDbConnection nowepolaczenie = new OleDbConnection();
        public OleDbCommand komenda = new OleDbCommand();
        List<string> ListaWybryFilmText= new List<string>();
        List<string> ListaTytułowText= new List<string>();

        string imieNazwiskoZalogowanego;

       

        public SZBD()
        {
            nowepolaczenie.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";
     
        }

        public string TestŁacznosci()
        {
            try
            {

                nowepolaczenie.Open();
                nowepolaczenie.Close();
               return  " polaczono ";
         
               
            }
            catch (Exception x)
            {
                return "brak połączenia "+x;
            }
        }

        public string SprawdzLogowaniePracownik(string login, string haslo)
        {
            try
            {

                nowepolaczenie.Open();
                OleDbCommand komenda = new OleDbCommand();
                komenda.Connection = nowepolaczenie;
                // nowepolaczenie.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;";

                komenda.CommandText = "select * from Pracownicy where uzytkownik='" + login + "'and haslo='" + haslo + "'";

                OleDbDataReader czytaj = komenda.ExecuteReader();
                int count = 0;

                while (czytaj.Read())
                {

                    ++count;
                    if (count > 0)
                    {
                        imieNazwiskoZalogowanego = czytaj["imie"].ToString() + " "
                      + czytaj["nazwisko"].ToString();

                    }
                }
                nowepolaczenie.Close();

                if (count >= 1)
                {

                    return imieNazwiskoZalogowanego;

                }
                else
                {

                    return String.Empty;
                }
            }
            catch (Exception e)
            {
                return "Blad" + e;
            }
        }
        
        public string DodajSeansKierownikBazaDanych(string tytul,string gatunek,string czas_trwania,string opis ,string data,string nrSali){

               try
               {


                   nowepolaczenie.Open();
                   OleDbCommand komenda = new OleDbCommand();
                   komenda.Connection = nowepolaczenie;

                   komenda.CommandText = "INSERT INTO Filmy (Tytuł,Opis,gatunek,cena,czas,Data,nrSali)" + " VALUES('" + tytul + " ','" + gatunek + "','" + czas_trwania + " ','" + opis + " ','" + data + " ','" + nrSali + " ')";
                   komenda.Parameters.AddWithValue("@Tytuł", tytul);
                   OleDbDataReader mojanazwa= komenda.ExecuteReader();


                   





                   nowepolaczenie.Close();
                   return "Dodano do Bazy Danych";
               }
               catch (Exception z)
               {
                  return ("dasd" + z);
               }

                
        }

           public List<string> WybranyFilm(string comboBox1)
           {
               
              
               try
               {


                   nowepolaczenie.Open();
                   OleDbCommand komenda = new OleDbCommand();
                   komenda.Connection = nowepolaczenie;
                   string qwerty = "select * from Filmy where Tytuł='" + comboBox1 + "'";

                   komenda.CommandText = qwerty;
                   OleDbDataReader czytaj = komenda.ExecuteReader();
                   while (czytaj.Read())
                   {
                       
                       ListaWybryFilmText.Add(czytaj["Id_Filmu"].ToString());
                       ListaWybryFilmText.Add(czytaj["Tytuł"].ToString());
                       ListaWybryFilmText.Add(czytaj["gatunek"].ToString());
                       ListaWybryFilmText.Add(czytaj["cena"].ToString());
                       ListaWybryFilmText.Add(czytaj["czas trwania"].ToString());


                   }


                   nowepolaczenie.Close();
                   return ListaWybryFilmText;


               }
               catch (Exception e)
               {
                   ListaWybryFilmText.Add("brak");
                   ListaWybryFilmText.Add("brak");
                   ListaWybryFilmText.Add("brak");
                   ListaWybryFilmText.Add("brak");
                   ListaWybryFilmText.Add("brak");
                   return ListaWybryFilmText;
               }
           }
       
            
       public List<string> ListaTytułóws()
           {
               
              
               try
               {


                   nowepolaczenie.Open();
                   OleDbCommand komenda = new OleDbCommand();
                   komenda.Connection = nowepolaczenie;
                   string qwerty = "select * from Filmy ";

                   komenda.CommandText = qwerty;
                   OleDbDataReader czytaj = komenda.ExecuteReader();
                   while (czytaj.Read())
                   {
                       
                      
                       ListaTytułowText.Add(czytaj["Tytuł"].ToString());
                       


                   }


                   nowepolaczenie.Close();
                   return ListaTytułowText;


               }
               catch (Exception e)
               {
                   ListaTytułowText.Add("brak"+e);

                   return ListaTytułowText;
               }
           }

    }

}
