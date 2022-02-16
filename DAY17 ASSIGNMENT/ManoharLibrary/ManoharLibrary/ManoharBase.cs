using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManoharLibrary
{
    //BASECLASS
    public class ManoharBase
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        

        
        public void ReadData()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
        }
    }
    //DERIVEDCLASS
    public class ManoharDerived: ManoharBase
    {
       
        public void ReadDerivedDaa()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
        }
    }
    //OTHERCLASS
    public class ManoharOther
    {
        
       //Otherclass

        public void ReadOtherData()
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
