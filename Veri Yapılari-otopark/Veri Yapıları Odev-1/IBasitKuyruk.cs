using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Odev_1
{
    public  interface IBasitKuyruk
    {
        void Insert(object o, int sure);
        void Remove();
        object Peek();
        object SurePeek();
        string KuyrukListele();
        Boolean IsEmpty();
    }
}
