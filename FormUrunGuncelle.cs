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
    public partial class FormUrunGuncelle : Form
    {
        Urun _urun;
        public EventHandler UrunGuncellendi;
        public FormUrunGuncelle(Urun urun)
        {
            _urun = urun;
            InitializeComponent();
        }

        private void FormUrunGuncelle_Load(object sender, EventArgs e)
        {
            txtBarkod.Text = _urun.Barkod;
            txtUrunAdi.Text = _urun.UrunAdi;
            txtUrunFiyati.Text = _urun.UrunFiyati.ToString();
            nudUrunAdeti.Value = _urun.UrunAdeti;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //validationlar uygulandı
            DialogResult result = MessageBox.Show("Güncelleme yapmak istediğinize emin misiniz?","Ammannn",MessageBoxButtons.YesNo);
            if(result!=DialogResult.Yes)
            {
                return;
            }

            try
            {
                _urun.UrunAdeti = (int)nudUrunAdeti.Value;
                _urun.UrunFiyati =double.Parse(txtUrunFiyati.Text);
                UrunGuncellendi(this, EventArgs.Empty);
                MessageBox.Show("Güncelleme işlemi başarılı olmuştur.");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata nedeniyle işlem yapılamamıştır.");
            }
        }

        public void FormuKapat(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
