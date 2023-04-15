using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSomine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int iSayac = 1,iMaxSayac=16;
        int iYon = 1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // string sDosyaYolu = "resimler\\";
            //switch(iYon)
            // {
            //     case 1: //ileri
            //         iSayac++;
            //         if(iSayac>iMaxSayac)
            //         {
            //             iSayac--;
            //             iYon *= -1;
            //         }
            //         break;
            //     case -1: //geri
            //         iSayac--;
            //         if (iSayac < 1)
            //         {
            //             iSayac++;
            //             iYon *= -1;
            //         }
            //         break;
            // }
            // sDosyaYolu = sDosyaYolu + iSayac.ToString() + ".png";
            // lblAlev.Image = Image.FromFile(sDosyaYolu);

            clsAlev.Hareket(lblAlev);

        }
    }
}
