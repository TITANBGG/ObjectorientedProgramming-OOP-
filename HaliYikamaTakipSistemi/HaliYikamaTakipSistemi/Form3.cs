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


    public partial class FormDurumTakip : Form
    {
        private Musteri musteri;

        // Constructor - Form2'den müşteri nesnesi alınır
        public FormDurumTakip(Musteri seciliMusteri)
        {
            InitializeComponent();
            this.musteri = seciliMusteri;
            HalilariYukle();
        }



        private void HalilariYukle()
        {
            lstHalilar.Items.Clear();

            foreach (var hali in musteri.Halilar)
            {
                lstHalilar.Items.Add(hali); // Hali sınıfında ToString() override edilmiş olmalı
            }
        }




        private void btnDurumGuncelleme_Click(object sender, EventArgs e)
        {
            if (lstHalilar.SelectedItem is Hali seciliHali)
            {
                seciliHali.TeslimEdildi = true;
                MessageBox.Show("Halı durumu güncellendi!");
                HalilariYukle(); // Listeyi tazele
            }
            else
            {
                MessageBox.Show("Lütfen bir halı seçin.");
            }
        }

        private void btnYikamada_Click(object sender, EventArgs e)
        {
            lstHalilar.Items.Clear();
            foreach (var hali in musteri.Halilar)
            {
                if (!hali.TeslimEdildi)
                    lstHalilar.Items.Add(hali);
            }
        }

        private void btnTeslimEdilen_Click(object sender, EventArgs e)
        {
            lstHalilar.Items.Clear();
            foreach (var hali in musteri.Halilar)
            {
                if (hali.TeslimEdildi)
                    lstHalilar.Items.Add(hali);
            }
        }
    }
}
    





 