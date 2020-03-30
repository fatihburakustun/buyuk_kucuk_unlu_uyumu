using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Buyuk_Kucuk_Kontrol
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        public static int tut;
        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (rdg1.SelectedIndex==0)
            {
                tut = 1;
            }
            else if (rdg1.SelectedIndex==1)
            {
                tut = 2;
            }
            else
            {
                tut = 3;
            }
            FrmKontrol frm = new FrmKontrol();
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}