using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManoharLibrary1
{
    public class Physics
    {
        public static int GetVelocity(int u, int a, int t)
        {
            return u + a*t;
        }
    }
}
