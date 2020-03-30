using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Buyuk_Kucuk_Kontrol
{
    public partial class FrmKontrol : Form
    {
        public FrmKontrol()
        {
            InitializeComponent();
        }
        KontrolMekanizmasi kntrl = new KontrolMekanizmasi();
        bool donenSncByk,donenSncKck;
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            if (FrmGiris.tut==1)
            {
                donenSncByk = kntrl.BuyukKontrol(txtKelime.Text);
                if (donenSncByk == true)
                {
                    pcbBykK.Image = Buyuk_Kucuk_Kontrol.Properties.Resources.True;
                }
                else
                {
                    pcbBykK.Image = Buyuk_Kucuk_Kontrol.Properties.Resources.False;
                }
            }
            else if (FrmGiris.tut==2)
            {
               donenSncKck= kntrl.KucukKontrol(txtKelime.Text);
               if (donenSncKck==true)
               {
                   pcbKckK.Image = Buyuk_Kucuk_Kontrol.Properties.Resources.True;
               }
               else
               {
                   pcbKckK.Image = Buyuk_Kucuk_Kontrol.Properties.Resources.False;
               }
            }
            else
            {
                donenSncByk = kntrl.BuyukKontrol(txtKelime.Text);
                if (donenSncByk == true)
                {
                    pcbBykK.Image = Buyuk_Kucuk_Kontrol.Properties.Resources.True;
                }
                else
                {
                    pcbBykK.Image = Buyuk_Kucuk_Kontrol.Properties.Resources.False;
                }
                donenSncKck = kntrl.KucukKontrol(txtKelime.Text);
                if (donenSncKck == true)
                {
                    pcbKckK.Image = Buyuk_Kucuk_Kontrol.Properties.Resources.True;
                }
                else
                {
                    pcbKckK.Image = Buyuk_Kucuk_Kontrol.Properties.Resources.False;
                }
            }
            
            
        }
    }
}