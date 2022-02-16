using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManoharLibrary;

namespace PublicLibrary
{

    //derivedclass
    public class Publicbase:ManoharBase
    {
        
               public void PublicData()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
        }
    }
    //otherclass
    public class PublicOther
    {
        public void ReadOher()
        {
            ManoharBase m = new ManoharBase();
            m.a = 1;
            m.b = 2;
            m.c = 3;
            m.d = 4;
            m.e = 5;
        }
    }
}
