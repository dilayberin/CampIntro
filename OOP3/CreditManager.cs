using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{//kredilerde temelde hesaplama işlemi özelleştirilerek 
    //yapılacağından interface kullandık.
     interface ICreditManager
    {
        void Compute();
        void Add();
       
    }
}
