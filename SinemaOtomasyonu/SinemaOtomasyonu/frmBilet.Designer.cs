namespace _19042022_MBSinema_GP3Final_Vize
{
    partial class frmBiletKesim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiletKesim));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcrAfis2 = new System.Windows.Forms.PictureBox();
            this.lblBiletTür = new System.Windows.Forms.Label();
            this.cmbBiletTür = new System.Windows.Forms.ComboBox();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.lblSeans = new System.Windows.Forms.Label();
            this.btnYiyecekIcecek = new System.Windows.Forms.Button();
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.lblSalon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKalanKoltuk = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RdibErkek = new System.Windows.Forms.RadioButton();
            this.RdibKadin = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblToplamtutar = new System.Windows.Forms.Label();
            this.lblYiyecekIcecekTutar = new System.Windows.Forms.Label();
            this.tmrKoltukSayisi = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrAfis2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1789, 932);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pcrAfis2
            // 
            this.pcrAfis2.Image = ((System.Drawing.Image)(resources.GetObject("pcrAfis2.Image")));
            this.pcrAfis2.Location = new System.Drawing.Point(105, 166);
            this.pcrAfis2.Name = "pcrAfis2";
            this.pcrAfis2.Size = new System.Drawing.Size(550, 732);
            this.pcrAfis2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrAfis2.TabIndex = 1;
            this.pcrAfis2.TabStop = false;
            // 
            // lblBiletTür
            // 
            this.lblBiletTür.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBiletTür.AutoSize = true;
            this.lblBiletTür.BackColor = System.Drawing.Color.Transparent;
            this.lblBiletTür.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBiletTür.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBiletTür.Location = new System.Drawing.Point(66, 81);
            this.lblBiletTür.Name = "lblBiletTür";
            this.lblBiletTür.Size = new System.Drawing.Size(304, 79);
            this.lblBiletTür.TabIndex = 2;
            this.lblBiletTür.Text = "Bilet Tür";
            // 
            // cmbBiletTür
            // 
            this.cmbBiletTür.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBiletTür.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbBiletTür.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBiletTür.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBiletTür.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBiletTür.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbBiletTür.FormattingEnabled = true;
            this.cmbBiletTür.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBiletTür.ItemHeight = 46;
            this.cmbBiletTür.Items.AddRange(new object[] {
            "Gâzi",
            "Öğrenci",
            "Tam"});
            this.cmbBiletTür.Location = new System.Drawing.Point(80, 163);
            this.cmbBiletTür.MaximumSize = new System.Drawing.Size(999999, 0);
            this.cmbBiletTür.MaxLength = 999999999;
            this.cmbBiletTür.MinimumSize = new System.Drawing.Size(100, 0);
            this.cmbBiletTür.Name = "cmbBiletTür";
            this.cmbBiletTür.Size = new System.Drawing.Size(302, 54);
            this.cmbBiletTür.Sorted = true;
            this.cmbBiletTür.TabIndex = 3;
            this.cmbBiletTür.SelectedIndexChanged += new System.EventHandler(this.cmbBiletTür_SelectedIndexChanged);
            // 
            // cmbSeans
            // 
            this.cmbSeans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSeans.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSeans.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Location = new System.Drawing.Point(80, 441);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(302, 54);
            this.cmbSeans.TabIndex = 3;
            this.cmbSeans.Visible = false;
            // 
            // lblSeans
            // 
            this.lblSeans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeans.AutoSize = true;
            this.lblSeans.BackColor = System.Drawing.Color.Transparent;
            this.lblSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeans.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSeans.Location = new System.Drawing.Point(66, 359);
            this.lblSeans.Name = "lblSeans";
            this.lblSeans.Size = new System.Drawing.Size(238, 79);
            this.lblSeans.TabIndex = 2;
            this.lblSeans.Text = "Seans";
            this.lblSeans.Visible = false;
            // 
            // btnYiyecekIcecek
            // 
            this.btnYiyecekIcecek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYiyecekIcecek.BackColor = System.Drawing.Color.Black;
            this.btnYiyecekIcecek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYiyecekIcecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYiyecekIcecek.Location = new System.Drawing.Point(0, 537);
            this.btnYiyecekIcecek.Name = "btnYiyecekIcecek";
            this.btnYiyecekIcecek.Size = new System.Drawing.Size(432, 73);
            this.btnYiyecekIcecek.TabIndex = 4;
            this.btnYiyecekIcecek.Text = "Yiyecekler ve İçecekler \r\nMenüsü";
            this.btnYiyecekIcecek.UseVisualStyleBackColor = false;
            this.btnYiyecekIcecek.Click += new System.EventHandler(this.btnYiyecekIcecek_Click);
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBiletAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBiletAl.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletAl.Location = new System.Drawing.Point(1113, 758);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(327, 107);
            this.btnBiletAl.TabIndex = 4;
            this.btnBiletAl.Text = "Bilet AL";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblBiletTür);
            this.groupBox1.Controls.Add(this.cmbSalon);
            this.groupBox1.Controls.Add(this.btnYiyecekIcecek);
            this.groupBox1.Controls.Add(this.lblSalon);
            this.groupBox1.Controls.Add(this.lblSeans);
            this.groupBox1.Controls.Add(this.cmbBiletTür);
            this.groupBox1.Controls.Add(this.cmbSeans);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(1059, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 610);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet İşlemleri";
            // 
            // cmbSalon
            // 
            this.cmbSalon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSalon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSalon.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(80, 302);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(302, 54);
            this.cmbSalon.TabIndex = 6;
            this.cmbSalon.Visible = false;
            this.cmbSalon.SelectedIndexChanged += new System.EventHandler(this.cmbSalon_SelectedIndexChanged);
            // 
            // lblSalon
            // 
            this.lblSalon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalon.AutoSize = true;
            this.lblSalon.BackColor = System.Drawing.Color.Transparent;
            this.lblSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSalon.Location = new System.Drawing.Point(66, 220);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(219, 79);
            this.lblSalon.TabIndex = 5;
            this.lblSalon.Text = "Salon";
            this.lblSalon.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(71, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kalan Koltuk Sayısı";
            // 
            // lblKalanKoltuk
            // 
            this.lblKalanKoltuk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKalanKoltuk.AutoSize = true;
            this.lblKalanKoltuk.BackColor = System.Drawing.Color.Transparent;
            this.lblKalanKoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanKoltuk.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblKalanKoltuk.Location = new System.Drawing.Point(215, 113);
            this.lblKalanKoltuk.Name = "lblKalanKoltuk";
            this.lblKalanKoltuk.Size = new System.Drawing.Size(47, 38);
            this.lblKalanKoltuk.TabIndex = 2;
            this.lblKalanKoltuk.Text = "...";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Firebrick;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(125, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 52);
            this.label6.TabIndex = 2;
            this.label6.Text = "DİKKAT!!!";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblKalanKoltuk);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(1026, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 173);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(719, 622);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 79);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cinsiyet";
            // 
            // RdibErkek
            // 
            this.RdibErkek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RdibErkek.AutoSize = true;
            this.RdibErkek.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RdibErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdibErkek.Location = new System.Drawing.Point(757, 708);
            this.RdibErkek.Name = "RdibErkek";
            this.RdibErkek.Size = new System.Drawing.Size(101, 33);
            this.RdibErkek.TabIndex = 9;
            this.RdibErkek.Text = "Erkek";
            this.RdibErkek.UseVisualStyleBackColor = false;
            // 
            // RdibKadin
            // 
            this.RdibKadin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RdibKadin.AutoSize = true;
            this.RdibKadin.BackColor = System.Drawing.Color.HotPink;
            this.RdibKadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdibKadin.Location = new System.Drawing.Point(871, 708);
            this.RdibKadin.Name = "RdibKadin";
            this.RdibKadin.Size = new System.Drawing.Size(101, 33);
            this.RdibKadin.TabIndex = 10;
            this.RdibKadin.Text = "Kadın";
            this.RdibKadin.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(1521, 837);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Yiyecek-İçecek Tutarı:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(1517, 798);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 38);
            this.label8.TabIndex = 5;
            this.label8.Text = "Toplam Tutar:";
            // 
            // lblToplamtutar
            // 
            this.lblToplamtutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblToplamtutar.AutoSize = true;
            this.lblToplamtutar.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamtutar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblToplamtutar.Location = new System.Drawing.Point(1770, 798);
            this.lblToplamtutar.Name = "lblToplamtutar";
            this.lblToplamtutar.Size = new System.Drawing.Size(47, 38);
            this.lblToplamtutar.TabIndex = 5;
            this.lblToplamtutar.Text = "...";
            // 
            // lblYiyecekIcecekTutar
            // 
            this.lblYiyecekIcecekTutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYiyecekIcecekTutar.AutoSize = true;
            this.lblYiyecekIcecekTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblYiyecekIcecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYiyecekIcecekTutar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblYiyecekIcecekTutar.Location = new System.Drawing.Point(1711, 837);
            this.lblYiyecekIcecekTutar.Name = "lblYiyecekIcecekTutar";
            this.lblYiyecekIcecekTutar.Size = new System.Drawing.Size(23, 18);
            this.lblYiyecekIcecekTutar.TabIndex = 5;
            this.lblYiyecekIcecekTutar.Text = "...";
            // 
            // tmrKoltukSayisi
            // 
            this.tmrKoltukSayisi.Enabled = true;
            this.tmrKoltukSayisi.Tick += new System.EventHandler(this.tmrKoltukSayisi_Tick);
            // 
            // frmBiletKesim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1789, 932);
            this.Controls.Add(this.RdibKadin);
            this.Controls.Add(this.RdibErkek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblToplamtutar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblYiyecekIcecekTutar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.pcrAfis2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBiletKesim";
            this.Text = "frmBiletKesim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBiletKesim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrAfis2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKalanKoltuk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer tmrKoltukSayisi;
        public System.Windows.Forms.PictureBox pcrAfis2;
        public System.Windows.Forms.Label lblToplamtutar;
        public System.Windows.Forms.Label lblYiyecekIcecekTutar;
        public System.Windows.Forms.Label lblBiletTür;
        public System.Windows.Forms.ComboBox cmbBiletTür;
        public System.Windows.Forms.ComboBox cmbSeans;
        public System.Windows.Forms.Label lblSeans;
        public System.Windows.Forms.Button btnYiyecekIcecek;
        public System.Windows.Forms.Button btnBiletAl;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.RadioButton RdibErkek;
        public System.Windows.Forms.RadioButton RdibKadin;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmbSalon;
        public System.Windows.Forms.Label lblSalon;
    }
}

