namespace SGKutuphane.Application.Screens.YayınEvi
{
    partial class FrmYayınEviEkle
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
            this.btnKaydet11 = new System.Windows.Forms.Button();
            this.txtYayınEvi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet11
            // 
            this.btnKaydet11.Location = new System.Drawing.Point(172, 54);
            this.btnKaydet11.Name = "btnKaydet11";
            this.btnKaydet11.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet11.TabIndex = 8;
            this.btnKaydet11.Text = "Kaydet";
            this.btnKaydet11.UseVisualStyleBackColor = true;
            this.btnKaydet11.Click += new System.EventHandler(this.btnKaydet11_Click);
            // 
            // txtYayınEvi
            // 
            this.txtYayınEvi.Location = new System.Drawing.Point(101, 12);
            this.txtYayınEvi.Name = "txtYayınEvi";
            this.txtYayınEvi.Size = new System.Drawing.Size(146, 20);
            this.txtYayınEvi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "YayınEviAdı";
            // 
            // FrmYayınEviEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 96);
            this.Controls.Add(this.btnKaydet11);
            this.Controls.Add(this.txtYayınEvi);
            this.Controls.Add(this.label1);
            this.Name = "FrmYayınEviEkle";
            this.Text = "FrmYayınEviEkle";
            this.Load += new System.EventHandler(this.FrmYayınEviEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet11;
        private System.Windows.Forms.TextBox txtYayınEvi;
        private System.Windows.Forms.Label label1;
    }
}