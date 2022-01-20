using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Odev_1
{
    public class OncelikliKuyruk : IOncelikli
    {
        public object[] Kuyruk;
        public int[] Sureler;
        private int front = -1;
        private int size = 0;
        private int count = 0;
        public int ToplamSure = 0;
        public int sayac = 0;

        public OncelikliKuyruk(int size)
        {
            this.size = size;
            Kuyruk = new object[size];
            Sureler = new int[size];

        }


        public void Insert(object o, int sure)
        {
            if (count == size)
            {
                HataMesajıD();
                return;
            }
            else if (IsEmpty())
            {
                front++;
                Kuyruk[front] = o;
                Sureler[front] = sure;
                count++;

            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if (sure > Sureler[i])
                    {
                        Sureler[i + 1] = Sureler[i];
                        Kuyruk[i + 1] = Kuyruk[i];
                    }
                    else
                        break;
                }
                Sureler[i + 1] = sure;
                Kuyruk[i + 1] = o;
                front++;
                count++;

            }
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
            if (this.IsEmpty())
            {
                HataMesajıB();
                return;
            }
            else
            {
                sayac++;
                Kuyruk[front] = null;
                ToplamSure += Sureler[front];
                front--;
                count--;

            }
        }
        public string OncelikliKuyrukListele()
        {
            string temp = "";
            for (int i = front; i >= 0; i--)
            {
                if (Kuyruk[i] == null)
                    continue;
                temp += "Araba No:" + Kuyruk[i] + "------->İşlem Süresi:" + Sureler[i] + Environment.NewLine;
            }
            return temp;
        }
        public void SureArttır(int sure)
        {
            Sureler[front] += sure;
        }
        public string HataMesajıD()
        {
            return "Öncelikli Kuyruk Dolu";
        }
        public string HataMesajıB()
        {
            return "Öncelikli Kuyruk Boş";
        }
    }
}
