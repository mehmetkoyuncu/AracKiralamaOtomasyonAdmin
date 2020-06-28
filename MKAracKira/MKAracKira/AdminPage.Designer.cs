namespace MKAracKira
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.lstArac = new System.Windows.Forms.ListBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pctUrunResim = new System.Windows.Forms.PictureBox();
            this.lblYakitTipi = new System.Windows.Forms.Label();
            this.lblVitesTipi = new System.Windows.Forms.Label();
            this.lblUygunlukDurumu = new System.Windows.Forms.Label();
            this.lblAracSinifi = new System.Windows.Forms.Label();
            this.lblEkOzellikler = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.npmFiyat = new System.Windows.Forms.TextBox();
            this.txtResimText = new System.Windows.Forms.TextBox();
            this.btnResimYukle = new System.Windows.Forms.Button();
            this.rbUygunDegil = new System.Windows.Forms.RadioButton();
            this.rbUygun = new System.Windows.Forms.RadioButton();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbYakitTipi = new System.Windows.Forms.ComboBox();
            this.cmbVitesTipi = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbAracSinifi = new System.Windows.Forms.ComboBox();
            this.txtEkOzellik1 = new System.Windows.Forms.TextBox();
            this.txtEkOzellik2 = new System.Windows.Forms.TextBox();
            this.txtEkOzellik3 = new System.Windows.Forms.TextBox();
            this.txtEkOzellik4 = new System.Windows.Forms.TextBox();
            this.pctDuzenlenecek = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunResim)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDuzenlenecek)).BeginInit();
            this.SuspendLayout();
            // 
            // lstArac
            // 
            this.lstArac.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstArac.FormattingEnabled = true;
            this.lstArac.ItemHeight = 23;
            this.lstArac.Location = new System.Drawing.Point(24, 35);
            this.lstArac.Name = "lstArac";
            this.lstArac.Size = new System.Drawing.Size(271, 487);
            this.lstArac.TabIndex = 0;
            this.lstArac.SelectedIndexChanged += new System.EventHandler(this.lstArac_SelectedIndexChanged);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdSoyad.Location = new System.Drawing.Point(803, 58);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(165, 23);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "ADSoyad";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.pctUrunResim);
            this.groupBox1.Controls.Add(this.lblYakitTipi);
            this.groupBox1.Controls.Add(this.lblVitesTipi);
            this.groupBox1.Controls.Add(this.lblUygunlukDurumu);
            this.groupBox1.Controls.Add(this.lblAracSinifi);
            this.groupBox1.Controls.Add(this.lblEkOzellikler);
            this.groupBox1.Controls.Add(this.lblFiyat);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.lblMarka);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(314, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightCoral;
            this.btnSil.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(579, 234);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(55, 27);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pctUrunResim
            // 
            this.pctUrunResim.Location = new System.Drawing.Point(430, 26);
            this.pctUrunResim.Name = "pctUrunResim";
            this.pctUrunResim.Size = new System.Drawing.Size(206, 195);
            this.pctUrunResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUrunResim.TabIndex = 3;
            this.pctUrunResim.TabStop = false;
            // 
            // lblYakitTipi
            // 
            this.lblYakitTipi.AutoSize = true;
            this.lblYakitTipi.Location = new System.Drawing.Point(309, 184);
            this.lblYakitTipi.Name = "lblYakitTipi";
            this.lblYakitTipi.Size = new System.Drawing.Size(71, 23);
            this.lblYakitTipi.TabIndex = 2;
            this.lblYakitTipi.Text = "Seçilmedi";
            // 
            // lblVitesTipi
            // 
            this.lblVitesTipi.AutoSize = true;
            this.lblVitesTipi.Location = new System.Drawing.Point(309, 134);
            this.lblVitesTipi.Name = "lblVitesTipi";
            this.lblVitesTipi.Size = new System.Drawing.Size(71, 23);
            this.lblVitesTipi.TabIndex = 2;
            this.lblVitesTipi.Text = "Seçilmedi";
            // 
            // lblUygunlukDurumu
            // 
            this.lblUygunlukDurumu.AutoSize = true;
            this.lblUygunlukDurumu.Location = new System.Drawing.Point(309, 90);
            this.lblUygunlukDurumu.Name = "lblUygunlukDurumu";
            this.lblUygunlukDurumu.Size = new System.Drawing.Size(71, 23);
            this.lblUygunlukDurumu.TabIndex = 2;
            this.lblUygunlukDurumu.Text = "Seçilmedi";
            // 
            // lblAracSinifi
            // 
            this.lblAracSinifi.AutoSize = true;
            this.lblAracSinifi.Location = new System.Drawing.Point(309, 46);
            this.lblAracSinifi.Name = "lblAracSinifi";
            this.lblAracSinifi.Size = new System.Drawing.Size(71, 23);
            this.lblAracSinifi.TabIndex = 2;
            this.lblAracSinifi.Text = "Seçilmedi";
            // 
            // lblEkOzellikler
            // 
            this.lblEkOzellikler.AutoSize = true;
            this.lblEkOzellikler.Location = new System.Drawing.Point(187, 232);
            this.lblEkOzellikler.Name = "lblEkOzellikler";
            this.lblEkOzellikler.Size = new System.Drawing.Size(71, 23);
            this.lblEkOzellikler.TabIndex = 2;
            this.lblEkOzellikler.Text = "Seçilmedi";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(84, 184);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(71, 23);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Seçilmedi";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(84, 134);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(71, 23);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Seçilmedi";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(84, 90);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(71, 23);
            this.lblMarka.TabIndex = 2;
            this.lblMarka.Text = "Seçilmedi";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(84, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(71, 23);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Seçilmedi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(212, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Araç Sınıfı : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(84, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ek Özellikler : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(31, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fiyat :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(218, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yakıt Tipi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(221, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vites Tipi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(218, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Uygunluk : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.npmFiyat);
            this.groupBox2.Controls.Add(this.txtResimText);
            this.groupBox2.Controls.Add(this.btnResimYukle);
            this.groupBox2.Controls.Add(this.rbUygunDegil);
            this.groupBox2.Controls.Add(this.rbUygun);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.cmbYakitTipi);
            this.groupBox2.Controls.Add(this.cmbVitesTipi);
            this.groupBox2.Controls.Add(this.cmbMarka);
            this.groupBox2.Controls.Add(this.cmbAracSinifi);
            this.groupBox2.Controls.Add(this.txtEkOzellik1);
            this.groupBox2.Controls.Add(this.txtEkOzellik2);
            this.groupBox2.Controls.Add(this.txtEkOzellik3);
            this.groupBox2.Controls.Add(this.txtEkOzellik4);
            this.groupBox2.Controls.Add(this.pctDuzenlenecek);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(314, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Düzenleme ve Ekleme";
            // 
            // npmFiyat
            // 
            this.npmFiyat.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F);
            this.npmFiyat.Location = new System.Drawing.Point(232, 91);
            this.npmFiyat.Name = "npmFiyat";
            this.npmFiyat.Size = new System.Drawing.Size(121, 23);
            this.npmFiyat.TabIndex = 10;
            // 
            // txtResimText
            // 
            this.txtResimText.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResimText.Location = new System.Drawing.Point(22, 154);
            this.txtResimText.Name = "txtResimText";
            this.txtResimText.Size = new System.Drawing.Size(100, 21);
            this.txtResimText.TabIndex = 9;
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnResimYukle.Location = new System.Drawing.Point(35, 179);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(77, 33);
            this.btnResimYukle.TabIndex = 8;
            this.btnResimYukle.Text = "...";
            this.btnResimYukle.UseVisualStyleBackColor = false;
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // rbUygunDegil
            // 
            this.rbUygunDegil.AutoSize = true;
            this.rbUygunDegil.Location = new System.Drawing.Point(245, 147);
            this.rbUygunDegil.Name = "rbUygunDegil";
            this.rbUygunDegil.Size = new System.Drawing.Size(101, 27);
            this.rbUygunDegil.TabIndex = 7;
            this.rbUygunDegil.TabStop = true;
            this.rbUygunDegil.Text = "Uygun Değil";
            this.rbUygunDegil.UseVisualStyleBackColor = true;
            // 
            // rbUygun
            // 
            this.rbUygun.AutoSize = true;
            this.rbUygun.Location = new System.Drawing.Point(245, 121);
            this.rbUygun.Name = "rbUygun";
            this.rbUygun.Size = new System.Drawing.Size(67, 27);
            this.rbUygun.TabIndex = 7;
            this.rbUygun.TabStop = true;
            this.rbUygun.Text = "Uygun";
            this.rbUygun.UseVisualStyleBackColor = true;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(232, 61);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 23);
            this.txtModel.TabIndex = 6;
            // 
            // cmbYakitTipi
            // 
            this.cmbYakitTipi.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYakitTipi.FormattingEnabled = true;
            this.cmbYakitTipi.Location = new System.Drawing.Point(478, 61);
            this.cmbYakitTipi.Name = "cmbYakitTipi";
            this.cmbYakitTipi.Size = new System.Drawing.Size(156, 24);
            this.cmbYakitTipi.TabIndex = 5;
            // 
            // cmbVitesTipi
            // 
            this.cmbVitesTipi.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbVitesTipi.FormattingEnabled = true;
            this.cmbVitesTipi.Location = new System.Drawing.Point(478, 32);
            this.cmbVitesTipi.Name = "cmbVitesTipi";
            this.cmbVitesTipi.Size = new System.Drawing.Size(156, 24);
            this.cmbVitesTipi.TabIndex = 5;
            // 
            // cmbMarka
            // 
            this.cmbMarka.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(232, 32);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 24);
            this.cmbMarka.TabIndex = 5;
            // 
            // cmbAracSinifi
            // 
            this.cmbAracSinifi.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAracSinifi.FormattingEnabled = true;
            this.cmbAracSinifi.Location = new System.Drawing.Point(231, 180);
            this.cmbAracSinifi.Name = "cmbAracSinifi";
            this.cmbAracSinifi.Size = new System.Drawing.Size(121, 24);
            this.cmbAracSinifi.TabIndex = 4;
            // 
            // txtEkOzellik1
            // 
            this.txtEkOzellik1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkOzellik1.Location = new System.Drawing.Point(478, 92);
            this.txtEkOzellik1.Name = "txtEkOzellik1";
            this.txtEkOzellik1.Size = new System.Drawing.Size(156, 23);
            this.txtEkOzellik1.TabIndex = 2;
            // 
            // txtEkOzellik2
            // 
            this.txtEkOzellik2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkOzellik2.Location = new System.Drawing.Point(478, 122);
            this.txtEkOzellik2.Name = "txtEkOzellik2";
            this.txtEkOzellik2.Size = new System.Drawing.Size(156, 23);
            this.txtEkOzellik2.TabIndex = 2;
            // 
            // txtEkOzellik3
            // 
            this.txtEkOzellik3.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkOzellik3.Location = new System.Drawing.Point(478, 153);
            this.txtEkOzellik3.Name = "txtEkOzellik3";
            this.txtEkOzellik3.Size = new System.Drawing.Size(156, 23);
            this.txtEkOzellik3.TabIndex = 2;
            // 
            // txtEkOzellik4
            // 
            this.txtEkOzellik4.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkOzellik4.Location = new System.Drawing.Point(478, 184);
            this.txtEkOzellik4.Name = "txtEkOzellik4";
            this.txtEkOzellik4.Size = new System.Drawing.Size(156, 23);
            this.txtEkOzellik4.TabIndex = 2;
            // 
            // pctDuzenlenecek
            // 
            this.pctDuzenlenecek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctDuzenlenecek.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.pctDuzenlenecek.Location = new System.Drawing.Point(22, 32);
            this.pctDuzenlenecek.Name = "pctDuzenlenecek";
            this.pctDuzenlenecek.Size = new System.Drawing.Size(100, 116);
            this.pctDuzenlenecek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDuzenlenecek.TabIndex = 0;
            this.pctDuzenlenecek.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(166, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Marka : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(170, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Model : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(179, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Fiyat :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(148, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Uygunluk : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(142, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "Araç Sınıfı : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(387, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "Vites Tipi : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(385, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 23);
            this.label17.TabIndex = 0;
            this.label17.Text = "Yakıt Tipi : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Maroon;
            this.label21.Location = new System.Drawing.Point(365, 184);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 23);
            this.label21.TabIndex = 0;
            this.label21.Text = "Ek Özellikler : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(365, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 23);
            this.label20.TabIndex = 0;
            this.label20.Text = "Ek Özellikler : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Maroon;
            this.label19.Location = new System.Drawing.Point(365, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 23);
            this.label19.TabIndex = 0;
            this.label19.Text = "Ek Özellikler : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Maroon;
            this.label18.Location = new System.Drawing.Point(365, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 23);
            this.label18.TabIndex = 0;
            this.label18.Text = "Ek Özellikler : ";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Orange;
            this.btnEkle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(893, 551);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 32);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnGuncelle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(792, 551);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 32);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 595);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lstArac);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunResim)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDuzenlenecek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstArac;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pctUrunResim;
        private System.Windows.Forms.Label lblYakitTipi;
        private System.Windows.Forms.Label lblVitesTipi;
        private System.Windows.Forms.Label lblUygunlukDurumu;
        private System.Windows.Forms.Label lblAracSinifi;
        private System.Windows.Forms.Label lblEkOzellikler;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pctDuzenlenecek;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton rbUygunDegil;
        private System.Windows.Forms.RadioButton rbUygun;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbYakitTipi;
        private System.Windows.Forms.ComboBox cmbVitesTipi;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbAracSinifi;
        private System.Windows.Forms.TextBox txtEkOzellik1;
        private System.Windows.Forms.TextBox txtEkOzellik2;
        private System.Windows.Forms.TextBox txtEkOzellik3;
        private System.Windows.Forms.TextBox txtEkOzellik4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtResimText;
        private System.Windows.Forms.Button btnResimYukle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox npmFiyat;
    }
}