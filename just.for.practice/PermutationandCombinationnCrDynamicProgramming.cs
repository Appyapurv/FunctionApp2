using System;
using System.Collections.Generic;
using System.Text;

namespace just.For.practice
{
    //A dynamic programming based
    //solution to compute nCr % p
    class PermutationandCombinationnCrDynamicProgramming
    {
        static int NCrModp(int n, int r, int p)
        {
            //the array c is going to store last
            //row of pascal triangle at the end.
            //And last entry of last row is nCr
            int[] c = new int[r + 1];
            for (int i = 0; i < r + 1; i++)
                c[i] = 0;

            c[0] = 1;//top row of triangle pascal

            //one by constructs remaining rows
            //of pascal Triangle from Top to bottom 
            for (int i = 1; i <= n; i++)
            {
                //fill entites for current row using
                //previous row values
                for (int j = Math.Min(i, r); j > 0; j--)
                {
                    //nCj= (n-1)Cj+(n-1)c(j-1);
                    c[j] = (c[j] + c[j - 1]) % p;
                }
            }
            var ss = c[r];

            return ss;
        }

        public static void Main(string[] args)
        {
            int n = 10, r = 2, p = 13;
            Console.WriteLine($"Value of nCr % {NCrModp(n, r, p)}");
        }
    }
}
