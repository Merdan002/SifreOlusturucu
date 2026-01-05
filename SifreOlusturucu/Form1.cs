
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreOlusturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            string harf = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string rakam = "0123456789";
            string sembol = "!@#$%^&*";

            string tumKarakterler = "";

            if (chkHarf.Checked) tumKarakterler += harf;
            if (chkRakam.Checked) tumKarakterler += rakam;
            if (chkSembol.Checked) tumKarakterler += sembol;

            if (tumKarakterler == "")
            {
                MessageBox.Show("En az bir seçenek seç!");
                return;
            }

            Random rnd = new Random();
            string sifre = "";

            for (int i = 0; i < numUzunluk.Value; i++)
            {
                int index = rnd.Next(tumKarakterler.Length);
                sifre += tumKarakterler[index];
            }

            txtSifre.Text = sifre;
        }

        
    }
}
