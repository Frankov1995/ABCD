using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KontrolaOperacji;
namespace ProjektProgramowanie
{
    public partial class FormKierownik : Form
    {

        SZBD szbd = new SZBD();
     
        List<string> wybranyfilm;
        
        string NazwaPracownikaZalogowanego;
        int MyszX = 0, MyszY = 0;
        bool PrzycickMyszkiWcisniety;

        public FormKierownik()
        {
            InitializeComponent();

            foreach(var item in szbd.ListaTytułóws())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void wybor(string tytul)
        {

            wybranyfilm =szbd.WybranyFilm(tytul);
           textBox1.Text = wybranyfilm[0];
           textBox2.Text = wybranyfilm[1];
           textBox3.Text = wybranyfilm[2];
           textBox4.Text = wybranyfilm[3];
           textBox5.Text = wybranyfilm[4];




        }
        // zamykanie okna
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           ComboBox tmp  = (ComboBox)sender ;
           wybor(tmp.SelectedItem.ToString());
           wybranyfilm.Clear();
        }
    }
}
