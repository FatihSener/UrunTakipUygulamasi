namespace _08_MDIForm
{
    partial class FormAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifFormuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümFormlarıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.listelemeToolStripMenuItem,
            this.sayfaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunEkleToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.urunEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // listelemeToolStripMenuItem
            // 
            this.listelemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunleriListeleToolStripMenuItem});
            this.listelemeToolStripMenuItem.Name = "listelemeToolStripMenuItem";
            this.listelemeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.listelemeToolStripMenuItem.Text = "Listeleme";
            // 
            // urunleriListeleToolStripMenuItem
            // 
            this.urunleriListeleToolStripMenuItem.Name = "urunleriListeleToolStripMenuItem";
            this.urunleriListeleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.urunleriListeleToolStripMenuItem.Text = "Ürünleri Listele";
            this.urunleriListeleToolStripMenuItem.Click += new System.EventHandler(this.urunleriListeleToolStripMenuItem_Click);
            // 
            // sayfaİşlemleriToolStripMenuItem
            // 
            this.sayfaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktifFormuKapatToolStripMenuItem,
            this.tümFormlarıKapatToolStripMenuItem});
            this.sayfaİşlemleriToolStripMenuItem.Name = "sayfaİşlemleriToolStripMenuItem";
            this.sayfaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.sayfaİşlemleriToolStripMenuItem.Text = "Sayfa İşlemleri";
            // 
            // aktifFormuKapatToolStripMenuItem
            // 
            this.aktifFormuKapatToolStripMenuItem.Name = "aktifFormuKapatToolStripMenuItem";
            this.aktifFormuKapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.aktifFormuKapatToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.aktifFormuKapatToolStripMenuItem.Text = "Aktif Formu Kapat";
            this.aktifFormuKapatToolStripMenuItem.Click += new System.EventHandler(this.aktifFormuKapatToolStripMenuItem_Click);
            // 
            // tümFormlarıKapatToolStripMenuItem
            // 
            this.tümFormlarıKapatToolStripMenuItem.Name = "tümFormlarıKapatToolStripMenuItem";
            this.tümFormlarıKapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tümFormlarıKapatToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.tümFormlarıKapatToolStripMenuItem.Text = "Tüm Formları Kapat";
            this.tümFormlarıKapatToolStripMenuItem.Click += new System.EventHandler(this.tümFormlarıKapatToolStripMenuItem_Click);
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAnaSayfa";
            this.Text = "Ürün Takip Uygulaması";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktifFormuKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümFormlarıKapatToolStripMenuItem;
    }
}

