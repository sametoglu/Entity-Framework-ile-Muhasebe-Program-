using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Entity;
using Microsoft.Reporting;
using Microsoft.ReportingServices;
using System.Configuration;



namespace WindowsFormsApplication2
{
    using Models;
    using Microsoft.Reporting.WinForms;
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        stajprojeContext ctx = new stajprojeContext();
        public float faturaoran;
        public Double siparis_fiyatı;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            var data = ctx.faturas.ToList();
            this.faturaBindingSource.DataSource = data;
            this.raporekranı.RefreshReport();

            pnl_ekle.Hide();
            pnl_musteri_ekle.Hide();
            pnl_alis_satis.Hide();
            pnl_Fatura_indirim.Hide();
            pnl_fatura_duzenle.Hide();


            dtp_teslimtarihi.MinDate = DateTime.Now;

            timer1.Start();



            btn_musteriguncelle.Visible = false;
            btn_musteriekle.Visible = false;

            cb_musteritip.Items.Add("Tedarikçi");
            cb_musteritip.Items.Add("Müşteri");
            cb_musteritip.SelectedItem = "Müşteri";

            cb_musterilistesi.DataSource = ctx.musterilers.ToList();
            cb_musterilistesi.DisplayMember = "musteriadsoyad";
            cb_musterilistesi.ValueMember = "musteri_ıd";

            cb_musteri.DataSource = ctx.musterilers.ToList();
            cb_musteri.DisplayMember = "musteriadsoyad";
            cb_musteri.ValueMember = "musteri_ıd";


            btn_urunekle.Visible = false;
            btn_urun_guncelle.Visible = false;

            cb_urunlistesi.DataSource = ctx.urunlers.ToList();
            cb_urunlistesi.DisplayMember = "urun_ad";
            cb_urunlistesi.ValueMember = "urun_ıd";

            cb_kategori.DataSource = ctx.kategoris.ToList();
            cb_kategori.DisplayMember = "ad";
            cb_kategori.ValueMember = "kategori_ID";

            cb_marka.DataSource = ctx.markas.ToList();
            cb_marka.DisplayMember = "marka_adı";
            cb_marka.ValueMember = "marka_id";

            cb_faturatip.Items.Add("Alis");
            cb_faturatip.Items.Add("Satis");
            cb_faturatip.SelectedItem = "Satis";


          






            var musterilerlistesi = (from m in ctx.musterilers
                                     select new
                                     {
                                         musteriid = m.musteri_ıd,
                                         musteri_ad = m.musteri_ad,
                                         musteri_soyad = m.musteri_soyad,
                                         tel = m.Tel,
                                         vergi_no = m.Vergi_no,
                                         vergi_dairesi = m.Vergi_dairesi,
                                         adres = m.Adres,
                                         tip = m.musteri_tip,
                                     }
                ).ToList();

            dgv_musterilerlistesi.DataSource = musterilerlistesi;


            var urunlistesi = (from u in ctx.urunlers
                               select new
                               {
                                   urun_id = u.urun_ıd,
                                   ad = u.urun_ad,
                                   kategori = u.kategori.ad,
                                   marka = u.marka.marka_adı,
                                   stok = u.stok,
                                   alısfiyat = u.alıs_fiyatı,
                                   satısfiyat = u.satıs_fiyatı,
                               }
                ).ToList();

            dgv_urunlerlistesi.DataSource = urunlistesi;        

            var urunguncellistesi = (from u in ctx.urunlers
                               select new
                               {
                                   urun_id = u.urun_ıd,
                                   ad = u.urun_ad,
                                   kategori = u.kategori.ad,
                                   marka = u.marka.marka_adı,
                                   stok = u.stok,
                                   alısfiyat = u.alıs_fiyatı,
                                   satısfiyat = u.satıs_fiyatı,
                               }
               ).ToList();

            var liste = (from f in ctx.faturas
                         select new
                         {
                             fatura_id = f.fatura_ıd,
                             musteri_ad = f.musteri_ad,
                             musteri_soyad = f.musteri_soyad,
                             siparis_fiyatı = f.siparis_fiyatı,
                         }
                   ).ToList();

            dgv_fatura_indirim_listesi.DataSource = liste;

            var faturalistesi = (from f in ctx.faturas
                                 select new
                                 {
                                     fatura_id = f.fatura_ıd,
                                     fiyat = f.siparis_fiyatı,
                                     tarihi = f.fatura_tarih,
                                     musteri_id = f.musteri_ıd,
                                     ad = f.musteri_ad,
                                     soyad = f.musteri_soyad,
                                     vergi_no = f.musteri_vergi_no,
                                     vergi_dairesi = f.musteri_vergi_dairesi,
                                 }
                   ).ToList();

            dgv_fatura_dokum.DataSource = faturalistesi;

