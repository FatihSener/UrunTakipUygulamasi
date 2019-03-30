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
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunEkle frm = new FormUrunEkle();
            frm.MdiParent = this;        
            frm.Show();
        }

        private void urunleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunListele frm = new FormUrunListele();
            frm.MdiParent = this;
            frm.Show();       
        }

        private void aktifFormuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            //formu yakaladıysak form ile ilgili herşeyi yapabiliriz.
            frm.Close();
        }

        private void tümFormlarıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form[] ChildFormlar= this.MdiChildren;
            foreach (var item in ChildFormlar)
            {
                item.Close();
            }
        }
    }
}
