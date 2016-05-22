using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface Zylinder
    {
        int Laenge1
        {
            get;
            set;
        }

        int Laenge2
        {
            get;
            set;
        }

        string Faerbung
        {
            get;
            set;
        }

        void LaengeAendern(int l1, int l2);

        void Print();
    }
}
