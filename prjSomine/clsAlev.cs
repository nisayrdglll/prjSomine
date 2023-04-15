using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public static class clsAlev
{
    static int iYon = 1;
    static int iSayac, iMaxSayac = 16;

    public static void Hareket(Label lblAlev)
    {
        string sDosyaYolu = "resimler\\";
        switch (iYon)
        {
            case 1: //ileri
                iSayac++;
                if (iSayac > iMaxSayac)
                {
                    iSayac--;
                    iYon *= -1;
                }
                break;
            case -1: //geri
                iSayac--;
                if (iSayac < 1)
                {
                    iSayac++;
                    iYon *= -1;
                }
                break;
        }
        sDosyaYolu = sDosyaYolu + iSayac.ToString() + ".png";
        lblAlev.Image = Image.FromFile(sDosyaYolu);
    }
}
