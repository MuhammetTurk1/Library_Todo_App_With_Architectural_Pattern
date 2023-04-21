namespace SGKutuphane.Application
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sabitlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınEviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğreciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.sabitlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // sabitlerToolStripMenuItem
            // 
            this.sabitlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarlarToolStripMenuItem,
            this.yazarToolStripMenuItem,
            this.yayınEviToolStripMenuItem,
            this.öğreciToolStripMenuItem,
            this.kullanıcıToolStripMenuItem});
            this.sabitlerToolStripMenuItem.Name = "sabitlerToolStripMenuItem";
            this.sabitlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sabitlerToolStripMenuItem.Text = "Sabitler";
            // 
            // yazarlarToolStripMenuItem
            // 
            this.yazarlarToolStripMenuItem.Name = "yazarlarToolStripMenuItem";
            this.yazarlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yazarlarToolStripMenuItem.Text = "Kategori";
            this.yazarlarToolStripMenuItem.Click += new System.EventHandler(this.yazarlarToolStripMenuItem_Click);
            // 
            // yazarToolStripMenuItem
            // 
            this.yazarToolStripMenuItem.Name = "yazarToolStripMenuItem";
            this.yazarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yazarToolStripMenuItem.Text = "Yazar";
            this.yazarToolStripMenuItem.Click += new System.EventHandler(this.yazarToolStripMenuItem_Click);
            // 
            // yayınEviToolStripMenuItem
            // 
            this.yayınEviToolStripMenuItem.Name = "yayınEviToolStripMenuItem";
            this.yayınEviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yayınEviToolStripMenuItem.Text = "YayınEvi";
            this.yayınEviToolStripMenuItem.Click += new System.EventHandler(this.yayınEviToolStripMenuItem_Click);
            // 
            // öğreciToolStripMenuItem
            // 
            this.öğreciToolStripMenuItem.Name = "öğreciToolStripMenuItem";
            this.öğreciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğreciToolStripMenuItem.Text = "Öğreci";
            this.öğreciToolStripMenuItem.Click += new System.EventHandler(this.öğreciToolStripMenuItem_Click);
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            this.kullanıcıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sabitlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yazarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yayınEviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğreciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
    }
}

