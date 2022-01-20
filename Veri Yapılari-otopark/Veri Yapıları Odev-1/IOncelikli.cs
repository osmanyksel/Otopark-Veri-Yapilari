using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Odev_1
{
    public  interface IOncelikli
    {
        void Insert(object o, int sure);
        void Remove();
        object Peek();

        object SurePeek();
        Boolean IsEmpty();
    }
}
