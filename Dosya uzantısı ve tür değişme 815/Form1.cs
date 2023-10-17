using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_uzantısı_ve_tür_değişme_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string secim;
            bool cevap1, cevap2;
            secim = lbTur.SelectedItem.ToString();

            cevap1 = rbVideo.Checked;
            cevap2 = rbResim.Checked;

            if (cevap1 == true && (secim == "MP4" || secim == "MOV"))
            {
                MessageBox.Show("Cevabınız doğru.");
            }
            if (cevap1 == false && (secim == "MP4" || secim == "MOV"))
            {
                MessageBox.Show("Cevabınız yanlış");
            }
            if (cevap2 == true && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("Cevabınız doğru.");
            }
            if (cevap2 == false && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("Cevabınız yanlış.");
            }
        }
    }
}
