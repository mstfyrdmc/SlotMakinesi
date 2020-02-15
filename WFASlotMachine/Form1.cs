using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASlotMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            btnKoluCek.Enabled = true;
            button1.Enabled = false;
            this.BackgroundImage = null;
        }

        private void btnKoluCek_Click(object sender, EventArgs e)
        {
            int resimSec1 = rnd.Next(0, 6);
            int resimSec2 = rnd.Next(0, 6);
            int resimSec3 = rnd.Next(0, 6);
            
            if (sayac >= 10)
            {
                int sayi = rnd.Next(0, 6);
                switch (sayi)
                {
                    case 2:
                        resimSec1 = resimSec2 = resimSec3 = rnd.Next(0,6);
                        sayac = 0;
                        break;
                    default:
                        resimSec1 = rnd.Next(0, 6);
                        resimSec2 = rnd.Next(0, 6);
                        resimSec3 = rnd.Next(0, 6);
                        break;
                }
            }
            switch (resimSec1)
            {
                case 0:
                    pbResim1.Image = Properties.Resources.apple;
                    break;
                case 1:
                    pbResim1.Image = Properties.Resources.avakado;
                    break;
                case 2:
                    pbResim1.Image = Properties.Resources.banana;
                    break;
                case 3:
                    pbResim1.Image = Properties.Resources.berry;
                    break;
                case 4:
                    pbResim1.Image = Properties.Resources.orange;
                    break;
                case 5:
                    pbResim1.Image = Properties.Resources.strawberry;
                    break;
            }
            switch (resimSec2)
            {
                case 0:
                    pbResim2.Image = Properties.Resources.apple;
                    break;
                case 1:
                    pbResim2.Image = Properties.Resources.avakado;
                    break;
                case 2:
                    pbResim2.Image = Properties.Resources.banana;
                    break;
                case 3:
                    pbResim2.Image = Properties.Resources.berry;
                    break;
                case 4:
                    pbResim2.Image = Properties.Resources.orange;
                    break;
                case 5:
                    pbResim2.Image = Properties.Resources.strawberry;
                    break;
            }
            switch (resimSec3)
            {
                case 0:
                    pbResim3.Image = Properties.Resources.apple;
                    break;
                case 1:
                    pbResim3.Image = Properties.Resources.avakado;
                    break;
                case 2:
                    pbResim3.Image = Properties.Resources.banana;
                    break;
                case 3:
                    pbResim3.Image = Properties.Resources.berry;
                    break;
                case 4:
                    pbResim3.Image = Properties.Resources.orange;
                    break;
                case 5:
                    pbResim3.Image = Properties.Resources.strawberry;
                    break;
            }
            button1.Enabled = true;
            btnKoluCek.Enabled = false;
            if (pbResim1.Image == pbResim2.Image & pbResim2.Image == pbResim3.Image)
            {
                this.BackgroundImage = Properties.Resources.havaifisek;
                MessageBox.Show("Kazandınız");
            }
            else
            {
                this.BackgroundImage = Properties.Resources.uzgun;
                MessageBox.Show("Kaybettiniz");
            }
            

        }
    }
}
