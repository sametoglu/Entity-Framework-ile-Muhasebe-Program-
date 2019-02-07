namespace WindowsFormsApplication2
{
    partial class Giris
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
            this.tb_kullanıcıadı = new System.Windows.Forms.TextBox();
            this.cb_tur = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_kullanıcıadı
            // 
            this.tb_kullanıcıadı.Location = new System.Drawing.Point(88, 35);
            this.tb_kullanıcıadı.MaxLength = 15;
            this.tb_kullanıcıadı.Name = "tb_kullanıcıadı";
            this.tb_kullanıcıadı.Size = new System.Drawing.Size(184, 20);
            this.tb_kullanıcıadı.TabIndex = 0;
            // 
            // cb_tur
            // 
            this.cb_tur.AutoSize = true;
            this.cb_tur.Location = new System.Drawing.Point(184, 12);
            this.cb_tur.Name = "cb_tur";
            this.cb_tur.Size = new System.Drawing.Size(88, 17);
            this.cb_tur.TabIndex = 1;
            this.cb_tur.Text = "Yeni kullanıcı";
            this.cb_tur.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sifre : ";
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(88, 61);
            this.tb_sifre.MaxLength = 15;
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(184, 20);
            this.tb_sifre.TabIndex = 4;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(12, 87);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(260, 40);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "Giris";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_tur);
            this.Controls.Add(this.tb_kullanıcıadı);
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_kullanıcıadı;
        private System.Windows.Forms.CheckBox cb_tur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.Button btn_giris;
    }
}