using System;
using System.Collections.Generic;
using System.Text;

namespace just.For.practice
{
    public class CodeArena
    {
        public static void ReverseString(string item)
        {
            char[] str = item.ToCharArray();
            for (int i = 0, j = item.Length - 1; i < j; i++, j--)
            {

                str[i] = item[j];
                str[j] = item[i];
            }
            var ss = new string(str);

            Console.WriteLine(ss);
        }

        public void Main(string[] args)
        {

            ReverseString("HEllo");
        }
    }
}
