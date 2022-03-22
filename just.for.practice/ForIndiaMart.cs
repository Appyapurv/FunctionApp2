//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace just.For.practice
//{
//    class ForIndiaMart
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Number of input:");
//            int totalNumber = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter All 6 values Values:");
//            string values = Console.ReadLine();
//            string[] valueArray = values.Split(' ');
//            double totalValue = valueArray.Length;
//            Console.WriteLine(valueArray[1]);//display reacord at location 2 in an array
//            int temp = 0;
//            //swap between 2 and index 6
//            temp = Convert.ToInt32(valueArray[1]);
//            valueArray[1] = valueArray[5];
//            valueArray[5] = temp.ToString();

//            for (int i = 0; i < valueArray.Length; i++)
//            {
//                Console.Write($" {valueArray[i]} ");

//            }
//            Console.WriteLine("");
//            // swap 2 & 4
//            temp = Convert.ToInt32(valueArray[1]);
//            valueArray[1] = valueArray[3];
//            valueArray[3] = temp.ToString();

//            for (int i = 0; i < valueArray.Length; i++)
//            {
//                Console.Write($" {valueArray[i]} "); ;

//            }

//            var value = Array.Find(valueArray, o => o.StartsWith("9", StringComparison.Ordinal));
//            if (value == null)
//            {

//            }

//            var indexValue = Array.FindIndex(valueArray, o => o.Contains("3"));
//            var List = new List<String>();
//            var ss = List.ToArray();
//            //  List = valueArray.();

//            Array.FindAll(valueArray, o => o.Contains("1"));
//            List.Find(s => s.Contains("1"));
//        }
//    }
//}
