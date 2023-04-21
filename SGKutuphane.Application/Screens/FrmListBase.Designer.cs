namespace SGKutuphane.Application.Screens
{
    partial class FrmListBase<T>
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
            this.dgData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnYeniKayıt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKaydıSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgData.Location = new System.Drawing.Point(0, 0);
            this.dgData.MultiSelect = false;
            this.dgData.Name = "dgData";
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(800, 404);
            this.dgData.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnYeniKayıt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnDüzenle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnKaydıSil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 46);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(500, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 46);
            this.panel4.TabIndex = 5;
            // 
            // btnYeniKayıt
            // 
            this.btnYeniKayıt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYeniKayıt.Location = new System.Drawing.Point(525, 0);
            this.btnYeniKayıt.Name = "btnYeniKayıt";
            this.btnYeniKayıt.Size = new System.Drawing.Size(75, 46);
            this.btnYeniKayıt.TabIndex = 4;
            this.btnYeniKayıt.Text = "Yeni Kayıt";
            this.btnYeniKayıt.UseVisualStyleBackColor = true;
            this.btnYeniKayıt.Click += new System.EventHandler(this.btnYeniKayıt_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(600, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 46);
            this.panel3.TabIndex = 3;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDüzenle.Location = new System.Drawing.Point(625, 0);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 46);
            this.btnDüzenle.TabIndex = 2;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(700, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 46);
            this.panel2.TabIndex = 1;
            // 
            // btnKaydıSil
            // 
            this.btnKaydıSil.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKaydıSil.Location = new System.Drawing.Point(725, 0);
            this.btnKaydıSil.Name = "btnKaydıSil";
            this.btnKaydıSil.Size = new System.Drawing.Size(75, 46);
            this.btnKaydıSil.TabIndex = 0;
            this.btnKaydıSil.Text = "Kaydı Sil";
            this.btnKaydıSil.UseVisualStyleBackColor = true;
            this.btnKaydıSil.Click += new System.EventHandler(this.btnKaydıSil_Click);
            // 
            // FrmListBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.panel1);
            this.Name = "FrmListBase";
            this.Text = "FrmListBase";
            this.Load += new System.EventHandler(this.FrmListBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnYeniKayıt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKaydıSil;
    }
}