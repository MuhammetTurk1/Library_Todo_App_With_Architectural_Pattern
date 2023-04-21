namespace SGKutuphane.Application.Screens.Yazar
{
    partial class FrmYazarEkle
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
            this.btnKaydet1 = new System.Windows.Forms.Button();
            this.txtYazar1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet1
            // 
            this.btnKaydet1.Location = new System.Drawing.Point(172, 54);
            this.btnKaydet1.Name = "btnKaydet1";
            this.btnKaydet1.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet1.TabIndex = 5;
            this.btnKaydet1.Text = "Kaydet";
            this.btnKaydet1.UseVisualStyleBackColor = true;
            this.btnKaydet1.Click += new System.EventHandler(this.btnKaydet1_Click);
            // 
            // txtYazar1
            // 
            this.txtYazar1.Location = new System.Drawing.Point(101, 12);
            this.txtYazar1.Name = "txtYazar1";
            this.txtYazar1.Size = new System.Drawing.Size(146, 20);
            this.txtYazar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KategoriAdı";
            // 
            // FrmYazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 89);
            this.Controls.Add(this.btnKaydet1);
            this.Controls.Add(this.txtYazar1);
            this.Controls.Add(this.label1);
            this.Name = "FrmYazarEkle";
            this.Text = "FrmYazarEkle";
            this.Load += new System.EventHandler(this.FrmYazarEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet1;
        private System.Windows.Forms.TextBox txtYazar1;
        private System.Windows.Forms.Label label1;
    }
}