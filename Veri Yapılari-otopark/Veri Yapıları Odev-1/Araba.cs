using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Odev_1
{
    public  class Araba
    {
        public int Numara { get; set; }
        public int İslemSuresi { get; set; }

        Random r = new Random();
        public Araba()
        {
            İslemSuresi = r.Next(1, 30);
            Numara = r.Next(1, 30);
        }
    }
}
