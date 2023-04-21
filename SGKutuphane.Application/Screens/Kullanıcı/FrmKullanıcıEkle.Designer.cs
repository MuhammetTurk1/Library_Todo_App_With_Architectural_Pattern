namespace SGKutuphane.Application.Screens.Kullanıcı
{
    partial class FrmKullanıcıEkle
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
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Soyadı = new System.Windows.Forms.Label();
            this.Adi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(110, 125);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(146, 20);
            this.txtSifre.TabIndex = 9;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(110, 89);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(146, 20);
            this.txtSoyadı.TabIndex = 10;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(110, 56);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(146, 20);
            this.txtAdi.TabIndex = 11;
            // 
            // txtKullanıcıAdi
            // 
            this.txtKullanıcıAdi.Location = new System.Drawing.Point(110, 22);
            this.txtKullanıcıAdi.Name = "txtKullanıcıAdi";
            this.txtKullanıcıAdi.Size = new System.Drawing.Size(146, 20);
            this.txtKullanıcıAdi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sifre";
            // 
            // Soyadı
            // 
            this.Soyadı.AutoSize = true;
            this.Soyadı.Location = new System.Drawing.Point(16, 92);
            this.Soyadı.Name = "Soyadı";
            this.Soyadı.Size = new System.Drawing.Size(39, 13);
            this.Soyadı.TabIndex = 6;
            this.Soyadı.Text = "Soyadı";
            // 
            // Adi
            // 
            this.Adi.AutoSize = true;
            this.Adi.Location = new System.Drawing.Point(16, 59);
            this.Adi.Name = "Adi";
            this.Adi.Size = new System.Drawing.Size(22, 13);
            this.Adi.TabIndex = 7;
            this.Adi.Text = "Adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "KullanıcıAdi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(181, 162);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmKullanıcıEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 195);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtKullanıcıAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Soyadı);
            this.Controls.Add(this.Adi);
            this.Controls.Add(this.label1);
            this.Name = "FrmKullanıcıEkle";
            this.Text = "FrmKullanıcıEkle";
            this.Load += new System.EventHandler(this.FrmKullanıcıEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyadı;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtKullanıcıAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Soyadı;
        private System.Windows.Forms.Label Adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
    }
}