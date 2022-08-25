using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panacek
{
    public partial class oknoProgramu : Form
    {     //velikost a start pozice kocky
        int xkocik = 150;
        int ykocik = 150;
        int sirkakocik = 40;
        int vyskakocik = 50;
        Image obrazek = Properties.Resources.kocik;
        //velikost a start pozice ryby
        int Xryba = 50;
        int Yryba = 50;
        int sirkaRyba = 30;
        int vyskkaRyba = 25;
        int rybaskok = 5;
        Image ryba = Properties.Resources.ryba;
        //pocitadlo ryb
        int pocitadlo = 0;
        int chyt = 0;
        int rozptyl = 20;
        //nahoda pro pozici ryby
        Random poziceNahoda = new Random();


        //if pozice kocik = pozice ryba, pocitadlo +1,  nova ryba nahodna pozice



        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlacitkoNahoru_Click(object sender, EventArgs e)
        {
            ykocik -= 5;

            if (((xkocik - rozptyl) <= Xryba && Xryba <= (xkocik + rozptyl)) && ((ykocik - rozptyl) <= Yryba && Yryba <= (ykocik + rozptyl)))
            {
                pocitadlo++;
                chyt = 1;
            }
            kresliciPlocha.Refresh();


        }

        private void tlacitkoDoprava_Click(object sender, EventArgs e)
        {
            xkocik += 5;

            if (((xkocik - rozptyl) <= Xryba && Xryba <= (xkocik + rozptyl)) && ((ykocik - rozptyl) <= Yryba && Yryba <= (ykocik + rozptyl)))
            {
                pocitadlo++;
                chyt = 1;
            }
            kresliciPlocha.Refresh();
        }

        private void tlacitkoDolu_Click(object sender, EventArgs e)
        {
            ykocik += 5;

            if (((xkocik - rozptyl) <= Xryba && Xryba <= (xkocik + rozptyl)) && ((ykocik - rozptyl) <= Yryba && Yryba <= (ykocik + rozptyl)))
            {
                pocitadlo++;
                chyt = 1;
            }
            kresliciPlocha.Refresh();
        }

        private void tlacitkoLeva_Click(object sender, EventArgs e)
        {
            xkocik -= 5;

            if (((xkocik - rozptyl) <= Xryba && Xryba <= (xkocik + rozptyl)) && ((ykocik - rozptyl) <= Yryba && Yryba <= (ykocik + rozptyl)))
            {
                pocitadlo++;
                chyt = 1;
            }
            kresliciPlocha.Refresh();
        }

        private void kresliciPlocha_Paint(object sender, PaintEventArgs e)
        {
            if (chyt == 0)
            {
                Random rand = new Random();
                int number = rand.Next(1, 4);
                switch (number)
                {
                    case 1:
                        Xryba = Xryba + rybaskok;
                        break;
                    case 2:
                        Yryba = Yryba + rybaskok;
                        break;
                    case 3:
                        Xryba = Xryba - rybaskok;
                        break;
                    case 4:
                        Yryba = Yryba - rybaskok;
                        break;



                }
            }
            else
            {
                Random randx = new Random();
                Xryba = randx.Next(50, 350);
                Yryba = randx.Next(50, 350);
                chyt = 0;
                if (pocitadlo > 100)
                {
                    pocitadlo = 0;
                    MessageBox.Show("LVL UP!");
                    rybaskok = 10;
                }
            }

            if (Xryba > 380)
            {
                Xryba = 380;
            }
            else if (Xryba < 0)
            {
                Xryba = 0;
            }
            else if (Yryba < 0)
            {
                Yryba = 0;
            }
            else if (Yryba > 380)
            {
                Yryba = 380;
            }

            if (xkocik > 380)
            {
                xkocik = 380;
            }
            else if (xkocik < 0)
            {
                xkocik = 0;
            }
            else if (ykocik < 0)
            {
                ykocik = 0;
            }
            else if (ykocik > 380)
            {
                ykocik = 380;
            }

            Graphics kp = e.Graphics;
            kp.DrawImage(obrazek, xkocik, ykocik, sirkakocik, vyskakocik);
            kp.DrawImage(ryba, Xryba, Yryba, sirkaRyba, vyskkaRyba);
            pocitadloRyba.Text = pocitadlo.ToString();
        }


        private void oknoProgramu_Load(object sender, EventArgs e)
        {

        }

        private void pocitadloRyba_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
