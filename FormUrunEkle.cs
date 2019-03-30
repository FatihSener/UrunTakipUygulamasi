using _08_MDIForm.Database;
using _08_MDIForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_MDIForm
{
    public partial class FormUrunEkle : Form
    {
        public static event EventHandler UrunEkledim;
        public FormUrunEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ürün eklenecek emin misiniz.", "Dikkat", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }
            Urun urun = new Urun();
            urun.UrunAdi = txtUrunAdi.Text;
            urun.Barkod = txtBarkod.Text;
            urun.UrunFiyati = double.Parse(txtUrunFiyati.Text);
            urun.UrunAdeti = (int)nudUrunAdeti.Value;
            Db_Context.Urunler.Add(urun);
            if (UrunEkledim != null)
            {
                UrunEkledim(this, EventArgs.Empty);
            }
            MessageBox.Show("Ürün ekleme işlemi başarıyla tamamlanmıştır.");
            Helper.ControlTemizle(this);
        }
    }
}
