using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Odev_1
{
    public class BasitKuyruk : IBasitKuyruk
    {
        private object[] Kuyruk;
        public int[] Sureler;//Kuyruktaki arabaların sürelerini tutuyor. 
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public int ToplamSure = 0;  /*Toplam süre  ve sayac N tane arabanın çıkışında ortalama süreyi buluyor.*/
        public int sayac = 0;

        public BasitKuyruk(int size)
        {
            this.size = size;
            Kuyruk = new object[size];
            Sureler = new int[size];

        }
        public void Insert(object o, int sure)
        {
            if ((count == size) || (rear == size - 1))
            {
                HataMesajıD();
                return;
            }
            if (front == -1)
                front = 0;

            Kuyruk[++rear] = o;
            Sureler[rear] = sure;
            count++;

        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Kuyruk[front];
        }
        public object SurePeek()
        {
            return Sureler[front];
        }

        public void Remove()
        {
            if (IsEmpty())
            {
                HataMesajıB();
                return;
            }
            else
            {
                sayac++;
                object temp = Kuyruk[front];
                Kuyruk[front] = null;
                ToplamSure += Sureler[front];
                front++;
                count--;
            }

        }

        public string KuyrukListele()
        {
            string temp = "";
            for (int i = 0; i < Kuyruk.Length; i++)
            {
                if (Kuyruk[i] == null)
                    continue;
                temp += "Araba No:" + Kuyruk[i] + "--->İşlem Süresi:" + Sureler[i] + Environment.NewLine;
            }

            return temp;
        }
        public void SureArttır(int sure)
        {
            Sureler[front] += sure;
        }
        public string HataMesajıD()
        {
            return "Kuyruk Dolu";
        }
        public string HataMesajıB()
        {
            return "Kuyruk Boş";
        }

    }
}
