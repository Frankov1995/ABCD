using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinoNamespace;
using KontrolaOperacji;

namespace ProjektProgramowanie
{
    public partial class FormPracownik : Form
    {
        SZBD szbd = new SZBD();
        Kontrola Wykonaj = new Kontrola();
      
       
        public List<Button> ListaButtonMiejsce = new List<Button>();
        public List<int> ListaNumerowWybranych = new List<int>();
        public List<Panel>listawyborow=new List<Panel>();
        string ostatnioWybraneMiejsce;
        private int iloscWybranych;
        public int IloscWybranych {
           get 
             { return iloscWybranych; 
             } 
           set { 
               
                 iloscWybranych = value; 
               WypiszInfoWybranych(); }
             }

        int MyszX = 0, MyszY=0;
        bool PrzycickMyszkiWcisniety;

        public FormPracownik(string s)
        {

            

         
            InitializeComponent();
            WyswietlenieMiejsc();
        
            LabelZalogowany.Text += " " + s;
            Wykonaj.Wczytaj();

            AktualizujWyswietlanie();
            WyswietlWyborFilmu();
        
        }

        public void WyswietlenieMiejsc()
        {
            int left = 20, top = 80;
         
            //Miejsca 1-osobowe
            for (int i = 1; i <= 100; i++)
            {

                Button tmp = new Button();
                tmp.FlatStyle = FlatStyle.Flat;
                tmp.BackColor = Color.GhostWhite;
                tmp.Height = 40;
                tmp.Width = 40;
                tmp.Left = left;
                left = left + 40;
                tmp.Top = top;
                tmp.Text = i.ToString();
                if ((i % 20) == 0)
                {
                    top += 50;
                    left = 20;
                }
              
                SalaPanel.Controls.Add(tmp);
                tmp.Click += UstawienieWybranych;
                ListaButtonMiejsce.Add(tmp);


            }
          
            //Miejsca 2-osobowe
            /*
            for (int i = 1; i <= 20; i += 2)
            {
                Button tmp = new Button();
               
                tmp.Height = 40;
                tmp.Width = 80;
                tmp.Left = left;
                left = left + 80;
                tmp.Top = top;

                tmp.Text = i.ToString() + " " + (i + 1).ToString();

                SalaPanel.Controls.Add(tmp);
                tmp.Click += UstawienieWybranych;
                ListaButtonMiejsce.Add(tmp);

            }*/
        }
    
        public void UstawienieWybranych(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            if (IloscWybranych < 9)
            {
                if(tmp.BackColor == Color.GhostWhite){
                tmp.BackColor = Color.Blue;
                ListaNumerowWybranych.Add(Convert.ToInt32(tmp.Text));
                ostatnioWybraneMiejsce = tmp.Text;

                IloscWybranych++;
            }
            }
        }

        public void ButtonRezerwacja_Click(object sender, EventArgs e)
        {
            Wykonaj.RezerwacjaMiejsc(ListaNumerowWybranych);
            ListaNumerowWybranych.Clear();
            IloscWybranych = 0;
            AktualizujWyswietlanie();

        }
        //Aktualizacja kolorow miejsc
        private void AktualizujWyswietlanie()
        {
            
                foreach (var it in ListaButtonMiejsce)
                {

             
                        it.BackColor = Color.GhostWhite;
                }
        
            foreach (var item in Wykonaj.ZwrocListeZarezerwowanych())
            {
                foreach (var i in ListaButtonMiejsce)
                {

                    if (item == Convert.ToInt32(i.Text))
                        i.BackColor = Color.Green;
                }
            }
          
            foreach (var item in Wykonaj.ZwrocListeZakupionych())
            {
                foreach (var i in ListaButtonMiejsce)
                {

                    if (item == Convert.ToInt32(i.Text))
                        i.BackColor = Color.Red;
                }
            }
            Label_Informacja.Text = " Tytul: " + Wykonaj.WybranySeans.Tytul + " Nr Sali: " + Wykonaj.WybranySeans.NrSali.ToString() + " Data: " + Wykonaj.WybranySeans.DataFilmu.ToString();
            Label_IleWybranychMiejsc.Text = "Wybrano miejsce:";

            Wykonaj.Zapisz();
        }

