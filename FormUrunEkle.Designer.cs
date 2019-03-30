namespace _08_MDIForm
{
    partial class FormUrunEkle
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
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.lblUrunAdeti = new System.Windows.Forms.Label();
            this.nudUrunAdeti = new System.Windows.Forms.NumericUpDown();
            this.lblBirim = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdeti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunAdi.Location = new System.Drawing.Point(113, 18);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(180, 26);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunAdi.Location = new System.Drawing.Point(12, 21);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(71, 20);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkod.Location = new System.Drawing.Point(113, 50);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(180, 26);
            this.txtBarkod.TabIndex = 0;
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarkod.Location = new System.Drawing.Point(12, 53);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(60, 20);
            this.lblBarkod.TabIndex = 1;
            this.lblBarkod.Text = "Barkod";
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunFiyati.Location = new System.Drawing.Point(113, 82);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(147, 26);
            this.txtUrunFiyati.TabIndex = 0;
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunFiyati.Location = new System.Drawing.Point(12, 85);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(85, 20);
            this.lblUrunFiyati.TabIndex = 1;
            this.lblUrunFiyati.Text = "Ürün Fiyatı";
            // 
            // lblUrunAdeti
            // 
            this.lblUrunAdeti.AutoSize = true;
            this.lblUrunAdeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunAdeti.Location = new System.Drawing.Point(12, 117);
            this.lblUrunAdeti.Name = "lblUrunAdeti";
            this.lblUrunAdeti.Size = new System.Drawing.Size(85, 20);
            this.lblUrunAdeti.TabIndex = 1;
            this.lblUrunAdeti.Text = "Ürün Adeti";
            // 
            // nudUrunAdeti
            // 
            this.nudUrunAdeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUrunAdeti.Location = new System.Drawing.Point(113, 116);
            this.nudUrunAdeti.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUrunAdeti.Name = "nudUrunAdeti";
            this.nudUrunAdeti.Size = new System.Drawing.Size(180, 26);
            this.nudUrunAdeti.TabIndex = 2;
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirim.Location = new System.Drawing.Point(266, 85);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(27, 20);
            this.lblBirim.TabIndex = 1;
            this.lblBirim.Text = "TL";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(160, 157);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 36);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FormUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 207);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudUrunAdeti);
            this.Controls.Add(this.lblUrunAdeti);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.lblUrunFiyati);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtUrunAdi);
            this.Name = "FormUrunEkle";
            this.Text = "Ürün Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.Label lblUrunFiyati;
        private System.Windows.Forms.Label lblUrunAdeti;
        private System.Windows.Forms.NumericUpDown nudUrunAdeti;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Button btnEkle;
    }
}