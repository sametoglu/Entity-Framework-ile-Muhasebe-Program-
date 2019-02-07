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


namespace WindowsFormsApplication2
{
    using Models;

    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        stajprojeContext ctx = new stajprojeContext();
        Form1 Form1 = new Form1();

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (cb_tur.Checked==true)
            {
                SqlParameter kullaniciad = new SqlParameter("@kullanıcıad", tb_kullanıcıadı.Text);
                SqlParameter sifre = new SqlParameter("sifre", tb_sifre.Text);

                ctx.Database.ExecuteSqlCommand("proc_personelekle @kullanıcıad,@sifre", kullaniciad, sifre);

                MessageBox.Show("Giris basarılı");
                this.Hide();
                Form1.Show();
            }
            else
            {
                if (ctx.personels.Where(p=>p.kullanıcı_ad==tb_kullanıcıadı.Text).Count()>0)
                {
                    if (ctx.personels.Where(p=>p.sifre==tb_sifre.Text).Count()>0)
                    {
                        this.Hide();
                        Form1.Show();
                        MessageBox.Show("giriş başarılı");
                    }
                    else
                    {
                        MessageBox.Show("sifre yanlış");
                    }
                }
            }
        }
    }
}
