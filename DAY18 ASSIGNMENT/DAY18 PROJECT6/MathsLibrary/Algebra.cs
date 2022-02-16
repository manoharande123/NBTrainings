using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public class Algebra
    {

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n > 7)
            {
                return -999;
            }
            else if (n < 0)
            {
                return -9999;
            }
            else
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)

                    fact = fact * i;
                return fact;
            }

        }
        public static string Palindrome(int n)
        {
            int m, rem, rev = 0;
            m = n;
            while(m>0)
            {
                rem = m % 10;
                rev = (rev * 10) + rem;
                m = m / 10;
            }
            if (n == rev)

                return "Palindrome";
            else
                return "not palindrome";
            
          
        }
           


        



    }
}
