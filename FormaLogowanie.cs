using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using KontrolaOperacji;

namespace ProjektProgramowanie
{
    public partial class FormLogowanie : Form
    {
        FormPracownik f2;
        FormKierownik f3;
        SZBD szbd = new SZBD();
    
        string NazwaPracownikaZalogowanego;
        int MyszX = 0, MyszY = 0;
        bool PrzycickMyszkiWcisniety;

        public FormLogowanie()
        {
         
            InitializeComponent();
            LabelLacznosc.Text +=szbd.TestŁacznosci();
            TextBoxLogin.TextChanged += UkryjLabelBladLogowania;
            TextBoxLogin.TextChanged += WyczyscTextBoxHaslo;
            TextBoxHaslo.TextChanged += UkryjLabelBladLogowania;
            
        }

        private void PokazForm(object sender, EventArgs e)
        {
            this.Show();
            TextBoxHaslo.Text = String.Empty;
            TextBoxLogin.Text = String.Empty;
        }
        //
        //Eventy 
        //
        void WyczyscTextBoxHaslo(object sender, EventArgs e)
        {
            TextBoxHaslo.Text = String.Empty;
        }
        void UkryjLabelBladLogowania(object sender, EventArgs e)
        {
            LabelBładLogowania.Visible = false;
        }

        //
        // Przyciski
        //
        private void Button1Pracownik_Click(object sender, EventArgs e)
        {
            if (szbd.SprawdzLogowaniePracownik(TextBoxLogin.Text,TextBoxHaslo.Text) != String.Empty)
            {

                NazwaPracownikaZalogowanego = szbd.SprawdzLogowaniePracownik(TextBoxLogin.Text, TextBoxHaslo.Text);
      
                f2 = new FormPracownik(NazwaPracownikaZalogowanego);
                f2.FormClosed += PokazForm;
                this.Hide();
                f2.ShowDialog();
            }
            else
            {
                LabelBładLogowania.Visible = true;
            }

        }

        private void Button2Kierownik_Click(object sender, EventArgs e)
        {

            if (szbd.SprawdzLogowaniePracownik(TextBoxLogin.Text, TextBoxHaslo.Text) != String.Empty)
            {

                NazwaPracownikaZalogowanego = szbd.SprawdzLogowaniePracownik(TextBoxLogin.Text, TextBoxHaslo.Text);

                f3 = new FormKierownik();
                f3.FormClosed += PokazForm;
                this.Hide();
                f3.ShowDialog();
            }
            else
            {
                LabelBładLogowania.Visible = true;
            }
        }

        //
        //Zamykanie form
        //
        private void ButtonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //Pasek górny przesuwanie
        //
        private void PanelTask_MouseDown(object sender, MouseEventArgs e)
        {
            PrzycickMyszkiWcisniety = true;
            

        }
        private void PanelTask_MouseMove(object sender, MouseEventArgs e)
        {
            if (PrzycickMyszkiWcisniety)
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

      
    }
}
