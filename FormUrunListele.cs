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
    public partial class FormUrunListele : Form
    {
        public FormUrunListele()
        {
            InitializeComponent();
            FormUrunEkle.UrunEkledim += UrunlerdeDegisiklikYapilirsaGuncelle;
        }

        private void UrunlerdeDegisiklikYapilirsaGuncelle(object sender, EventArgs e)
        {
            UrunlerListesiniYukle();
        }

        private void UrunlerListesiniYukle()
        {
            lstUrunler.Items.Clear();
            foreach (var urun in Db_Context.Urunler)
            {
                string[] gosterilecekVeriler =
                {
                    urun.Barkod,
                    urun.UrunAdi,
                    urun.UrunFiyati+" TL",
                    urun.UrunAdeti.ToString()
                };
                ListViewItem satir = new ListViewItem(gosterilecekVeriler);
                satir.Tag = urun;
                lstUrunler.Items.Add(satir);
            }
        }

        private void FormUrunListele_Load(object sender, EventArgs e)
        {
            UrunlerListesiniYukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormUrunEkle frm = new FormUrunEkle();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Önce silinecek veri seçilmelidir.");
                return;
            }
            ListViewItem secilmis = lstUrunler.SelectedItems[0];
            Urun urun = (Urun)secilmis.Tag;

            DialogResult result = MessageBox.Show(urun.UrunAdi + " adındaki ürün silinecektir. Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }
            try
            {
                Db_Context.Urunler.Remove(urun);
                UrunlerListesiniYukle();
                MessageBox.Show("Silme işlemi başarı ile tamamlanmıştır.");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata nedeniyle silme işlemi yapılamamıştır.");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Önce güncellenecek veri seçilmelidir.");
                return;
            }
            ListViewItem secilmis = lstUrunler.SelectedItems[0];
            Urun urun = (Urun)secilmis.Tag;

            FormUrunGuncelle frm = new FormUrunGuncelle(urun);
            frm.MdiParent = this.MdiParent;
            frm.UrunGuncellendi += UrunlerdeDegisiklikYapilirsaGuncelle;
            this.FormClosed += frm.FormuKapat;
            frm.Show();
        }

        private void lstUrunler_DoubleClick(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Detay görünüm için bir satır seçmelisiniz.");
                return;
            }
            ListViewItem secilmis = lstUrunler.SelectedItems[0];
            Urun urun = (Urun)secilmis.Tag;

            FormUrunDetay frm = new FormUrunDetay(urun);
            this.FormClosed += frm.FormuKapat;
            frm.MdiParent = MdiParent;
            frm.Show();
        }
    }
}
