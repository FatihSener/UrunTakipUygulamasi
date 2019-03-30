namespace _08_MDIForm
{
    partial class FormUrunGuncelle
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.nudUrunAdeti = new System.Windows.Forms.NumericUpDown();
            this.lblUrunAdeti = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdeti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(157, 151);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 36);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // nudUrunAdeti
            // 
            this.nudUrunAdeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUrunAdeti.Location = new System.Drawing.Point(110, 110);
            this.nudUrunAdeti.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUrunAdeti.Name = "nudUrunAdeti";
            this.nudUrunAdeti.Size = new System.Drawing.Size(180, 26);
            this.nudUrunAdeti.TabIndex = 12;
            // 
            // lblUrunAdeti
            // 
            this.lblUrunAdeti.AutoSize = true;
            this.lblUrunAdeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunAdeti.Location = new System.Drawing.Point(9, 111);
            this.lblUrunAdeti.Name = "lblUrunAdeti";
            this.lblUrunAdeti.Size = new System.Drawing.Size(85, 20);
            this.lblUrunAdeti.TabIndex = 7;
            this.lblUrunAdeti.Text = "Ürün Adeti";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirim.Location = new System.Drawing.Point(263, 79);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(27, 20);
            this.lblBirim.TabIndex = 8;
            this.lblBirim.Text = "TL";
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunFiyati.Location = new System.Drawing.Point(9, 79);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(85, 20);
            this.lblUrunFiyati.TabIndex = 9;
            this.lblUrunFiyati.Text = "Ürün Fiyatı";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarkod.Location = new System.Drawing.Point(9, 47);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(60, 20);
            this.lblBarkod.TabIndex = 10;
            this.lblBarkod.Text = "Barkod";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunAdi.Location = new System.Drawing.Point(9, 15);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(71, 20);
            this.lblUrunAdi.TabIndex = 11;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunFiyati.Location = new System.Drawing.Point(110, 76);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(147, 26);
            this.txtUrunFiyati.TabIndex = 4;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Enabled = false;
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkod.Location = new System.Drawing.Point(110, 44);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(180, 26);
            this.txtBarkod.TabIndex = 5;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Enabled = false;
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunAdi.Location = new System.Drawing.Point(110, 12);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(180, 26);
            this.txtUrunAdi.TabIndex = 6;
            // 
            // FormUrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 203);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.nudUrunAdeti);
            this.Controls.Add(this.lblUrunAdeti);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.lblUrunFiyati);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtUrunAdi);
            this.Name = "FormUrunGuncelle";
            this.Text = "Ürün Güncelleme";
            this.Load += new System.EventHandler(this.FormUrunGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.NumericUpDown nudUrunAdeti;
        private System.Windows.Forms.Label lblUrunAdeti;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblUrunFiyati;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtUrunAdi;
    }
}