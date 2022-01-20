namespace Veri_Yapıları_Odev_1
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
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtBasitKuyruk = new System.Windows.Forms.TextBox();
            this.txtOncelikliKuyruk = new System.Windows.Forms.TextBox();
            this.txtİslemKıyaslama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOtoparkBekleme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBirsonrakiCikis = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.btnİslemleriKıyasla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFifo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblOrtalamaFifo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblÖncelikli = new System.Windows.Forms.Label();
            this.lblOrtalamaOncelikli = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblKazanc = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(99, 24);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 22);
            this.txtNo.TabIndex = 0;
            // 
            // txtBasitKuyruk
            // 
            this.txtBasitKuyruk.Enabled = false;
            this.txtBasitKuyruk.Location = new System.Drawing.Point(291, 27);
            this.txtBasitKuyruk.Multiline = true;
            this.txtBasitKuyruk.Name = "txtBasitKuyruk";
            this.txtBasitKuyruk.Size = new System.Drawing.Size(257, 203);
            this.txtBasitKuyruk.TabIndex = 0;
            // 
            // txtOncelikliKuyruk
            // 
            this.txtOncelikliKuyruk.Enabled = false;
            this.txtOncelikliKuyruk.Location = new System.Drawing.Point(622, 27);
            this.txtOncelikliKuyruk.Multiline = true;
            this.txtOncelikliKuyruk.Name = "txtOncelikliKuyruk";
            this.txtOncelikliKuyruk.Size = new System.Drawing.Size(225, 203);
            this.txtOncelikliKuyruk.TabIndex = 0;
            // 
            // txtİslemKıyaslama
            // 
            this.txtİslemKıyaslama.Enabled = false;
            this.txtİslemKıyaslama.Location = new System.Drawing.Point(909, 27);
            this.txtİslemKıyaslama.Multiline = true;
            this.txtİslemKıyaslama.Name = "txtİslemKıyaslama";
            this.txtİslemKıyaslama.Size = new System.Drawing.Size(316, 203);
            this.txtİslemKıyaslama.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Araba No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Otoparkta Bekleme Süreniz:";
            // 
            // lblOtoparkBekleme
            // 
            this.lblOtoparkBekleme.AutoSize = true;
            this.lblOtoparkBekleme.Location = new System.Drawing.Point(202, 81);
            this.lblOtoparkBekleme.Name = "lblOtoparkBekleme";
            this.lblOtoparkBekleme.Size = new System.Drawing.Size(16, 17);
            this.lblOtoparkBekleme.TabIndex = 9;
            this.lblOtoparkBekleme.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bir sonraki çıkış için bekleme süresi: ";
            // 
            // lblBirsonrakiCikis
            // 
            this.lblBirsonrakiCikis.AutoSize = true;
            this.lblBirsonrakiCikis.Location = new System.Drawing.Point(253, 131);
            this.lblBirsonrakiCikis.Name = "lblBirsonrakiCikis";
            this.lblBirsonrakiCikis.Size = new System.Drawing.Size(16, 17);
            this.lblBirsonrakiCikis.TabIndex = 11;
            this.lblBirsonrakiCikis.Text = "0";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(24, 194);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 35);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCıkar
            // 
            this.btnCıkar.Location = new System.Drawing.Point(142, 194);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(87, 35);
            this.btnCıkar.TabIndex = 12;
            this.btnCıkar.Text = "Çıkar";
            this.btnCıkar.UseVisualStyleBackColor = true;
            this.btnCıkar.Click += new System.EventHandler(this.btnCıkar_Click);
            // 
            // btnİslemleriKıyasla
            // 
            this.btnİslemleriKıyasla.Location = new System.Drawing.Point(1009, 260);
            this.btnİslemleriKıyasla.Name = "btnİslemleriKıyasla";
            this.btnİslemleriKıyasla.Size = new System.Drawing.Size(115, 56);
            this.btnİslemleriKıyasla.TabIndex = 13;
            this.btnİslemleriKıyasla.Text = "İşlemleri Kıyasla";
            this.btnİslemleriKıyasla.UseVisualStyleBackColor = true;
            this.btnİslemleriKıyasla.Click += new System.EventHandler(this.btnİslemleriKıyasla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Basit Kuyruk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Öncelikli Kuyruk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(853, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(382, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Basit Kuruğa Göre Öncelikli Kuyrukta Daha Az Bekleyenler ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(833, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Not:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(861, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Listeler Boşalmadan İşlem Kıyaslaması Yapılamaz.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(9, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Not:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(49, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Bütün Süreler Saniye Cinsindedir.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(269, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "FİFO Kuyruğu İçin Toplam İşlem Süresi:";
            // 
            // lblFifo
            // 
            this.lblFifo.AutoSize = true;
            this.lblFifo.Location = new System.Drawing.Point(522, 250);
            this.lblFifo.Name = "lblFifo";
            this.lblFifo.Size = new System.Drawing.Size(16, 17);
            this.lblFifo.TabIndex = 17;
            this.lblFifo.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(269, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "FİFO Kuyruğunda Ortalama  İşlem Süresi:";
            // 
            // lblOrtalamaFifo
            // 
            this.lblOrtalamaFifo.AutoSize = true;
            this.lblOrtalamaFifo.Location = new System.Drawing.Point(533, 280);
            this.lblOrtalamaFifo.Name = "lblOrtalamaFifo";
            this.lblOrtalamaFifo.Size = new System.Drawing.Size(16, 17);
            this.lblOrtalamaFifo.TabIndex = 17;
            this.lblOrtalamaFifo.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(619, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(269, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Öncelikli Kuyruk İçin Toplam İşlem Süresi:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(619, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(271, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Öncelikli Kuyrukta Ortalama  İşlem Süresi:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblÖncelikli
            // 
            this.lblÖncelikli.AutoSize = true;
            this.lblÖncelikli.Location = new System.Drawing.Point(883, 250);
            this.lblÖncelikli.Name = "lblÖncelikli";
            this.lblÖncelikli.Size = new System.Drawing.Size(16, 17);
            this.lblÖncelikli.TabIndex = 17;
            this.lblÖncelikli.Text = "0";
            // 
            // lblOrtalamaOncelikli
            // 
            this.lblOrtalamaOncelikli.AutoSize = true;
            this.lblOrtalamaOncelikli.Location = new System.Drawing.Point(883, 280);
            this.lblOrtalamaOncelikli.Name = "lblOrtalamaOncelikli";
            this.lblOrtalamaOncelikli.Size = new System.Drawing.Size(16, 17);
            this.lblOrtalamaOncelikli.TabIndex = 17;
            this.lblOrtalamaOncelikli.Text = "0";
            this.lblOrtalamaOncelikli.Click += new System.EventHandler(this.lblOrtalamaOncelikli_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(355, 453);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Not:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(392, 453);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Otopark Kapasitesi 10\'dur.";
            this.label16.Click += new System.EventHandler(this.label10_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(833, 418);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 17);
            this.label17.TabIndex = 15;
            this.label17.Text = "Not:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Navy;
            this.label18.Location = new System.Drawing.Point(861, 418);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(367, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "İşlem Kıyaslaması Toplam İşlem Üzerinden Yapılmaktadır.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(564, 317);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(324, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Ortalama İşlem Tamamlanma Süresindeki Kazanç:";
            this.label19.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblKazanc
            // 
            this.lblKazanc.AutoSize = true;
            this.lblKazanc.Location = new System.Drawing.Point(883, 317);
            this.lblKazanc.Name = "lblKazanc";
            this.lblKazanc.Size = new System.Drawing.Size(16, 17);
            this.lblKazanc.TabIndex = 17;
            this.lblKazanc.Text = "0";
            this.lblKazanc.Click += new System.EventHandler(this.lblOrtalamaOncelikli_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.DarkBlue;
            this.label21.Location = new System.Drawing.Point(833, 390);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(392, 17);
            this.label21.TabIndex = 15;
            this.label21.Text = "Toplam İşlem Süresi=İşlem Süresi+Otoparkta Bekleme Süresi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1237, 491);
            this.Controls.Add(this.lblKazanc);
            this.Controls.Add(this.lblOrtalamaOncelikli);
            this.Controls.Add(this.lblOrtalamaFifo);
            this.Controls.Add(this.lblÖncelikli);
            this.Controls.Add(this.lblFifo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnİslemleriKıyasla);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblBirsonrakiCikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOtoparkBekleme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtİslemKıyaslama);
            this.Controls.Add(this.txtOncelikliKuyruk);
            this.Controls.Add(this.txtBasitKuyruk);
            this.Controls.Add(this.txtNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtBasitKuyruk;
        private System.Windows.Forms.TextBox txtOncelikliKuyruk;
        private System.Windows.Forms.TextBox txtİslemKıyaslama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOtoparkBekleme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBirsonrakiCikis;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.Button btnİslemleriKıyasla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFifo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblOrtalamaFifo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblÖncelikli;
        private System.Windows.Forms.Label lblOrtalamaOncelikli;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblKazanc;
        private System.Windows.Forms.Label label21;
    }
}

