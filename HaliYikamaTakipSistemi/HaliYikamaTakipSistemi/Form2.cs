using HaliYikamaTakipSistemi.HaliYikamaTakipSistemi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliYikamaTakipSistemi
{
    public partial class Form2 : Form
    {
        private List<Musteri> musteriler = new List<Musteri>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Adres = txtAdres.Text
            };

            musteriler.Add(m);
            lstMusteriler.Items.Add(m); // ToString() override sayesinde düzgün görünür

            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
        }

        private void lstMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
