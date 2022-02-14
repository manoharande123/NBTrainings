using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManoharLibrary
{
    public static class Mathematics
    {
        public static int Factorial(int n)
        {
            
            int fact = 1;
            for (int i = 1; i<n; i++)
                fact = fact * i;
            return fact;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Mul(int a , int b)
        {
            return a * b;
        }
    }
}