        private void Zakup_Click(object sender, EventArgs e)
        {
            Wykonaj.ZakupMiejsc(ListaNumerowWybranych);
            ListaNumerowWybranych.Clear();
            IloscWybranych = 0;
            AktualizujWyswietlanie();
         

        }
        

        //Metody wyboru filmu

        private void WyswietlWyborFilmu()
        {
            int top=30;
            foreach(var film in Wykonaj.kino.listaSeans)
            {
                Panel tmpPanel = new Panel();
                tmpPanel.Width = 300;
                tmpPanel.Height = 90;
                tmpPanel.Top = top;
                tmpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(192)))));
               
                Label labelTytul = new Label();
                labelTytul.Width = 200;

           labelTytul.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           labelTytul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
               
                labelTytul.Top = 0;
                labelTytul.Text = film.Tytul;
                Label labelNrSali = new Label();
                labelNrSali.Top = 25;
                labelNrSali.Width = 200;

                labelNrSali.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelNrSali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));

                labelNrSali.Text = film.NrSali.ToString();
                Label labelData = new Label();
                labelData.Top = 50;

                labelData.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));

                labelData.Width = 200;
                labelData.Text =  film.DataFilmu.ToString();
                tmpPanel.Controls.Add(labelTytul);
                tmpPanel.Controls.Add(labelNrSali);
                tmpPanel.Controls.Add(labelData);
                tmpPanel.Click += WyborFilmu;
                tmpPanel.MouseEnter += ZmianaKoloruPanel_MouseEnter;
                tmpPanel.MouseLeave += ZmianaKoloruPanel_MouseLeave;
                listawyborow.Add(tmpPanel);
                PanelWybor.Controls.Add(tmpPanel);
                top += 95;


            }
        }
      
        private  void  WyborFilmu(object sender,EventArgs e){
         
           string tmpTytul=null ;
           string tmpNrSali=null;
           
           int nr=0;
           Panel tmp = (Panel)sender;
           foreach (var item in tmp.Controls)
           {
               if (item is Label)
               {

                   Label i = (Label)item;
                   if (nr == 0)
                   { tmpTytul = i.Text;
              
                   
                   }
                   if (nr == 1)
                   {
                       tmpNrSali = i.Text;
                
                      
                   }
                   nr++;
                

               }
           }
           foreach (var i in Wykonaj.kino.listaSeans)
           {


               if (i.Tytul == tmpTytul)
               {

                   if (i.NrSali == Convert.ToInt32(tmpNrSali))
                   {

                       Wykonaj.PrzypiszWybranySeans(i);
                       AktualizujWyswietlanie();


                   }
               }
           }

       }
        private void ZmianaKoloruPanel_MouseEnter(object sender, EventArgs e)
        {
            Panel tmp = (Panel)sender;
            tmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(124)))), ((int)(((byte)(12)))));
        }
        private void ZmianaKoloruPanel_MouseLeave(object sender, EventArgs e)
        {
            Panel tmp = (Panel)sender;
            tmp.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(192)))));

        }


        //Metody obslugi górnego paska 
        private void ButtonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelTask_MouseDown(object sender, MouseEventArgs e)
        {
            PrzycickMyszkiWcisniety =true;

        }

        private void PanelTask_MouseMove(object sender, MouseEventArgs e)
        {
            if(PrzycickMyszkiWcisniety)
            {
                MyszX = MousePosition.X - (PanelTask.Width / 2);
                MyszY = MousePosition.Y;
                this.SetDesktopLocation(MyszX, MyszY);
            }
        }

        private void PanelTask_MouseUp(object sender, MouseEventArgs e)
        {
            PrzycickMyszkiWcisniety = false;
        }

        //Metoda Info
        private void WypiszInfoWybranych()
        {
            if (iloscWybranych < 9)
                Label_IleWybranychMiejsc.Text += " " + ostatnioWybraneMiejsce+",";
            else
                Label_IleWybranychMiejsc.Text +=ostatnioWybraneMiejsce+ " Maksymalna ilość wybranych miejsc: " + IloscWybranych.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wykonaj.ZakupMiejscToken(TexBoxToken.Text);
            AktualizujWyswietlanie();
            TexBoxToken.Text = String.Empty;
        }
     

     
      
      

        

      
    }
}
