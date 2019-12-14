namespace DentistApp
{
    partial class YeniHastaKaydi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniHastaKaydi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtYeniHastaDogumTarihi = new MetroFramework.Controls.MetroDateTime();
            this.mcYeniHastaKanGrubu = new MetroFramework.Controls.MetroComboBox();
            this.txtYeniHastaKayitNotlar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskYeniHastaTcNo = new System.Windows.Forms.MaskedTextBox();
            this.mskYeniHastaTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtYeniHastaSoyad = new System.Windows.Forms.TextBox();
            this.txtYeniHastaEmail = new System.Windows.Forms.TextBox();
            this.txtYeniHastaAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniHastaKaydet = new System.Windows.Forms.Button();
            this.bosAdHata = new System.Windows.Forms.ErrorProvider(this.components);
            this.bosSoyadHata = new System.Windows.Forms.ErrorProvider(this.components);
            this.bosTcHata = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcNoEksikFazlaHata = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosAdHata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosSoyadHata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTcHata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcNoEksikFazlaHata)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroPanel1);
            this.groupBox1.Controls.Add(this.dtYeniHastaDogumTarihi);
            this.groupBox1.Controls.Add(this.mcYeniHastaKanGrubu);
            this.groupBox1.Controls.Add(this.txtYeniHastaKayitNotlar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mskYeniHastaTcNo);
            this.groupBox1.Controls.Add(this.mskYeniHastaTelefon);
            this.groupBox1.Controls.Add(this.txtYeniHastaSoyad);
            this.groupBox1.Controls.Add(this.txtYeniHastaEmail);
            this.groupBox1.Controls.Add(this.txtYeniHastaAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(791, 345);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Kişisel Bilgileri";
            // 
            // dtYeniHastaDogumTarihi
            // 
            this.dtYeniHastaDogumTarihi.Location = new System.Drawing.Point(146, 167);
            this.dtYeniHastaDogumTarihi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtYeniHastaDogumTarihi.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtYeniHastaDogumTarihi.Name = "dtYeniHastaDogumTarihi";
            this.dtYeniHastaDogumTarihi.Size = new System.Drawing.Size(247, 29);
            this.dtYeniHastaDogumTarihi.TabIndex = 2;
            this.dtYeniHastaDogumTarihi.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // mcYeniHastaKanGrubu
            // 
            this.mcYeniHastaKanGrubu.FormattingEnabled = true;
            this.mcYeniHastaKanGrubu.ItemHeight = 23;
            this.mcYeniHastaKanGrubu.Items.AddRange(new object[] {
            "Arh+",
            "Arh-",
            "Brh+",
            "Brh-",
            "ABrh+",
            "ABrh-",
            "0rh+",
            "0rh-"});
            this.mcYeniHastaKanGrubu.Location = new System.Drawing.Point(575, 134);
            this.mcYeniHastaKanGrubu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcYeniHastaKanGrubu.Name = "mcYeniHastaKanGrubu";
            this.mcYeniHastaKanGrubu.Size = new System.Drawing.Size(189, 29);
            this.mcYeniHastaKanGrubu.TabIndex = 19;
            this.mcYeniHastaKanGrubu.UseSelectable = true;
            // 
            // txtYeniHastaKayitNotlar
            // 
            this.txtYeniHastaKayitNotlar.Font = new System.Drawing.Font("Aliquam", 10F);
            this.txtYeniHastaKayitNotlar.Location = new System.Drawing.Point(575, 180);
            this.txtYeniHastaKayitNotlar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtYeniHastaKayitNotlar.Multiline = true;
            this.txtYeniHastaKayitNotlar.Name = "txtYeniHastaKayitNotlar";
            this.txtYeniHastaKayitNotlar.Size = new System.Drawing.Size(189, 125);
            this.txtYeniHastaKayitNotlar.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Aliquam", 10F);
            this.label9.Location = new System.Drawing.Point(487, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Notlar: ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Aliquam", 10F);
            this.radioButton1.Location = new System.Drawing.Point(262, 16);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 21);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Erkek";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Aliquam", 10F);
            this.radioButton2.Location = new System.Drawing.Point(138, 16);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 21);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kadın";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Aliquam", 10F);
            this.label10.Location = new System.Drawing.Point(40, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cinsiyet: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Aliquam", 10F);
            this.label11.Location = new System.Drawing.Point(461, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Kan Grubu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aliquam", 10F);
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doğum Tarihi: ";
            // 
            // mskYeniHastaTcNo
            // 
            this.mskYeniHastaTcNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskYeniHastaTcNo.BeepOnError = true;
            this.mskYeniHastaTcNo.Font = new System.Drawing.Font("Aliquam", 10F);
            this.mskYeniHastaTcNo.Location = new System.Drawing.Point(146, 251);
            this.mskYeniHastaTcNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mskYeniHastaTcNo.Mask = "00000000000";
            this.mskYeniHastaTcNo.Name = "mskYeniHastaTcNo";
            this.mskYeniHastaTcNo.ResetOnSpace = false;
            this.mskYeniHastaTcNo.Size = new System.Drawing.Size(183, 23);
            this.mskYeniHastaTcNo.TabIndex = 4;
            // 
            // mskYeniHastaTelefon
            // 
            this.mskYeniHastaTelefon.BeepOnError = true;
            this.mskYeniHastaTelefon.Font = new System.Drawing.Font("Aliquam", 10F);
            this.mskYeniHastaTelefon.Location = new System.Drawing.Point(146, 212);
            this.mskYeniHastaTelefon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mskYeniHastaTelefon.Mask = "(000) 000 00 00";
            this.mskYeniHastaTelefon.Name = "mskYeniHastaTelefon";
            this.mskYeniHastaTelefon.Size = new System.Drawing.Size(247, 23);
            this.mskYeniHastaTelefon.TabIndex = 3;
            // 
            // txtYeniHastaSoyad
            // 
            this.txtYeniHastaSoyad.Font = new System.Drawing.Font("Aliquam", 10F);
            this.txtYeniHastaSoyad.Location = new System.Drawing.Point(146, 132);
            this.txtYeniHastaSoyad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtYeniHastaSoyad.Name = "txtYeniHastaSoyad";
            this.txtYeniHastaSoyad.Size = new System.Drawing.Size(247, 23);
            this.txtYeniHastaSoyad.TabIndex = 1;
            // 
            // txtYeniHastaEmail
            // 
            this.txtYeniHastaEmail.Font = new System.Drawing.Font("Aliquam", 10F);
            this.txtYeniHastaEmail.Location = new System.Drawing.Point(146, 289);
            this.txtYeniHastaEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtYeniHastaEmail.Name = "txtYeniHastaEmail";
            this.txtYeniHastaEmail.Size = new System.Drawing.Size(247, 23);
            this.txtYeniHastaEmail.TabIndex = 5;
            // 
            // txtYeniHastaAd
            // 
            this.txtYeniHastaAd.Font = new System.Drawing.Font("Aliquam", 10F);
            this.txtYeniHastaAd.Location = new System.Drawing.Point(146, 92);
            this.txtYeniHastaAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtYeniHastaAd.Name = "txtYeniHastaAd";
            this.txtYeniHastaAd.Size = new System.Drawing.Size(247, 23);
            this.txtYeniHastaAd.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aliquam", 10F);
            this.label4.Location = new System.Drawing.Point(13, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "T.C. Kimlik No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aliquam", 10F);
            this.label3.Location = new System.Drawing.Point(46, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aliquam", 10F);
            this.label2.Location = new System.Drawing.Point(52, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Aliquam", 10F);
            this.label8.Location = new System.Drawing.Point(63, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aliquam", 10F);
            this.label1.Location = new System.Drawing.Point(73, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad: ";
            // 
            // btnYeniHastaKaydet
            // 
            this.btnYeniHastaKaydet.Font = new System.Drawing.Font("Aliquam", 10F);
            this.btnYeniHastaKaydet.Location = new System.Drawing.Point(571, 434);
            this.btnYeniHastaKaydet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnYeniHastaKaydet.Name = "btnYeniHastaKaydet";
            this.btnYeniHastaKaydet.Size = new System.Drawing.Size(247, 50);
            this.btnYeniHastaKaydet.TabIndex = 0;
            this.btnYeniHastaKaydet.Text = "Kaydet";
            this.btnYeniHastaKaydet.UseVisualStyleBackColor = true;
            this.btnYeniHastaKaydet.Click += new System.EventHandler(this.btnYeniHastaKaydet_Click);
            // 
            // bosAdHata
            // 
            this.bosAdHata.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.bosAdHata.ContainerControl = this;
            this.bosAdHata.Icon = ((System.Drawing.Icon)(resources.GetObject("bosAdHata.Icon")));
            // 
            // bosSoyadHata
            // 
            this.bosSoyadHata.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.bosSoyadHata.ContainerControl = this;
            this.bosSoyadHata.Icon = ((System.Drawing.Icon)(resources.GetObject("bosSoyadHata.Icon")));
            // 
            // bosTcHata
            // 
            this.bosTcHata.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.bosTcHata.ContainerControl = this;
            this.bosTcHata.Icon = ((System.Drawing.Icon)(resources.GetObject("bosTcHata.Icon")));
            // 
            // tcNoEksikFazlaHata
            // 
            this.tcNoEksikFazlaHata.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.tcNoEksikFazlaHata.ContainerControl = this;
            this.tcNoEksikFazlaHata.Icon = ((System.Drawing.Icon)(resources.GetObject("tcNoEksikFazlaHata.Icon")));
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.radioButton1);
            this.metroPanel1.Controls.Add(this.radioButton2);
            this.metroPanel1.Controls.Add(this.label10);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(437, 79);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(337, 53);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // YeniHastaKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnYeniHastaKaydet);
            this.Font = new System.Drawing.Font("Aliquam", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "YeniHastaKaydi";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Yeni Hasta Kaydı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosAdHata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosSoyadHata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTcHata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcNoEksikFazlaHata)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYeniHastaKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskYeniHastaTcNo;
        private System.Windows.Forms.MaskedTextBox mskYeniHastaTelefon;
        private System.Windows.Forms.TextBox txtYeniHastaSoyad;
        private System.Windows.Forms.TextBox txtYeniHastaAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ErrorProvider bosAdHata;
        public System.Windows.Forms.ErrorProvider bosSoyadHata;
        public System.Windows.Forms.ErrorProvider bosTcHata;
        public System.Windows.Forms.ErrorProvider tcNoEksikFazlaHata;
        private System.Windows.Forms.TextBox txtYeniHastaEmail;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroComboBox mcYeniHastaKanGrubu;
        private System.Windows.Forms.TextBox txtYeniHastaKayitNotlar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroDateTime dtYeniHastaDogumTarihi;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}