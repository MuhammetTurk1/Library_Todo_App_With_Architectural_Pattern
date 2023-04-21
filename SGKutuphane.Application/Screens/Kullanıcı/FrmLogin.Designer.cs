namespace SGKutuphane.Application.Screens.Kullanıcı
{
    partial class FrmLogin
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
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.txt_Şifre = new System.Windows.Forms.TextBox();
            this.chk_BenıUnutma = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Location = new System.Drawing.Point(12, 12);
            this.txtKullanıcı.Multiline = true;
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(209, 31);
            this.txtKullanıcı.TabIndex = 0;
            // 
            // txt_Şifre
            // 
            this.txt_Şifre.Location = new System.Drawing.Point(12, 49);
            this.txt_Şifre.Multiline = true;
            this.txt_Şifre.Name = "txt_Şifre";
            this.txt_Şifre.Size = new System.Drawing.Size(209, 33);
            this.txt_Şifre.TabIndex = 1;
            // 
            // chk_BenıUnutma
            // 
            this.chk_BenıUnutma.AutoSize = true;
            this.chk_BenıUnutma.Location = new System.Drawing.Point(12, 95);
            this.chk_BenıUnutma.Name = "chk_BenıUnutma";
            this.chk_BenıUnutma.Size = new System.Drawing.Size(87, 17);
            this.chk_BenıUnutma.TabIndex = 2;
            this.chk_BenıUnutma.Text = "Benı Unutma";
            this.chk_BenıUnutma.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(146, 91);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 21);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Giriş Yap";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 124);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.chk_BenıUnutma);
            this.Controls.Add(this.txt_Şifre);
            this.Controls.Add(this.txtKullanıcı);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.TextBox txt_Şifre;
        private System.Windows.Forms.CheckBox chk_BenıUnutma;
        private System.Windows.Forms.Button btn_Login;
    }
}