            KalanStok.Text = ctx.urunlers.Where(u => u.urun_ıd == cb_urunlistesi.SelectedValue.ToString()).FirstOrDefault().stok.ToString();

        }
      
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_ekle.Show();
            pnl_musteri_ekle.Hide();
            pnl_alis_satis.Hide();
            pnl_Fatura_indirim.Hide();
            pnl_fatura_duzenle.Hide();


            cb_urunlistesi.DataSource = ctx.urunlers.ToList();
            cb_urunlistesi.DisplayMember = "urun_ad";
            cb_urunlistesi.ValueMember = "urun_ıd";

            var urunlistesi = (from u in ctx.urunlers
                               select new
                               {
                                   urun_id = u.urun_ıd,
                                   ad = u.urun_ad,
                                   kategori = u.kategori.ad,
                                   marka = u.marka.marka_adı,
                                   stok = u.stok,
                                   alısfiyat = u.alıs_fiyatı,
                                   satısfiyat = u.satıs_fiyatı,
                               }
               ).ToList();

            dgv_urunlerlistesi.DataSource = urunlistesi;

            tb_urunad.ReadOnly = false;
            tb_urunad.Clear();

            cb_marka.Enabled = true;
            cb_kategori.Enabled = true;

            nud_stok.Value = 0;
            tb_alısfiyatı.Clear();
            tb_satısfiyatı.Clear();

            btn_urun_guncelle.Visible = false;

        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnl_ekle.Hide();
            pnl_musteri_ekle.Show();
            pnl_alis_satis.Hide();
            pnl_Fatura_indirim.Hide();
            pnl_fatura_duzenle.Hide();

            tb_musteriad.Clear();
            tb_musterisoyad.Clear();
            tb_musteritel.Clear();
            tb_vergino.Clear();
            tb_vergidairesi.Clear();
            tb_musteritel.Clear();
            tb_adres.Clear();

            tb_musteriad.ReadOnly = false;
            tb_musterisoyad.ReadOnly = false;




        }

        private void duzenleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pnl_ekle.Hide();
            pnl_musteri_ekle.Hide();
            pnl_alis_satis.Hide();
            pnl_Fatura_indirim.Hide();
            pnl_fatura_duzenle.Show();

            raporekranı.Visible = false;

            MessageBox.Show("fatura_id secin");

            var faturalistesi = (from f in ctx.faturas
                                 select new
                                 {
                                     fatura_id = f.fatura_ıd,
                                     fiyat = f.siparis_fiyatı,
                                     tarihi = f.fatura_tarih,
                                     musteri_id = f.musteri_ıd,
                                     ad = f.musteri_ad,
                                     soyad = f.musteri_soyad,
                                     vergi_no = f.musteri_vergi_no,
                                     vergi_dairesi = f.musteri_vergi_dairesi,
                                 }
                   ).ToList();

            dgv_fatura_dokum.DataSource = faturalistesi;

        }

        private void indirimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnl_ekle.Hide();
            pnl_musteri_ekle.Hide();
            pnl_alis_satis.Hide();
            pnl_Fatura_indirim.Show();
            pnl_fatura_duzenle.Hide();

            label4.Visible = false;
            cb_musteri.Visible = false;
            

            dgv_fatura_indirim_listesi.Enabled = true;


            var liste = (from f in ctx.faturas
                         select new
                         {
                             fatura_id = f.fatura_ıd,
                             musteri_ad = f.musteri_ad,
                             musteri_soyad = f.musteri_soyad,
                             siparis_fiyatı = f.siparis_fiyatı,
                         }
                   ).ToList();

            MessageBox.Show("fatura id secin");
        }

        private void btn_urunekle_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlParameter urun_ad = new SqlParameter("@urun_ad", tb_urunad.Text);

                SqlParameter kategori_ıd = new SqlParameter("@kategori_ıd", cb_kategori.SelectedValue.ToString());

                SqlParameter stok = new SqlParameter("@stok", Convert.ToInt32(nud_stok.Value));

                SqlParameter alısfiyat = new SqlParameter("@alısfiyat", tb_alısfiyatı.Text);

                SqlParameter satısfiyat = new SqlParameter("@satısfiyat", tb_satısfiyatı.Text);

                SqlParameter marka_id = new SqlParameter("@marka_id", cb_marka.SelectedValue.ToString());


                ctx.Database.ExecuteSqlCommand("proc_urunekle @urun_ad,@kategori_ıd,@stok,@alısfiyat,@satısfiyat,@marka_id", urun_ad, kategori_ıd, stok, alısfiyat, satısfiyat,marka_id);
                
            }
            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("eksik bilgi girisi");
            }

            var urunlistesi = (from u in ctx.urunlers
                               select new
                               {
                                   urun_id = u.urun_ıd,
                                   ad = u.urun_ad,
                                   kategori = u.kategori.ad,
                                   marka = u.marka.marka_adı,
                                   stok = u.stok,
                                   alısfiyat = u.alıs_fiyatı,
                                   satısfiyat = u.satıs_fiyatı,
                               }
                ).ToList();

            dgv_urunlerlistesi.DataSource = urunlistesi;

            tb_urunad.Clear();
            tb_satısfiyatı.Clear();
            tb_alısfiyatı.Clear();
            nud_stok.Value = 0;
            cb_marka.SelectedIndex = 0;
            cb_kategori.SelectedIndex = 0;
            btn_urunekle.Visible = false;

        }

        private void btn_indirim_siparis_Click(object sender, EventArgs e)
        {
            if (cb_urun_indirim.Checked==true)
            {

                try
                {
                    SqlParameter urun_ıd = new SqlParameter("@urun_ıd", dgv_fatura_indirim_listesi.CurrentCell.Value.ToString());
                    SqlParameter indirim_yuzdesi = new SqlParameter("@indirim_yuzdesi", nud_indirim_fatura.Value);

                    ctx.Database.ExecuteSqlCommand("proc_indirim_urun @urun_ıd,@indirim_yuzdesi", urun_ıd, indirim_yuzdesi);

                    MessageBox.Show("indirim basarılı");

                   

                }
                catch (Exception)
                {
                    MessageBox.Show("urun id secin");
                }

                var urunlistesi = (from a in ctx.Alis_Satis
                                   select new
                                   {
                                       musteri_id = a.musteri_ıd,
                                       ad_soyad = ctx.musterilers.Where(m => m.musteri_ıd == a.musteri_ıd).FirstOrDefault().musteriadsoyad,
                                       urun_id = a.urun_ıd,
                                       ad = ctx.urunlers.Where<urunler>(u => u.urun_ıd == a.urun_ıd).FirstOrDefault().urun_ad,
                                       adet = a.adet,
                                       siparis_fiyatı = a.fiyat,
                                       satısfiyat = ctx.urunlers.Where<urunler>(u => u.urun_ıd == a.urun_ıd).FirstOrDefault().satıs_fiyatı,
                                       fatura_durumu = a.fatura_durumu,
                                   }
                   ).Where(a => a.musteri_id == cb_musteri.SelectedValue.ToString()&&a.fatura_durumu=="yazılmadı").ToList();

                dgv_fatura_indirim_listesi.DataSource = urunlistesi;
                
            }

            else
            {
                try
                {
                    SqlParameter fatura_id = new SqlParameter("@fatura_id", dgv_fatura_indirim_listesi.CurrentCell.Value.ToString());
                    SqlParameter indirimyuzdesi = new SqlParameter("@indirim_yuzdesi", nud_indirim_fatura.Value);

                    ctx.Database.ExecuteSqlCommand("proc_indirim_fatura @fatura_id,@indirim_yuzdesi", fatura_id, indirimyuzdesi);

                    MessageBox.Show("indirim basarılı");


                }
                catch (Exception)
                {
                    MessageBox.Show("fatura id secin");
                }


                var faturalarindirimlistesi = (from f in ctx.faturas
                                               select new
                                               {
                                                   fatura_id = f.fatura_ıd,
                                                   musteri_ad = f.musteri_ad,
                                                   musteri_soyad = f.musteri_soyad,
                                                   siparis_fiyatı = f.siparis_fiyatı,
                                               }

                ).Where(m => m.fatura_id == dgv_fatura_indirim_listesi.CurrentCell.Value.ToString()).ToList();

                dgv_fatura_indirim_listesi.DataSource = faturalarindirimlistesi;


            }
        }

        private void btn_musteriekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter ad = new SqlParameter("@ad", tb_musteriad.Text);
                SqlParameter soyad = new SqlParameter("@soyad", tb_musterisoyad.Text);
                SqlParameter tel = new SqlParameter("@tel", tb_musteritel.Text);
                SqlParameter vergi_no = new SqlParameter("@vergi_no", tb_vergino.Text);
                SqlParameter vergi_dairesi = new SqlParameter("@vergi_dairesi", tb_vergidairesi.Text);
                SqlParameter adres = new SqlParameter("@adres", tb_adres.Text);
                SqlParameter musteri_tip = new SqlParameter("@musteri_tip", cb_musteritip.SelectedItem.ToString());

                ctx.Database.ExecuteSqlCommand("proc_musteriekle @ad,@soyad,@tel,@vergi_no,@vergi_dairesi,@adres,@musteri_tip", ad, soyad, tel, vergi_no, vergi_dairesi, adres, musteri_tip);

            }
            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("eksik bilgi girisi");
            }





            var musterilerlistesi = (from m in ctx.musterilers
                                     select new
                                     {
                                         musteriid = m.musteri_ıd,
                                         musteri_ad = m.musteri_ad,
                                         musteri_soyad = m.musteri_soyad,
                                         tel = m.Tel,
                                         vergi_no = m.Vergi_no,
                                         vergi_dairesi = m.Vergi_dairesi,
                                         adres = m.Adres,
                                         tip = m.musteri_tip,
                                     }
                ).ToList();

            dgv_musterilerlistesi.DataSource = musterilerlistesi;
            tb_musteriad.Clear();
            tb_musterisoyad.Clear();
            tb_satısfiyatı.Clear();
            tb_musteritel.Clear();
            tb_alısfiyatı.Clear();
            tb_adres.Clear();
            tb_vergidairesi.Clear();
            tb_vergino.Clear();
            btn_musteriekle.Visible = false;
        }

        private void dgv_musterilerlistesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var musterilerlistesi = (from m in ctx.musterilers
                                     select new
                                     {
                                         musteriid = m.musteri_ıd,
                                         musteri_ad = m.musteri_ad,
                                         musteri_soyad = m.musteri_soyad,
                                         tel = m.Tel,
                                         vergi_no = m.Vergi_no,
                                         vergi_dairesi = m.Vergi_dairesi,
                                         adres = m.Adres,
                                         tip = m.musteri_tip,

                                     }

                ).Where(m => m.musteriid == dgv_musterilerlistesi.CurrentCell.Value.ToString()).ToList();

            dgv_musterilerlistesi.DataSource = musterilerlistesi;


            try
            {

                tb_musteriad.Text = ctx.musterilers.Where(m => m.musteri_ıd == dgv_musterilerlistesi.CurrentCell.Value.ToString()).FirstOrDefault().musteri_ad.ToString();

                tb_musterisoyad.Text = ctx.musterilers.Where(m => m.musteri_ıd == dgv_musterilerlistesi.CurrentCell.Value.ToString()).FirstOrDefault().musteri_soyad.ToString();

                tb_musteritel.Text = musterilerlistesi.FirstOrDefault().tel.ToString();

                tb_vergino.Text = musterilerlistesi.FirstOrDefault().vergi_no.ToString();

                tb_vergidairesi.Text = musterilerlistesi.FirstOrDefault().vergi_dairesi.ToString();

                cb_musteritip.SelectedItem = ctx.musterilers.Where(m => m.musteri_ıd == dgv_musterilerlistesi.CurrentCell.Value.ToString()).FirstOrDefault().musteri_tip.ToString();

                tb_adres.Text = ctx.musterilers.Where(m => m.musteri_ıd == dgv_musterilerlistesi.CurrentCell.Value.ToString()).FirstOrDefault().Adres.ToString();

                dgv_musterilerlistesi.DataSource = musterilerlistesi;
                btn_musteriguncelle.Visible = true;

                tb_musterisoyad.ReadOnly = true;
                tb_musteriad.ReadOnly = true;

            }
            catch (Exception)
            {
                MessageBox.Show("lutfen id secin");

                var musterilersonlistesi = (from m in ctx.musterilers
                                               select new
                                               {
                                                   musteriid = m.musteri_ıd,
                                                   musteri_ad_soyad = m.musteriadsoyad,
                                                   tel = m.Tel,
                                                   vergi_no = m.Vergi_no,
                                                   vergi_dairesi = m.Vergi_dairesi,
                                                   adres = m.Adres,
                                                   tip = m.musteri_tip,
                                               }
                ).ToList();

                dgv_musterilerlistesi.DataSource = musterilersonlistesi;
            }

        }

        private void btn_musteriguncelle_Click(object sender, EventArgs e)
        {

            try
            {
                SqlParameter musteri_id = new SqlParameter("@musteri_id", dgv_musterilerlistesi.CurrentCell.Value.ToString());
                SqlParameter tel = new SqlParameter("@tel", tb_musteritel.Text);
                SqlParameter vergi_no_guncel = new SqlParameter("@vergi_no_guncel", tb_vergino.Text);
                SqlParameter vergi_dairesi_guncel = new SqlParameter("@vergi_dairesi_guncel", tb_vergidairesi.Text);
                SqlParameter adres_guncel = new SqlParameter("@adres_guncel", tb_adres.Text);


                ctx.Database.ExecuteSqlCommand("proc_musteriguncelle @musteri_id,@tel,@vergi_no_guncel,@vergi_dairesi_guncel,@adres_guncel", musteri_id, tel, vergi_no_guncel, vergi_dairesi_guncel, adres_guncel);

                MessageBox.Show("guncelleme basarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("lutfen id secin");
            }

            var musterilerlistesi = (from m in ctx.musterilers
                                     select new
                                     {
                                         musteriid = m.musteri_ıd,
                                         musteri_ad = m.musteri_ad,
                                         musteri_soyad = m.musteri_soyad,
                                         tel = m.Tel,
                                         vergi_no = m.Vergi_no,
                                         vergi_dairesi = m.Vergi_dairesi,
                                         adres = m.Adres,
                                         tip = m.musteri_tip,
                                     }

                ).ToList();

            dgv_musterilerlistesi.DataSource = musterilerlistesi;
            btn_musteriguncelle.Visible = false;
            btn_musteriekle.Visible = true;
            tb_musteriad.Clear();
            tb_musterisoyad.Clear();
            tb_musteritel.Clear();
            tb_vergino.Clear();
            tb_vergidairesi.Clear();
            tb_musteritel.Clear();
            tb_adres.Clear();

            tb_musteriad.ReadOnly = false;
            tb_musterisoyad.ReadOnly = false;

            btn_musteriguncelle.Visible = false;
        }

        private void btn_urun_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter urun_ıd = new SqlParameter("@urun_ıd", dgv_urunlerlistesi.CurrentCell.Value.ToString());
                SqlParameter stok = new SqlParameter("@stok", nud_stok.Value.ToString());
                SqlParameter alisguncelfiyat = new SqlParameter("@alis_fiyatı", tb_alısfiyatı.Text);
                SqlParameter satisguncelfiyat = new SqlParameter("@satis_fiyatı", tb_satısfiyatı.Text);

                ctx.Database.ExecuteSqlCommand("proc_urunguncelle @urun_ıd,@stok,@alis_fiyatı,@satis_fiyatı", urun_ıd, stok, alisguncelfiyat, satisguncelfiyat);

                MessageBox.Show("guncelleme basarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("lutfen id secin");
            }

            var urunlistesi = (from u in ctx.urunlers
                               select new
                               {
                                   urun_id = u.urun_ıd,
                                   ad = u.urun_ad,
                                   kategori = u.kategori.ad,
                                   marka = u.marka.marka_adı,
                                   stok = u.stok,
                                   alısfiyat = u.alıs_fiyatı,
                                   satısfiyat = u.satıs_fiyatı,
                               }
                ).ToList();

            dgv_urunlerlistesi.DataSource = urunlistesi;
            tb_alısfiyatı.Clear();
            tb_satısfiyatı.Clear();
            tb_urunad.Clear();
            nud_stok.Value = 0;
            tb_urunad.ReadOnly = false;

            cb_kategori.Enabled = true; ;
            cb_marka.Enabled = true;

            cb_kategori.DataSource = ctx.kategoris.ToList();
            cb_kategori.DisplayMember = "ad";
            cb_kategori.ValueMember = "kategori_ID";

            cb_marka.DataSource = ctx.markas.ToList();
            cb_marka.DisplayMember = "marka_adı";
            cb_marka.ValueMember = "marka_id";

            btn_urun_guncelle.Visible = false ;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label27.Text = DateTime.Now.Hour.ToString() +":"+ DateTime.Now.Minute.ToString() +":"+ DateTime.Now.Second.ToString() ;
            if (tb_urunad.Text != "" && tb_alısfiyatı.Text != "")
            {
                btn_urunekle.Visible = true;
            }
            else
            {
                btn_urunekle.Visible = false;
            }

            if (tb_musteriad.Text != "" && tb_musterisoyad.Text != "" && tb_vergidairesi.Text != "" && tb_vergino.Text != "" )
            {
                btn_musteriekle.Visible = true;
            }
            else
            {
                btn_musteriekle.Visible = false;
            }
                
        }

        private void tb_musteriad_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var musterilerlistesi = (from m in ctx.musterilers
                                         select new
                                         {
                                             musteriid = m.musteri_ıd,
                                             musteri_ad = m.musteri_ad,
                                             musteri_soyad=m.musteri_soyad,
                                             tel = m.Tel,
                                             vergi_no = m.Vergi_no,
                                             vergi_dairesi = m.Vergi_dairesi,
                                             adres = m.Adres,
                                             tip = m.musteri_tip,
                                         }
               ).Where(m=>m.musteri_ad.Contains(tb_musteriad.Text)).ToList();

                dgv_musterilerlistesi.DataSource = musterilerlistesi;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void tb_urunad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var urunlistesi = (from u in ctx.urunlers
                                   select new
                                   {
                                       urun_id = u.urun_ıd,
                                       ad = u.urun_ad,
                                       kategori = u.kategori.ad,
                                       marka = u.marka.marka_adı,
                                       stok = u.stok,
                                       alısfiyat = u.alıs_fiyatı,
                                       satısfiyat = u.satıs_fiyatı,
                                   }
                ).Where(m => m.ad.Contains(tb_urunad.Text)).ToList();

                dgv_urunlerlistesi.DataSource = urunlistesi;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_fatura_Click_1(object sender, EventArgs e)
        {

            try
            {


                siparis_fiyatı = Convert.ToDouble(ctx.Alis_Satis.Where(a => a.musteri_ıd == cb_musterilistesi.SelectedValue.ToString()).Sum(s => s.fiyat));

                SqlParameter musteri_ıd = new SqlParameter("@musteri_ıd", cb_musterilistesi.SelectedValue.ToString());
                SqlParameter fatura_tip = new SqlParameter("@fatura_tip", cb_faturatip.SelectedItem.ToString());
                SqlParameter siparisfiyatı = new SqlParameter("@siparis_fiyatı", siparis_fiyatı);

                ctx.Database.ExecuteSqlCommand("proc_faturalandırma @musteri_ıd,@siparis_fiyatı,@fatura_tip", musteri_ıd, siparisfiyatı, fatura_tip);

                MessageBox.Show("faturalandırma basarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Eksik bilgi girişi");
            }

            ara_toplam.Text = "";
            genel_toplam.Text = "";
            cb_faturatip.SelectedIndex = 1;
            cb_urunlistesi.SelectedIndex = 0;
            nud_adet.Value = 0;

            pnl_ekle.Hide();
            pnl_musteri_ekle.Hide();
            pnl_alis_satis.Hide();
            pnl_Fatura_indirim.Hide();
            pnl_fatura_duzenle.Show();
            btn_yazdır.Visible = true;
            dgv_fatura_dokum.Visible = true;


            var dokum = (from f in ctx.faturas
                             select new
                             {
                                 fatura_id = f.fatura_ıd,
                                 fiyat = f.siparis_fiyatı,
                                 tarihi = f.fatura_tarih,
                                 musteri_id=f.musteri_ıd,
                                 ad = f.musteri_ad,
                                 soyad = f.musteri_soyad,
                                 vergi_no = f.musteri_vergi_no,
                                 vergi_dairesi = f.musteri_vergi_dairesi,
                             }
                    ).Where(f=>f.musteri_id==cb_musterilistesi.SelectedValue.ToString()).ToList();

            dgv_fatura_dokum.DataSource = dokum;
            
        }

        private void cb_urunlistesi_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            try
            {
                KalanStok.Text = ctx.urunlers.Where(u => u.urun_ıd == cb_urunlistesi.SelectedValue.ToString()).FirstOrDefault().stok.ToString();
                if (cb_faturatip.SelectedItem.ToString() == "Satis")
                {
                    ara_toplam.Text = Convert.ToString(ctx.urunlers.Where(u => u.urun_ıd == cb_urunlistesi.SelectedValue.ToString()).FirstOrDefault().satıs_fiyatı.Value * Convert.ToInt32(nud_adet.Value));
                    genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));

                }
                else
                {
                    ara_toplam.Text = Convert.ToString(ctx.urunlers.Where(u => u.urun_ıd == cb_urunlistesi.SelectedValue.ToString()).FirstOrDefault().alıs_fiyatı.Value * Convert.ToInt32(nud_adet.Value));
                    genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));

                }
            }
            catch (Exception)
            {
                
                throw;
            }

            
        }

        private void cb_faturatip_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (cb_faturatip.SelectedItem.ToString() == "Satis")
            {
                ara_toplam.Text = Convert.ToString(ctx.urunlers.Where(u => u.urun_ıd == cb_urunlistesi.SelectedValue.ToString()).FirstOrDefault().satıs_fiyatı.Value * Convert.ToInt32(nud_adet.Value));

                cb_musterilistesi.DataSource = ctx.musterilers.Where(m => m.musteri_tip.ToString() == "Müşteri").ToList();
                cb_musterilistesi.DisplayMember = "musteriadsoyad";
                cb_musterilistesi.ValueMember = "musteri_ıd";

                KalanStok.Visible = true;
                label18.Visible = true;
                cb_urunekle.Visible = false;
                label13.Text = "Teslim Tarihi : ";
            }
            else
            {
                cb_musterilistesi.DataSource = ctx.musterilers.Where(m => m.musteri_tip.ToString() == "Tedarikçi").ToList();
                cb_musterilistesi.DisplayMember = "musteriadsoyad";
                cb_musterilistesi.ValueMember = "musteri_ıd";

                KalanStok.Visible = false;
                label18.Visible = false;
                cb_urunekle.Visible = true;
                label13.Text = "Alım Tarihi : ";

                ara_toplam.Text = Convert.ToString(ctx.urunlers.Where(u => u.urun_ıd == cb_urunlistesi.SelectedValue.ToString()).FirstOrDefault().alıs_fiyatı.Value * Convert.ToInt32(nud_adet.Value));
            }

            genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));

        }

        private void nud_adet_ValueChanged_1(object sender, EventArgs e)
        {
            if (cb_faturatip.SelectedItem.ToString() == "Satis")
            {
                ara_toplam.Text = Convert.ToString(ctx.urunlers.Where(u => u.urun_ıd == cb_urunlistesi.SelectedValue.ToString()).FirstOrDefault().satıs_fiyatı.Value * Convert.ToInt32(nud_adet.Value));
            }
            else
            {
                ara_toplam.Text = Convert.ToString(ctx.urunlers.Where(u => u.urun_ıd == cb_urunlistesi.SelectedValue.ToString()).FirstOrDefault().alıs_fiyatı.Value * Convert.ToInt32(nud_adet.Value));
            }
            genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));

        }

        private void rb_KDV_CheckedChanged_1(object sender, EventArgs e)
        {
            
            if (rb_KDV.Checked == true)
            {
                faturaoran = 0.18f;
                genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));
            }
            else if (rb_KDV_yok.Checked == true)
            {
                faturaoran = 0;
                genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));
            }
            else
            {
                faturaoran = 0.5f;
                genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));

            }
            genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));
        
        }

        private void rb_KDV_yok_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rb_KDV.Checked == true)
            {
                faturaoran = 0.18f;
                genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));
            }
            else if (rb_KDV_yok.Checked == true)
            {
                faturaoran = 0;
                genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));
            }
            else
            {
                faturaoran = 0.5f;
                genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));

            }
            genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));
        
        }

        private void rb_tevkifatlı_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rb_KDV.Checked == true)
            {
                faturaoran = 0.18f;
                genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));
            }
            else if (rb_KDV_yok.Checked == true)
            {
                faturaoran = 0;
                genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));
            }
            else
            {
                faturaoran = 0.5f;
                genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));

            }
            genel_toplam.Text = Convert.ToString(Convert.ToInt32(ara_toplam.Text) + (faturaoran * Convert.ToInt32(ara_toplam.Text)));
       
        }

        private void alısSatısİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_ekle.Hide();
            pnl_musteri_ekle.Hide();
            pnl_Fatura_indirim.Hide();
            pnl_alis_satis.Show();
            pnl_fatura_duzenle.Hide();


            cb_urunlistesi.DataSource = ctx.urunlers.ToList();
            cb_urunlistesi.DisplayMember = "urun_ad";
            cb_urunlistesi.ValueMember = "urun_ıd";

            cb_urunekle.Checked = false;

            tb_musteriad.Clear();
            tb_musterisoyad.Clear();
            tb_musteritel.Clear();
            tb_vergino.Clear();
            tb_vergidairesi.Clear();
            tb_musteritel.Clear();
            tb_adres.Clear();

            tb_musteriad.ReadOnly = false;
            tb_musterisoyad.ReadOnly = false;





        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (nud_adet.Value==0)
                {
                    MessageBox.Show("eksik bilgi girisi");
                }


                else
                {
                    SqlParameter teslimtarihi = new SqlParameter("@teslimtarihi", Convert.ToDateTime(dtp_teslimtarihi.Text));
                    SqlParameter urun_ıd = new SqlParameter("@urun_id", cb_urunlistesi.SelectedValue.ToString());
                    SqlParameter musteri_ıd = new SqlParameter("@musteri_id", cb_musterilistesi.SelectedValue.ToString());
                    SqlParameter adet = new SqlParameter("@adet", Convert.ToInt32(nud_adet.Value));
                    SqlParameter oran = new SqlParameter("@oran", faturaoran);
                    SqlParameter fatura_tip = new SqlParameter("@fatura_tip", cb_faturatip.SelectedItem.ToString());

                    ctx.Database.ExecuteSqlCommand("proc_alissatisekle @musteri_id,@urun_id,@teslimtarihi,@adet,@fatura_tip,@oran", musteri_ıd, urun_ıd, teslimtarihi, adet, fatura_tip, oran);

                    MessageBox.Show("Ekleme basarılı");

                    var alimsatim = (from s in ctx.Alis_Satis
                                     select new
                                     {
                                         musteri_id = s.musteri_ıd,
                                         adsoyad = ctx.musterilers.Where<musteriler>(m => m.musteri_ıd == s.musteri_ıd).FirstOrDefault<musteriler>().musteriadsoyad.ToString(),
                                         urunad = ctx.urunlers.Where<urunler>(u => u.urun_ıd == s.urun_ıd).FirstOrDefault<urunler>().urun_ad.ToString(),
                                         adet = s.adet,
                                         fatura_durumu=s.fatura_durumu,
                                     }
                    ).Where(s => s.musteri_id == cb_musterilistesi.SelectedValue.ToString() && s.fatura_durumu=="yazılmadı").ToList();

                    dgv_alisatimlistesi.DataSource = alimsatim;

                    KalanStok.Text = ctx.urunlers.Where(u => u.urun_ıd == cb_urunlistesi.SelectedValue.ToString()).FirstOrDefault().stok.ToString();

                    btn_fatura.Visible = true;
                }

            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("eksik bilgi girisi");
            }


        }

        private void cb_musterilistesi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var alimsatim = (from s in ctx.Alis_Satis
                             select new
                             {
                                 musteri_id = s.musteri_ıd,
                                 adsoyad = ctx.musterilers.Where<musteriler>(m => m.musteri_ıd == s.musteri_ıd).FirstOrDefault<musteriler>().musteriadsoyad.ToString(),
                                 urunad = ctx.urunlers.Where<urunler>(u => u.urun_ıd == s.urun_ıd).FirstOrDefault<urunler>().urun_ad.ToString(),
                                 adet = s.adet,
                             }
               ).Where(s => s.musteri_id == cb_musterilistesi.SelectedValue.ToString()).ToList();

            dgv_alisatimlistesi.DataSource = alimsatim;
        }

        private void cb_urunekle_CheckedChanged(object sender, EventArgs e)
        {
            pnl_ekle.Show();
            pnl_musteri_ekle.Hide();
            pnl_alis_satis.Hide();
            pnl_Fatura_indirim.Hide();
            pnl_fatura_duzenle.Hide();

        }

        private void cb_musteri_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var liste = (from a in ctx.Alis_Satis
                         select new
                         {
                             musteri_id = a.musteri_ıd,
                             ad_soyad = ctx.musterilers.Where(m => m.musteri_ıd == a.musteri_ıd).FirstOrDefault().musteriadsoyad,
                             urun_id = a.urun_ıd,
                             ad = ctx.urunlers.Where<urunler>(u => u.urun_ıd == a.urun_ıd).FirstOrDefault().urun_ad,
                             adet = a.adet,
                             satısfiyat = ctx.urunlers.Where<urunler>(u => u.urun_ıd == a.urun_ıd).FirstOrDefault().satıs_fiyatı,
                             siparis_fiyatı = a.fiyat,
                             fatura_durumu = a.fatura_durumu,
                         }
                    ).Where(a=>a.musteri_id==cb_musteri.SelectedValue.ToString()&& a.fatura_durumu=="yazılmadı").ToList();

            dgv_fatura_indirim_listesi.DataSource = liste;
        }

        private void cb_urun_indirim_CheckedChanged(object sender, EventArgs e)
        {
            var liste = (from a in ctx.Alis_Satis
                         select new
                         {
                             musteri_id = a.musteri_ıd,
                             ad_soyad = ctx.musterilers.Where(m => m.musteri_ıd == a.musteri_ıd).FirstOrDefault().musteriadsoyad,
                             urun_id = a.urun_ıd,
                             ad = ctx.urunlers.Where<urunler>(u => u.urun_ıd == a.urun_ıd).FirstOrDefault().urun_ad,
                             adet = a.adet,
                             siparis_fiyatı = a.fiyat,
                             satısfiyat = ctx.urunlers.Where<urunler>(u => u.urun_ıd == a.urun_ıd).FirstOrDefault().satıs_fiyatı,
                             fatura_durumu=a.fatura_durumu,
                         }
                  ).Where(a => a.fatura_durumu == "yazılmadı").ToList();

            dgv_fatura_indirim_listesi.DataSource = liste;
            MessageBox.Show("urun id secin");

            cb_musteri.Visible = true;
            label4.Visible = true;
        }

        private void dgv_fatura_indirim_listesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (cb_urun_indirim.Checked == true)
            {
                try
                {
                    var urunlistesi = (from a in ctx.Alis_Satis
                                       select new
                                       {
                                           musteri_id = a.musteri_ıd,
                                           ad_soyad = ctx.musterilers.Where(m => m.musteri_ıd == a.musteri_ıd).FirstOrDefault().musteriadsoyad,
                                           urun_id = a.urun_ıd,
                                           ad = ctx.urunlers.Where<urunler>(u => u.urun_ıd == a.urun_ıd).FirstOrDefault().urun_ad,
                                           adet = a.adet,
                                           siparis_fiyatı = a.fiyat,
                                           satısfiyat = ctx.urunlers.Where<urunler>(u => u.urun_ıd == a.urun_ıd).FirstOrDefault().satıs_fiyatı,
                                           fatura_durumu = a.fatura_durumu,
                                       }
                   ).Where(a => a.musteri_id == cb_musteri.SelectedValue.ToString() && a.fatura_durumu == "yazılmadı" && a.urun_id == dgv_fatura_indirim_listesi.CurrentCell.Value.ToString()).ToList();

                    dgv_fatura_indirim_listesi.DataSource = urunlistesi;
                }
                catch (System.NotSupportedException)
                {
                    MessageBox.Show("lutfen urun id secin");
                }
            }

            else
            {
                try
                {
                    var faturalarindirimlistesi = (from f in ctx.faturas
                                                   select new
                                                   {
                                                       fatura_id = f.fatura_ıd,
                                                       musteri_ad = f.musteri_ad,
                                                       musteri_soyad = f.musteri_soyad,
                                                       siparis_fiyatı = f.siparis_fiyatı,

                                                   }

                    ).Where(m => m.fatura_id == dgv_fatura_indirim_listesi.CurrentCell.Value.ToString()).ToList();

                    dgv_fatura_indirim_listesi.DataSource = faturalarindirimlistesi;
                    dgv_fatura_indirim_listesi.Enabled = false;
                    MessageBox.Show("id secildi");


                }
                catch (System.NotSupportedException)
                {
                    MessageBox.Show("lutfen fatura id secin");
                }
            }
            
        }

        private void dgv_urunlerlistesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
               var urunlistesi = (from u in ctx.urunlers
                                   select new
                                   {
                                       urun_id = u.urun_ıd,
                                       ad = u.urun_ad,
                                       kategori = u.kategori.ad,
                                       marka = u.marka.marka_adı,
                                       stok = u.stok,
                                       alısfiyat = u.alıs_fiyatı,
                                       satısfiyat = u.satıs_fiyatı,
                                   }

               ).Where(u => u.urun_id == dgv_urunlerlistesi.CurrentCell.Value.ToString()).ToList();

               dgv_urunlerlistesi.DataSource = urunlistesi;

               try
               {

                   tb_urunad.Text = ctx.urunlers.Where(u => u.urun_ıd == dgv_urunlerlistesi.CurrentCell.Value.ToString()).FirstOrDefault().urun_ad.ToString();

                   nud_stok.Value = ctx.urunlers.Where(u => u.urun_ıd == dgv_urunlerlistesi.CurrentCell.Value.ToString()).FirstOrDefault().stok.Value;

                   tb_alısfiyatı.Text = urunlistesi.FirstOrDefault().alısfiyat.ToString();

                   cb_kategori.SelectedValue = ctx.urunlers.Where(u => u.urun_ıd == dgv_musterilerlistesi.CurrentCell.Value.ToString()).FirstOrDefault().kategori_ID;

                   cb_marka.SelectedValue = ctx.urunlers.Where(u=>u.urun_ıd == dgv_urunlerlistesi.CurrentCell.Value.ToString()).FirstOrDefault().marka_id;

                   tb_satısfiyatı.Text = urunlistesi.FirstOrDefault().satısfiyat.ToString();

                   dgv_urunlerlistesi.DataSource = urunlistesi;
                   btn_urun_guncelle.Visible = true;

                   tb_urunad.ReadOnly = true;

                   cb_kategori.Enabled = false;
                   cb_marka.Enabled = false;

               }
               catch (Exception)
               {
                   MessageBox.Show("lutfen id secin");

                   var urunlerlistesi = (from u in ctx.urunlers
                                         select new
                                         {
                                             urun_id = u.urun_ıd,
                                             ad = u.urun_ad,
                                             kategori = u.kategori.ad,
                                             marka = u.marka.marka_adı,
                                             stok = u.stok,
                                             alısfiyat = u.alıs_fiyatı,
                                             satısfiyat = u.satıs_fiyatı,
                                         }
                   ).ToList();

                   dgv_urunlerlistesi.DataSource = urunlerlistesi;
               }

        }

        private void dgv_fatura_dokum_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            try
            {
                    var faturalistesi = (from f in ctx.faturas
                                         select new
                                         {
                                             fatura_id = f.fatura_ıd,
                                             fiyat = f.siparis_fiyatı,
                                             tarihi = f.fatura_tarih,
                                             musteri_id = f.musteri_ıd,
                                             ad = f.musteri_ad,
                                             soyad = f.musteri_soyad,
                                             vergi_no = f.musteri_vergi_no,
                                             vergi_dairesi = f.musteri_vergi_dairesi,
                                         }
                        ).Where(f=>f.fatura_id==dgv_fatura_dokum.CurrentCell.Value.ToString()).ToList();

                    dgv_fatura_dokum.DataSource = faturalistesi;
             }

            catch (Exception)
            {
                MessageBox.Show("lutfen id secin");
            }

            MessageBox.Show(dgv_fatura_dokum.RowCount.ToString());


            if (dgv_fatura_dokum.RowCount.ToString() == "0")
            {
                var faturalistesi = (from f in ctx.faturas
                                     select new
                                     {
                                         fatura_id = f.fatura_ıd,
                                         fiyat = f.siparis_fiyatı,
                                         tarihi = f.fatura_tarih,
                                         musteri_id = f.musteri_ıd,
                                         ad = f.musteri_ad,
                                         soyad = f.musteri_soyad,
                                         vergi_no = f.musteri_vergi_no,
                                         vergi_dairesi = f.musteri_vergi_dairesi,
                                     }
                        ).ToList();

                dgv_fatura_dokum.DataSource = faturalistesi;
            }
                
        }

        private void btn_yazdır_Click(object sender, EventArgs e)
        {
            raporekranı.Visible = true;

            var data = ctx.faturas.Where(f => f.fatura_ıd == dgv_fatura_dokum.CurrentCell.Value.ToString()).ToList();
            this.faturaBindingSource.DataSource = data;
            this.raporekranı.RefreshReport();
            var reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "stajprojeDataSet1";
            reportDataSource1.Value = data;
            this.raporekranı.LocalReport.DataSources.Add(reportDataSource1);
            this.raporekranı.RefreshReport();
            
        }





       }    

    }

