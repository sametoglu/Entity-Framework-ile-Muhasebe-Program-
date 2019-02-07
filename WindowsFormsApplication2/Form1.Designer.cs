namespace WindowsFormsApplication2
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.faturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stajprojeDataSet1 = new WindowsFormsApplication2.stajprojeDataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.urunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alısSatısİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duzenleToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.indirimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Fatura_indirim = new System.Windows.Forms.Panel();
            this.cb_urun_indirim = new System.Windows.Forms.CheckBox();
            this.cb_musteri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_fatura_indirim_listesi = new System.Windows.Forms.DataGridView();
            this.label38 = new System.Windows.Forms.Label();
            this.nud_indirim_fatura = new System.Windows.Forms.NumericUpDown();
            this.btn_indirim_siparis = new System.Windows.Forms.Button();
            this.pnl_ekle = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_urun_guncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.tb_urunad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cb_marka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_satısfiyatı = new System.Windows.Forms.TextBox();
            this.tb_alısfiyatı = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_urunekle = new System.Windows.Forms.Button();
            this.dgv_urunlerlistesi = new System.Windows.Forms.DataGridView();
            this.pnl_musteri_ekle = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_musteriguncelle = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_musteriad = new System.Windows.Forms.TextBox();
            this.tb_musterisoyad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.tb_vergino = new System.Windows.Forms.TextBox();
            this.tb_musteritel = new System.Windows.Forms.TextBox();
            this.tb_vergidairesi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_musteritip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_musterilerlistesi = new System.Windows.Forms.DataGridView();
            this.btn_musteriekle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_alis_satis = new System.Windows.Forms.Panel();
            this.cb_urunekle = new System.Windows.Forms.CheckBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.genel_toplam = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.ara_toplam = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.KalanStok = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nud_adet = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_teslimtarihi = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_musterilistesi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_urunlistesi = new System.Windows.Forms.ComboBox();
            this.rb_tevkifatlı = new System.Windows.Forms.RadioButton();
            this.rb_KDV_yok = new System.Windows.Forms.RadioButton();
            this.rb_KDV = new System.Windows.Forms.RadioButton();
            this.label37 = new System.Windows.Forms.Label();
            this.cb_faturatip = new System.Windows.Forms.ComboBox();
            this.dgv_alisatimlistesi = new System.Windows.Forms.DataGridView();
            this.btn_fatura = new System.Windows.Forms.Button();
            this.pnl_fatura_duzenle = new System.Windows.Forms.Panel();
            this.raporekranı = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dgv_fatura_dokum = new System.Windows.Forms.DataGridView();
            this.rapor_ekranı = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label27 = new System.Windows.Forms.Label();
            this.faturaTableAdapter = new WindowsFormsApplication2.stajprojeDataSet1TableAdapters.faturaTableAdapter();
            this.btn_yazdır = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajprojeDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_Fatura_indirim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fatura_indirim_listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_indirim_fatura)).BeginInit();
            this.pnl_ekle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunlerlistesi)).BeginInit();
            this.pnl_musteri_ekle.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musterilerlistesi)).BeginInit();
            this.pnl_alis_satis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alisatimlistesi)).BeginInit();
            this.pnl_fatura_duzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fatura_dokum)).BeginInit();
            this.SuspendLayout();
            // 
            // faturaBindingSource
            // 
            this.faturaBindingSource.DataMember = "fatura";
            this.faturaBindingSource.DataSource = this.stajprojeDataSet1;
            // 
            // stajprojeDataSet1
            // 
            this.stajprojeDataSet1.DataSetName = "stajprojeDataSet1";
            this.stajprojeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.faturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // urunToolStripMenuItem
            // 
            this.urunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem});
            this.urunToolStripMenuItem.Name = "urunToolStripMenuItem";
            this.urunToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.urunToolStripMenuItem.Text = "Stok İşlemleri";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ekleToolStripMenuItem.Text = "Stok Kartı Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.alısSatısİşlemleriToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.müşteriToolStripMenuItem.Text = "Cari İşlemler";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.ekleToolStripMenuItem1.Text = "Cari Kart Ekle";
            this.ekleToolStripMenuItem1.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // alısSatısİşlemleriToolStripMenuItem
            // 
            this.alısSatısİşlemleriToolStripMenuItem.Name = "alısSatısİşlemleriToolStripMenuItem";
            this.alısSatısİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.alısSatısİşlemleriToolStripMenuItem.Text = "Alıs-Satıs işlemleri";
            this.alısSatısİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.alısSatısİşlemleriToolStripMenuItem_Click);
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duzenleToolStripMenuItem3,
            this.indirimToolStripMenuItem1});
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.faturaToolStripMenuItem.Text = "Fatura";
            // 
            // duzenleToolStripMenuItem3
            // 
            this.duzenleToolStripMenuItem3.Name = "duzenleToolStripMenuItem3";
            this.duzenleToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.duzenleToolStripMenuItem3.Text = "Duzenle";
            this.duzenleToolStripMenuItem3.Click += new System.EventHandler(this.duzenleToolStripMenuItem3_Click);
            // 
            // indirimToolStripMenuItem1
            // 
            this.indirimToolStripMenuItem1.Name = "indirimToolStripMenuItem1";
            this.indirimToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.indirimToolStripMenuItem1.Text = "İndirim";
            this.indirimToolStripMenuItem1.Click += new System.EventHandler(this.indirimToolStripMenuItem1_Click);
            // 
            // pnl_Fatura_indirim
            // 
            this.pnl_Fatura_indirim.Controls.Add(this.cb_urun_indirim);
            this.pnl_Fatura_indirim.Controls.Add(this.cb_musteri);
            this.pnl_Fatura_indirim.Controls.Add(this.label4);
            this.pnl_Fatura_indirim.Controls.Add(this.dgv_fatura_indirim_listesi);
            this.pnl_Fatura_indirim.Controls.Add(this.label38);
            this.pnl_Fatura_indirim.Controls.Add(this.nud_indirim_fatura);
            this.pnl_Fatura_indirim.Controls.Add(this.btn_indirim_siparis);
            this.pnl_Fatura_indirim.Location = new System.Drawing.Point(12, 27);
            this.pnl_Fatura_indirim.Name = "pnl_Fatura_indirim";
            this.pnl_Fatura_indirim.Size = new System.Drawing.Size(738, 390);
            this.pnl_Fatura_indirim.TabIndex = 105;
            // 
            // cb_urun_indirim
            // 
            this.cb_urun_indirim.AutoSize = true;
            this.cb_urun_indirim.Location = new System.Drawing.Point(106, 32);
            this.cb_urun_indirim.Name = "cb_urun_indirim";
            this.cb_urun_indirim.Size = new System.Drawing.Size(82, 17);
            this.cb_urun_indirim.TabIndex = 29;
            this.cb_urun_indirim.Text = "Urun İndirim";
            this.cb_urun_indirim.UseVisualStyleBackColor = true;
            this.cb_urun_indirim.CheckedChanged += new System.EventHandler(this.cb_urun_indirim_CheckedChanged);
            // 
            // cb_musteri
            // 
            this.cb_musteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_musteri.FormattingEnabled = true;
            this.cb_musteri.Location = new System.Drawing.Point(86, 60);
            this.cb_musteri.Name = "cb_musteri";
            this.cb_musteri.Size = new System.Drawing.Size(100, 21);
            this.cb_musteri.TabIndex = 28;
            this.cb_musteri.Visible = false;
            this.cb_musteri.SelectionChangeCommitted += new System.EventHandler(this.cb_musteri_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "musteri : ";
            this.label4.Visible = false;
            // 
            // dgv_fatura_indirim_listesi
            // 
            this.dgv_fatura_indirim_listesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fatura_indirim_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fatura_indirim_listesi.Location = new System.Drawing.Point(192, 8);
            this.dgv_fatura_indirim_listesi.Name = "dgv_fatura_indirim_listesi";
            this.dgv_fatura_indirim_listesi.Size = new System.Drawing.Size(543, 365);
            this.dgv_fatura_indirim_listesi.TabIndex = 24;
            this.dgv_fatura_indirim_listesi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_fatura_indirim_listesi_CellMouseDoubleClick);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(16, 103);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 13);
            this.label38.TabIndex = 23;
            this.label38.Text = "Yüzde : ";
            // 
            // nud_indirim_fatura
            // 
            this.nud_indirim_fatura.AutoSize = true;
            this.nud_indirim_fatura.Location = new System.Drawing.Point(86, 97);
            this.nud_indirim_fatura.Name = "nud_indirim_fatura";
            this.nud_indirim_fatura.Size = new System.Drawing.Size(100, 20);
            this.nud_indirim_fatura.TabIndex = 22;
            // 
            // btn_indirim_siparis
            // 
            this.btn_indirim_siparis.Location = new System.Drawing.Point(16, 128);
            this.btn_indirim_siparis.Name = "btn_indirim_siparis";
            this.btn_indirim_siparis.Size = new System.Drawing.Size(170, 20);
            this.btn_indirim_siparis.TabIndex = 21;
            this.btn_indirim_siparis.Text = "İndirim";
            this.btn_indirim_siparis.UseVisualStyleBackColor = true;
            this.btn_indirim_siparis.Click += new System.EventHandler(this.btn_indirim_siparis_Click);
            // 
            // pnl_ekle
            // 
            this.pnl_ekle.Controls.Add(this.label21);
            this.pnl_ekle.Controls.Add(this.btn_urun_guncelle);
            this.pnl_ekle.Controls.Add(this.groupBox2);
            this.pnl_ekle.Controls.Add(this.groupBox1);
            this.pnl_ekle.Controls.Add(this.btn_urunekle);
            this.pnl_ekle.Controls.Add(this.dgv_urunlerlistesi);
            this.pnl_ekle.Location = new System.Drawing.Point(18, 24);
            this.pnl_ekle.Name = "pnl_ekle";
            this.pnl_ekle.Size = new System.Drawing.Size(745, 379);
            this.pnl_ekle.TabIndex = 126;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(608, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 13);
            this.label21.TabIndex = 75;
            this.label21.Text = "Guncellemek icin Çift tıkla";
            // 
            // btn_urun_guncelle
            // 
            this.btn_urun_guncelle.Location = new System.Drawing.Point(116, 260);
            this.btn_urun_guncelle.Name = "btn_urun_guncelle";
            this.btn_urun_guncelle.Size = new System.Drawing.Size(91, 20);
            this.btn_urun_guncelle.TabIndex = 74;
            this.btn_urun_guncelle.Text = "Guncelle";
            this.btn_urun_guncelle.UseVisualStyleBackColor = true;
            this.btn_urun_guncelle.Click += new System.EventHandler(this.btn_urun_guncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.nud_stok);
            this.groupBox2.Controls.Add(this.tb_urunad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cb_marka);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_kategori);
            this.groupBox2.Location = new System.Drawing.Point(16, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 141);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genel Bilgileri";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 85;
            this.label15.Text = "Stok : ";
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(83, 109);
            this.nud_stok.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(100, 20);
            this.nud_stok.TabIndex = 84;
            // 
            // tb_urunad
            // 
            this.tb_urunad.Location = new System.Drawing.Point(83, 83);
            this.tb_urunad.MaxLength = 15;
            this.tb_urunad.Name = "tb_urunad";
            this.tb_urunad.Size = new System.Drawing.Size(100, 20);
            this.tb_urunad.TabIndex = 83;
            this.tb_urunad.TextChanged += new System.EventHandler(this.tb_urunad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Ad : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 80;
            this.label20.Text = "Marka : ";
            // 
            // cb_marka
            // 
            this.cb_marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_marka.FormattingEnabled = true;
            this.cb_marka.Location = new System.Drawing.Point(84, 53);
            this.cb_marka.Name = "cb_marka";
            this.cb_marka.Size = new System.Drawing.Size(100, 21);
            this.cb_marka.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Kategori : ";
            // 
            // cb_kategori
            // 
            this.cb_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Location = new System.Drawing.Point(84, 21);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(100, 21);
            this.cb_kategori.TabIndex = 79;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_satısfiyatı);
            this.groupBox1.Controls.Add(this.tb_alısfiyatı);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 72);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fİyat Bilgileri";
            // 
            // tb_satısfiyatı
            // 
            this.tb_satısfiyatı.Location = new System.Drawing.Point(84, 42);
            this.tb_satısfiyatı.MaxLength = 7;
            this.tb_satısfiyatı.Name = "tb_satısfiyatı";
            this.tb_satısfiyatı.Size = new System.Drawing.Size(100, 20);
            this.tb_satısfiyatı.TabIndex = 71;
            // 
            // tb_alısfiyatı
            // 
            this.tb_alısfiyatı.Location = new System.Drawing.Point(84, 16);
            this.tb_alısfiyatı.MaxLength = 7;
            this.tb_alısfiyatı.Name = "tb_alısfiyatı";
            this.tb_alısfiyatı.Size = new System.Drawing.Size(100, 20);
            this.tb_alısfiyatı.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 70;
            this.label14.Text = "Satıs Fiyatı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Alıs Fiyatı : ";
            // 
            // btn_urunekle
            // 
            this.btn_urunekle.Location = new System.Drawing.Point(115, 260);
            this.btn_urunekle.Name = "btn_urunekle";
            this.btn_urunekle.Size = new System.Drawing.Size(91, 20);
            this.btn_urunekle.TabIndex = 33;
            this.btn_urunekle.Text = "Ekle";
            this.btn_urunekle.UseVisualStyleBackColor = true;
            this.btn_urunekle.Click += new System.EventHandler(this.btn_urunekle_Click_1);
            // 
            // dgv_urunlerlistesi
            // 
            this.dgv_urunlerlistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunlerlistesi.Location = new System.Drawing.Point(217, 26);
            this.dgv_urunlerlistesi.Name = "dgv_urunlerlistesi";
            this.dgv_urunlerlistesi.Size = new System.Drawing.Size(519, 350);
            this.dgv_urunlerlistesi.TabIndex = 26;
            this.dgv_urunlerlistesi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_urunlerlistesi_CellMouseDoubleClick);
            // 
            // pnl_musteri_ekle
            // 
            this.pnl_musteri_ekle.Controls.Add(this.label19);
            this.pnl_musteri_ekle.Controls.Add(this.btn_musteriguncelle);
            this.pnl_musteri_ekle.Controls.Add(this.groupBox6);
            this.pnl_musteri_ekle.Controls.Add(this.groupBox5);
            this.pnl_musteri_ekle.Controls.Add(this.dgv_musterilerlistesi);
            this.pnl_musteri_ekle.Controls.Add(this.btn_musteriekle);
            this.pnl_musteri_ekle.Location = new System.Drawing.Point(23, 24);
            this.pnl_musteri_ekle.Name = "pnl_musteri_ekle";
            this.pnl_musteri_ekle.Size = new System.Drawing.Size(740, 390);
            this.pnl_musteri_ekle.TabIndex = 136;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(607, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 13);
            this.label19.TabIndex = 58;
            this.label19.Text = "Guncellemek icin Çift tıkla";
            // 
            // btn_musteriguncelle
            // 
            this.btn_musteriguncelle.Location = new System.Drawing.Point(114, 344);
            this.btn_musteriguncelle.Name = "btn_musteriguncelle";
            this.btn_musteriguncelle.Size = new System.Drawing.Size(100, 20);
            this.btn_musteriguncelle.TabIndex = 57;
            this.btn_musteriguncelle.Text = "Guncelle";
            this.btn_musteriguncelle.UseVisualStyleBackColor = true;
            this.btn_musteriguncelle.Click += new System.EventHandler(this.btn_musteriguncelle_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_musteriad);
            this.groupBox6.Controls.Add(this.tb_musterisoyad);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(8, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(194, 88);
            this.groupBox6.TabIndex = 56;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ön Bilgiler";
            // 
            // tb_musteriad
            // 
            this.tb_musteriad.Location = new System.Drawing.Point(86, 24);
            this.tb_musteriad.MaxLength = 15;
            this.tb_musteriad.Name = "tb_musteriad";
            this.tb_musteriad.Size = new System.Drawing.Size(100, 20);
            this.tb_musteriad.TabIndex = 57;
            this.tb_musteriad.TextChanged += new System.EventHandler(this.tb_musteriad_TextChanged);
            // 
            // tb_musterisoyad
            // 
            this.tb_musterisoyad.Location = new System.Drawing.Point(86, 50);
            this.tb_musterisoyad.MaxLength = 15;
            this.tb_musterisoyad.Name = "tb_musterisoyad";
            this.tb_musterisoyad.Size = new System.Drawing.Size(100, 20);
            this.tb_musterisoyad.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Ad : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Soyad : ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_adres);
            this.groupBox5.Controls.Add(this.tb_vergino);
            this.groupBox5.Controls.Add(this.tb_musteritel);
            this.groupBox5.Controls.Add(this.tb_vergidairesi);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cb_musteritip);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(8, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(195, 229);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cari Bilgiler";
            // 
            // tb_adres
            // 
            this.tb_adres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_adres.Location = new System.Drawing.Point(53, 164);
            this.tb_adres.MaxLength = 50;
            this.tb_adres.Multiline = true;
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_adres.Size = new System.Drawing.Size(133, 50);
            this.tb_adres.TabIndex = 64;
            // 
            // tb_vergino
            // 
            this.tb_vergino.Location = new System.Drawing.Point(85, 75);
            this.tb_vergino.MaxLength = 10;
            this.tb_vergino.Name = "tb_vergino";
            this.tb_vergino.Size = new System.Drawing.Size(100, 20);
            this.tb_vergino.TabIndex = 66;
            // 
            // tb_musteritel
            // 
            this.tb_musteritel.Location = new System.Drawing.Point(86, 15);
            this.tb_musteritel.MaxLength = 11;
            this.tb_musteritel.Name = "tb_musteritel";
            this.tb_musteritel.Size = new System.Drawing.Size(100, 20);
            this.tb_musteritel.TabIndex = 63;
            // 
            // tb_vergidairesi
            // 
            this.tb_vergidairesi.Location = new System.Drawing.Point(85, 49);
            this.tb_vergidairesi.MaxLength = 20;
            this.tb_vergidairesi.Name = "tb_vergidairesi";
            this.tb_vergidairesi.Size = new System.Drawing.Size(100, 20);
            this.tb_vergidairesi.TabIndex = 61;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(0, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 69;
            this.label17.Text = "Adres : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Musteri Tip : ";
            // 
            // cb_musteritip
            // 
            this.cb_musteritip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_musteritip.FormattingEnabled = true;
            this.cb_musteritip.Location = new System.Drawing.Point(85, 116);
            this.cb_musteritip.Name = "cb_musteritip";
            this.cb_musteritip.Size = new System.Drawing.Size(100, 21);
            this.cb_musteritip.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Vergi No : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Vergi Dairesi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Tel : ";
            // 
            // dgv_musterilerlistesi
            // 
            this.dgv_musterilerlistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musterilerlistesi.Location = new System.Drawing.Point(220, 22);
            this.dgv_musterilerlistesi.Name = "dgv_musterilerlistesi";
            this.dgv_musterilerlistesi.Size = new System.Drawing.Size(515, 356);
            this.dgv_musterilerlistesi.TabIndex = 54;
            this.dgv_musterilerlistesi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_musterilerlistesi_CellMouseDoubleClick);
            // 
            // btn_musteriekle
            // 
            this.btn_musteriekle.Location = new System.Drawing.Point(114, 344);
            this.btn_musteriekle.Name = "btn_musteriekle";
            this.btn_musteriekle.Size = new System.Drawing.Size(100, 20);
            this.btn_musteriekle.TabIndex = 44;
            this.btn_musteriekle.Text = "Ekle";
            this.btn_musteriekle.UseVisualStyleBackColor = true;
            this.btn_musteriekle.Click += new System.EventHandler(this.btn_musteriekle_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_alis_satis
            // 
            this.pnl_alis_satis.Controls.Add(this.cb_urunekle);
            this.pnl_alis_satis.Controls.Add(this.btn_ekle);
            this.pnl_alis_satis.Controls.Add(this.genel_toplam);
            this.pnl_alis_satis.Controls.Add(this.label36);
            this.pnl_alis_satis.Controls.Add(this.ara_toplam);
            this.pnl_alis_satis.Controls.Add(this.label35);
            this.pnl_alis_satis.Controls.Add(this.KalanStok);
            this.pnl_alis_satis.Controls.Add(this.label18);
            this.pnl_alis_satis.Controls.Add(this.nud_adet);
            this.pnl_alis_satis.Controls.Add(this.label16);
            this.pnl_alis_satis.Controls.Add(this.label13);
            this.pnl_alis_satis.Controls.Add(this.dtp_teslimtarihi);
            this.pnl_alis_satis.Controls.Add(this.label12);
            this.pnl_alis_satis.Controls.Add(this.cb_musterilistesi);
            this.pnl_alis_satis.Controls.Add(this.label10);
            this.pnl_alis_satis.Controls.Add(this.cb_urunlistesi);
            this.pnl_alis_satis.Controls.Add(this.rb_tevkifatlı);
            this.pnl_alis_satis.Controls.Add(this.rb_KDV_yok);
            this.pnl_alis_satis.Controls.Add(this.rb_KDV);
            this.pnl_alis_satis.Controls.Add(this.label37);
            this.pnl_alis_satis.Controls.Add(this.cb_faturatip);
            this.pnl_alis_satis.Controls.Add(this.dgv_alisatimlistesi);
            this.pnl_alis_satis.Controls.Add(this.btn_fatura);
            this.pnl_alis_satis.Location = new System.Drawing.Point(20, 25);
            this.pnl_alis_satis.Name = "pnl_alis_satis";
            this.pnl_alis_satis.Size = new System.Drawing.Size(730, 390);
            this.pnl_alis_satis.TabIndex = 139;
            // 
            // cb_urunekle
            // 
            this.cb_urunekle.AutoSize = true;
            this.cb_urunekle.Location = new System.Drawing.Point(111, 39);
            this.cb_urunekle.Name = "cb_urunekle";
            this.cb_urunekle.Size = new System.Drawing.Size(73, 17);
            this.cb_urunekle.TabIndex = 43;
            this.cb_urunekle.Text = "Urun Ekle";
            this.cb_urunekle.UseVisualStyleBackColor = true;
            this.cb_urunekle.Visible = false;
            this.cb_urunekle.CheckedChanged += new System.EventHandler(this.cb_urunekle_CheckedChanged);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(10, 258);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(173, 23);
            this.btn_ekle.TabIndex = 41;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // genel_toplam
            // 
            this.genel_toplam.AutoSize = true;
            this.genel_toplam.Location = new System.Drawing.Point(446, 333);
            this.genel_toplam.Name = "genel_toplam";
            this.genel_toplam.Size = new System.Drawing.Size(0, 13);
            this.genel_toplam.TabIndex = 40;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(358, 333);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(82, 13);
            this.label36.TabIndex = 39;
            this.label36.Text = "Genel Toplam : ";
            // 
            // ara_toplam
            // 
            this.ara_toplam.AutoSize = true;
            this.ara_toplam.Location = new System.Drawing.Point(434, 303);
            this.ara_toplam.Name = "ara_toplam";
            this.ara_toplam.Size = new System.Drawing.Size(0, 13);
            this.ara_toplam.TabIndex = 38;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(358, 303);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(70, 13);
            this.label35.TabIndex = 37;
            this.label35.Text = "Ara Toplam : ";
            // 
            // KalanStok
            // 
            this.KalanStok.AutoSize = true;
            this.KalanStok.Location = new System.Drawing.Point(85, 106);
            this.KalanStok.Name = "KalanStok";
            this.KalanStok.Size = new System.Drawing.Size(0, 13);
            this.KalanStok.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Kalan Stok : ";
            // 
            // nud_adet
            // 
            this.nud_adet.AutoSize = true;
            this.nud_adet.Location = new System.Drawing.Point(84, 213);
            this.nud_adet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_adet.Name = "nud_adet";
            this.nud_adet.Size = new System.Drawing.Size(100, 20);
            this.nud_adet.TabIndex = 34;
            this.nud_adet.ValueChanged += new System.EventHandler(this.nud_adet_ValueChanged_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Adet : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Teslim Tarihi : ";
            // 
            // dtp_teslimtarihi
            // 
            this.dtp_teslimtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_teslimtarihi.Location = new System.Drawing.Point(84, 172);
            this.dtp_teslimtarihi.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtp_teslimtarihi.Name = "dtp_teslimtarihi";
            this.dtp_teslimtarihi.Size = new System.Drawing.Size(100, 20);
            this.dtp_teslimtarihi.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Musteri : ";
            // 
            // cb_musterilistesi
            // 
            this.cb_musterilistesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_musterilistesi.FormattingEnabled = true;
            this.cb_musterilistesi.Location = new System.Drawing.Point(84, 139);
            this.cb_musterilistesi.Name = "cb_musterilistesi";
            this.cb_musterilistesi.Size = new System.Drawing.Size(100, 21);
            this.cb_musterilistesi.TabIndex = 30;
            this.cb_musterilistesi.SelectionChangeCommitted += new System.EventHandler(this.cb_musterilistesi_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Urun : ";
            // 
            // cb_urunlistesi
            // 
            this.cb_urunlistesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_urunlistesi.FormattingEnabled = true;
            this.cb_urunlistesi.Location = new System.Drawing.Point(84, 65);
            this.cb_urunlistesi.Name = "cb_urunlistesi";
            this.cb_urunlistesi.Size = new System.Drawing.Size(100, 21);
            this.cb_urunlistesi.TabIndex = 28;
            this.cb_urunlistesi.SelectionChangeCommitted += new System.EventHandler(this.cb_urunlistesi_SelectionChangeCommitted_1);
            // 
            // rb_tevkifatlı
            // 
            this.rb_tevkifatlı.AutoSize = true;
            this.rb_tevkifatlı.Location = new System.Drawing.Point(203, 363);
            this.rb_tevkifatlı.Name = "rb_tevkifatlı";
            this.rb_tevkifatlı.Size = new System.Drawing.Size(68, 17);
            this.rb_tevkifatlı.TabIndex = 22;
            this.rb_tevkifatlı.TabStop = true;
            this.rb_tevkifatlı.Text = "Tevkifatlı";
            this.rb_tevkifatlı.UseVisualStyleBackColor = true;
            this.rb_tevkifatlı.CheckedChanged += new System.EventHandler(this.rb_tevkifatlı_CheckedChanged_1);
            // 
            // rb_KDV_yok
            // 
            this.rb_KDV_yok.AutoSize = true;
            this.rb_KDV_yok.Location = new System.Drawing.Point(203, 332);
            this.rb_KDV_yok.Name = "rb_KDV_yok";
            this.rb_KDV_yok.Size = new System.Drawing.Size(75, 17);
            this.rb_KDV_yok.TabIndex = 21;
            this.rb_KDV_yok.TabStop = true;
            this.rb_KDV_yok.Text = "KDV Hariç";
            this.rb_KDV_yok.UseVisualStyleBackColor = true;
            this.rb_KDV_yok.CheckedChanged += new System.EventHandler(this.rb_KDV_yok_CheckedChanged_1);
            // 
            // rb_KDV
            // 
            this.rb_KDV.AutoSize = true;
            this.rb_KDV.Location = new System.Drawing.Point(203, 301);
            this.rb_KDV.Name = "rb_KDV";
            this.rb_KDV.Size = new System.Drawing.Size(74, 17);
            this.rb_KDV.TabIndex = 20;
            this.rb_KDV.TabStop = true;
            this.rb_KDV.Text = "KDV Dahil";
            this.rb_KDV.UseVisualStyleBackColor = true;
            this.rb_KDV.CheckedChanged += new System.EventHandler(this.rb_KDV_CheckedChanged_1);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(8, 7);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(61, 13);
            this.label37.TabIndex = 19;
            this.label37.Text = "Fatura Tip :";
            // 
            // cb_faturatip
            // 
            this.cb_faturatip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_faturatip.FormattingEnabled = true;
            this.cb_faturatip.Location = new System.Drawing.Point(84, 3);
            this.cb_faturatip.Name = "cb_faturatip";
            this.cb_faturatip.Size = new System.Drawing.Size(100, 21);
            this.cb_faturatip.TabIndex = 17;
            this.cb_faturatip.SelectionChangeCommitted += new System.EventHandler(this.cb_faturatip_SelectionChangeCommitted_1);
            // 
            // dgv_alisatimlistesi
            // 
            this.dgv_alisatimlistesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_alisatimlistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alisatimlistesi.Location = new System.Drawing.Point(190, 3);
            this.dgv_alisatimlistesi.Name = "dgv_alisatimlistesi";
            this.dgv_alisatimlistesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_alisatimlistesi.Size = new System.Drawing.Size(528, 292);
            this.dgv_alisatimlistesi.TabIndex = 16;
            // 
            // btn_fatura
            // 
            this.btn_fatura.Location = new System.Drawing.Point(11, 301);
            this.btn_fatura.Name = "btn_fatura";
            this.btn_fatura.Size = new System.Drawing.Size(173, 79);
            this.btn_fatura.TabIndex = 15;
            this.btn_fatura.Text = "Fatura";
            this.btn_fatura.UseVisualStyleBackColor = true;
            this.btn_fatura.Visible = false;
            this.btn_fatura.Click += new System.EventHandler(this.btn_fatura_Click_1);
            // 
            // pnl_fatura_duzenle
            // 
            this.pnl_fatura_duzenle.Controls.Add(this.raporekranı);
            this.pnl_fatura_duzenle.Controls.Add(this.btn_yazdır);
            this.pnl_fatura_duzenle.Controls.Add(this.dgv_fatura_dokum);
            this.pnl_fatura_duzenle.Location = new System.Drawing.Point(13, 24);
            this.pnl_fatura_duzenle.Name = "pnl_fatura_duzenle";
            this.pnl_fatura_duzenle.Size = new System.Drawing.Size(750, 393);
            this.pnl_fatura_duzenle.TabIndex = 140;
            // 
            // raporekranı
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.faturaBindingSource;
            this.raporekranı.LocalReport.DataSources.Add(reportDataSource1);
            this.raporekranı.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.Report1.rdlc";
            this.raporekranı.LocalReport.ReportPath = "";
            this.raporekranı.Location = new System.Drawing.Point(13, 11);
            this.raporekranı.Name = "raporekranı";
            this.raporekranı.Size = new System.Drawing.Size(666, 316);
            this.raporekranı.TabIndex = 47;
            this.raporekranı.Visible = false;
            // 
            // dgv_fatura_dokum
            // 
            this.dgv_fatura_dokum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fatura_dokum.Location = new System.Drawing.Point(13, 13);
            this.dgv_fatura_dokum.Name = "dgv_fatura_dokum";
            this.dgv_fatura_dokum.Size = new System.Drawing.Size(721, 363);
            this.dgv_fatura_dokum.TabIndex = 45;
            this.dgv_fatura_dokum.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_fatura_dokum_CellMouseDoubleClick);
            // 
            // rapor_ekranı
            // 
            this.rapor_ekranı.Location = new System.Drawing.Point(0, 0);
            this.rapor_ekranı.Name = "rapor_ekranı";
            this.rapor_ekranı.Size = new System.Drawing.Size(396, 246);
            this.rapor_ekranı.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(722, 2);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 13);
            this.label27.TabIndex = 138;
            // 
            // faturaTableAdapter
            // 
            this.faturaTableAdapter.ClearBeforeFill = true;
            // 
            // btn_yazdır
            // 
            this.btn_yazdır.Location = new System.Drawing.Point(652, 340);
            this.btn_yazdır.Name = "btn_yazdır";
            this.btn_yazdır.Size = new System.Drawing.Size(74, 29);
            this.btn_yazdır.TabIndex = 46;
            this.btn_yazdır.Text = "Yazdır";
            this.btn_yazdır.UseVisualStyleBackColor = true;
            this.btn_yazdır.Click += new System.EventHandler(this.btn_yazdır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 426);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_fatura_duzenle);
            this.Controls.Add(this.pnl_alis_satis);
            this.Controls.Add(this.pnl_ekle);
            this.Controls.Add(this.pnl_musteri_ekle);
            this.Controls.Add(this.pnl_Fatura_indirim);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajprojeDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Fatura_indirim.ResumeLayout(false);
            this.pnl_Fatura_indirim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fatura_indirim_listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_indirim_fatura)).EndInit();
            this.pnl_ekle.ResumeLayout(false);
            this.pnl_ekle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunlerlistesi)).EndInit();
            this.pnl_musteri_ekle.ResumeLayout(false);
            this.pnl_musteri_ekle.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musterilerlistesi)).EndInit();
            this.pnl_alis_satis.ResumeLayout(false);
            this.pnl_alis_satis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alisatimlistesi)).EndInit();
            this.pnl_fatura_duzenle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fatura_dokum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duzenleToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem indirimToolStripMenuItem1;
        private System.Windows.Forms.Panel pnl_Fatura_indirim;
        private System.Windows.Forms.DataGridView dgv_fatura_indirim_listesi;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown nud_indirim_fatura;
        private System.Windows.Forms.Button btn_indirim_siparis;
        private System.Windows.Forms.Panel pnl_ekle;
        private System.Windows.Forms.Button btn_urunekle;
        private System.Windows.Forms.DataGridView dgv_urunlerlistesi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_urunad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cb_marka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_satısfiyatı;
        private System.Windows.Forms.TextBox tb_alısfiyatı;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_musteri_ekle;
        private System.Windows.Forms.DataGridView dgv_musterilerlistesi;
        private System.Windows.Forms.Button btn_musteriekle;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_musteriad;
        private System.Windows.Forms.TextBox tb_musterisoyad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.TextBox tb_vergino;
        private System.Windows.Forms.TextBox tb_musteritel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_musteritip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem alısSatısİşlemleriToolStripMenuItem;
        private System.Windows.Forms.Button btn_musteriguncelle;
        public System.Windows.Forms.TextBox tb_vergidairesi;
        private System.Windows.Forms.Button btn_urun_guncelle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.Panel pnl_alis_satis;
        private System.Windows.Forms.Label genel_toplam;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label ara_toplam;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label KalanStok;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nud_adet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_teslimtarihi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_musterilistesi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_urunlistesi;
        private System.Windows.Forms.RadioButton rb_tevkifatlı;
        private System.Windows.Forms.RadioButton rb_KDV_yok;
        private System.Windows.Forms.RadioButton rb_KDV;
        private System.Windows.Forms.DataGridView dgv_alisatimlistesi;
        private System.Windows.Forms.Button btn_fatura;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cb_faturatip;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.CheckBox cb_urunekle;
        private System.Windows.Forms.Panel pnl_fatura_duzenle;
        private System.Windows.Forms.DataGridView dgv_fatura_dokum;
        private Microsoft.Reporting.WinForms.ReportViewer rapor_ekranı;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cb_musteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_urun_indirim;
        private System.Windows.Forms.Label label21;
        private Microsoft.Reporting.WinForms.ReportViewer raporekranı;
        private System.Windows.Forms.BindingSource faturaBindingSource;
        private stajprojeDataSet1 stajprojeDataSet1;
        private stajprojeDataSet1TableAdapters.faturaTableAdapter faturaTableAdapter;
        private System.Windows.Forms.Button btn_yazdır;


    }
}

