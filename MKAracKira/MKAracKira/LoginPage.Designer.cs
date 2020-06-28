namespace MKAracKira
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.lblKayitOl = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(356, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(30, 64);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMail.MaxLength = 30;
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(288, 35);
            this.txtMail.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(30, 145);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSifre.MaxLength = 30;
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(288, 35);
            this.txtSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mail Adresinizi Giriniz..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifrenizi Giriniz..";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Indigo;
            this.btnGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGirisYap.Location = new System.Drawing.Point(30, 201);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(142, 41);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblSifremiUnuttum
            // 
            this.lblSifremiUnuttum.AutoSize = true;
            this.lblSifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.lblSifremiUnuttum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSifremiUnuttum.LinkColor = System.Drawing.Color.White;
            this.lblSifremiUnuttum.Location = new System.Drawing.Point(187, 185);
            this.lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            this.lblSifremiUnuttum.Size = new System.Drawing.Size(112, 19);
            this.lblSifremiUnuttum.TabIndex = 4;
            this.lblSifremiUnuttum.TabStop = true;
            this.lblSifremiUnuttum.Text = "Şifreni mi Unuttun ?";
            // 
            // lblKayitOl
            // 
            this.lblKayitOl.AutoSize = true;
            this.lblKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.lblKayitOl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKayitOl.LinkColor = System.Drawing.Color.Black;
            this.lblKayitOl.Location = new System.Drawing.Point(517, 21);
            this.lblKayitOl.Name = "lblKayitOl";
            this.lblKayitOl.Size = new System.Drawing.Size(49, 19);
            this.lblKayitOl.TabIndex = 4;
            this.lblKayitOl.TabStop = true;
            this.lblKayitOl.Text = "Kayıt Ol";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginPage
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 267);
            this.Controls.Add(this.lblKayitOl);
            this.Controls.Add(this.lblSifremiUnuttum);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.LinkLabel lblSifremiUnuttum;
        private System.Windows.Forms.LinkLabel lblKayitOl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

