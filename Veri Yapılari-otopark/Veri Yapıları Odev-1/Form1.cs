using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapıları_Odev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Otopark otopark = new Otopark();
        BasitKuyruk kuy = new BasitKuyruk(10);
        OncelikliKuyruk pkuy = new OncelikliKuyruk(10);

        DateTime giris; //Otopark için giriş çıkışları tutuyorlar. 
        DateTime cikis;

        int islem;//cikis-giris
        int bekleme;//Otopark çıkışlarında bir sonraki çıkış için beklenen süreyi tutuyor.

        object[] temp = new object[10];
        object[] ptemp = new object[10];

        int sayac = 0;
        float İslemKazancı = 0;

        private void btnEkle_Click(object sender, EventArgs e)
        {

            otopark.a = new Araba();
            kuy.Insert(otopark.a.Numara, otopark.a.İslemSuresi);
            pkuy.Insert(otopark.a.Numara, otopark.a.İslemSuresi);
            giris = Convert.ToDateTime(DateTime.Now.ToString());
            txtNo.Text = otopark.a.Numara.ToString();
            Listeleme();//Butona bastıgında fifo ve öncelikli kuyruk güncelleniyor.




        }

        private void btnCıkar_Click(object sender, EventArgs e)
        {
            if (!kuy.IsEmpty())
            {
                Random r = new Random();
                cikis = Convert.ToDateTime(DateTime.Now.ToString());
                TimeSpan ts = cikis - giris;
                islem = Convert.ToInt32(ts.Seconds);
                lblOtoparkBekleme.Text = islem.ToString();

                kuy.SureArttır(islem);//Çıkış butonuna bastığında otoparkta beklenen süre ekleniyor.
                pkuy.SureArttır(islem);

                lblFifo.Text = (kuy.SurePeek()).ToString();
                lblÖncelikli.Text = pkuy.SurePeek().ToString();

                temp[sayac] = kuy.Peek();//Listeler boşalınca işlem kıyaslaması için kuyruktan silinen elemanlar bu dizilere atanıyor.
                ptemp[sayac] = pkuy.Peek();

                kuy.Remove();
                pkuy.Remove();

                lblOrtalamaFifo.Text = (kuy.ToplamSure / kuy.sayac).ToString();
                lblOrtalamaOncelikli.Text = (pkuy.ToplamSure / pkuy.sayac).ToString();

                İslemKazancı = Convert.ToSingle((kuy.ToplamSure / kuy.sayac)- (pkuy.ToplamSure / pkuy.sayac));
                İslemKazancı = İslemKazancı / 100;
                lblKazanc.Text = İslemKazancı.ToString();

                Listeleme();//Butona bastıgında fifo ve öncelikli kuyruk güncelleniyor.

                bekleme = r.Next(10, 300); //Otaparktan Çıkınca Bir Sonraki Çıkış İçin Bekleme Süresi Belirleniyor.
                timer1.Enabled = true;
                lblBirsonrakiCikis.Text = bekleme.ToString();
                btnCıkar.Enabled = false;
                sayac++;
            }
            else
            {
                MessageBox.Show("Kuyruk Boş");
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bekleme--;
            lblBirsonrakiCikis.Text = bekleme.ToString();
            if (bekleme == 0)
            {
                timer1.Enabled = false;
                btnCıkar.Enabled = true;
            }
        }

        private void btnİslemleriKıyasla_Click(object sender, EventArgs e)
        {
            if (kuy.IsEmpty())//Kuyruklar Boşalınca İşlem Kıyaslaması Yapıyor.
            {
                txtİslemKıyaslama.Text = İslemKıyaslama();
            }
        }
        private void Listeleme()
        {
            txtBasitKuyruk.Text = kuy.KuyrukListele();
            txtOncelikliKuyruk.Text = pkuy.OncelikliKuyrukListele();
        }
        private string İslemKıyaslama()
        {
            string DahaAzBekleyenler = "";
            for (int i = 0; i < sayac; i++)
            {
                for (int j = 0; j < sayac; j++)
                {
                    if ((int)temp[i] == (int)ptemp[j])
                    {
                        if (kuy.Sureler[i] > pkuy.Sureler[j])
                        {
                            DahaAzBekleyenler += "Araba NO:" + ptemp[i].ToString() + "---->Toplam İşlem Süresi:" + pkuy.Sureler[j].ToString() + Environment.NewLine;
                        }
                        break;
                    }
                }
            }
            return DahaAzBekleyenler;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblOrtalamaOncelikli_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
