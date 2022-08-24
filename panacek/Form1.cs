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
    {
        int xkocik = 100;
        int ykocik = 100;
        int sirkakocik = 40;
        int vyskakocik = 50;
        Image obrazek = Properties.Resources.kocik;

        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlacitkoNahoru_Click(object sender, EventArgs e)
        {
            ykocik -= 5;
            kresliciPlocha.Refresh();
        }

        private void tlacitkoDoprava_Click(object sender, EventArgs e)
        {
            xkocik += 5;
            kresliciPlocha.Refresh();
        }

        private void tlacitkoDolu_Click(object sender, EventArgs e)
        {
            ykocik+= 5;
            kresliciPlocha.Refresh();
        }

        private void tlacitkoLeva_Click(object sender, EventArgs e)
        {
            xkocik-= 5;
            kresliciPlocha.Refresh();
        }

        private void kresliciPlocha_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            kp.DrawImage(obrazek, xkocik, ykocik, sirkakocik,vyskakocik);
        }

        private void oknoProgramu_Load(object sender, EventArgs e)
        {

        }
    }
}
