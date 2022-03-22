////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text.RegularExpressions;

////namespace just.For.practice
////{

////    class Program
////    {
////        //public string SleepTime { get; set; }
////        //public string WakeTime { get; set; }
////         void main(string[] args)
////        {
            
            
////               // BufferedReader br = new BufferedReader(new InputStreamReader(System.in));




////            //int kases = Int32.Parse(System.Console.ReadLine().Trim());
////            //for (int kase = 1; kase <= kases; kase++)
////            //{
////            //    int N = Int32.Parse(System.Console.ReadLine().Trim());
////            //    List<int> result = new List<int>();
////            //    result.Add(1);
////            //    int temp, carry = 0;
////            //    for (int i = 2; i <= N; i++)
////            //    {
////            //        for (int j = 0; j < result.Count; j++)
////            //        {
////            //            temp = carry + result[j] * i;
////            //            carry = temp / 10;
////            //            result[j] = temp % 10;
////            //        }
////            //        while (carry > 0)
////            //        {
////            //            result.Add(carry % 10);
////            //            carry /= 10;
////            //        }
////            //    }
////            //    for (int i = result.Count - 1; i >= 0; i--)
////            //    {
////            //        Console.Write(result[i]);
////            //    }
////            //    Console.Write("\n");


////            //}

////            //int[] array = { 4, 1, 2, 2, 1 };
////            //int sum = 0;
////            //foreach (var ss in array)
////            //{
////            //    sum += ss;
////            //}
////            //Console.WriteLine($"Sum:{sum} ");

////            //Console.WriteLine("Enter Input:");
////            //string value = Convert.ToString(Console.ReadLine());
////            //var ss1 = value.Split(" ");
////            //var Values = new List<string>();
////            //string[] arr = ss1.ToArray();
////            //int sum = 0;         
////            //for (int i = 0; i < arr.Length; i++)
////            //{
////            //    sum += Convert.ToInt32(arr[i]);
////            //}

////            //Console.WriteLine($"sum:{sum}");

////            // var SleepTime = "10:40 PM";
////            //Console.WriteLine("Enter the Time");
////            //var SleepTime = Convert.ToString(Console.ReadLine());
////            //var ss = new Regex("((1[0-2]|0?[1-9]):([0-5][0-9]) ?([AaPp][Mm]))");
////            //var value = ss.IsMatch(SleepTime);
////            //if (value == true)
////            //{
////            //    Console.WriteLine($"true:{value}");
////            //}
////            //Console.WriteLine($"False:{value}");






////            //int num1 = 20;
////            //int num2 = 30;
////            //num1 ^= num2 ^= num1 ^= num2;
////            //Console.WriteLine(num1 + "," + num2);













////            //    Program p = new Program();
////            //    p.print(2, 3, 8);
////            //    int[] arr = { 2, 11, 15, 20 };
////            //    p.print(arr);
////            //    Console.ReadLine();

////            //int[] arr = new int[10];
////            //array(arr);
////            //Console.WriteLine(arr.Length);

////            //String a = "TechBeamerssomeeeess";
////            //String b = "TECHBEAMERSsome";
////            //int c;
////            //c = a.CompareTo(b);
////            //Console.WriteLine(c);
////            //int[] arr = new int[2];
////            //arr[1] = 10;
////            //Object o = arr;
////            //int[] arr1 = (int[])o;
////            //arr1[1] = 100;
////            //Console.WriteLine(arr[1]);
////            //((int[])o)[1] = 1000;
////            //Console.WriteLine(arr[1]);

////            //#if (!pi)
////            //    Console.WriteLine("i");
////            //        #else
////            //            Console.WriteLine("PI undefined");
////            //#endif
////            //    Console.WriteLine("ok");
////            //    Console.ReadLine();
////            //    //byte num = 100;
////            //dynamic value = num;
////            //Console.WriteLine(value.GetType());
////            //value += 100;
////            //Console.WriteLine(value.GetType());
////            //int[] i = new int[0];
////            //Console.WriteLine(i[0]);

////            //Console.WriteLine(Math.Round(5.5));
////            //Console.WriteLine(Math.Round(21.5));
////            //int value=10; int value1= 20; int value3= 40;
////            ////int result = 1000000000;
////            ////int[] numbers = { 1, 2, 3, 4, 5, 6 };
////            ////output= 6,5,4,3,2,1
////            ////\\\\ type= 444444; ///\\\ user=7887644;
////            //var start = 0;
////            //var end = numbers.Length - 1;

////            ////whileloop till it swap
////            //while (start < end)
////            //{
////            //    var swap = numbers[start];
////            //    numbers[start] = numbers[end];
////            //    numbers[end] = swap;

////            //    start++;
////            //    end--;
////            //}

////            //for (int i = 1; i < numbers.Length; i++)
////            //{
////            //    Console.Write($"{numbers[i]}");
////            //}

////            //int[] array = { 1, 2, 3, 4, 5 };
////            //// int start = array[0];
////            //int end = array.Length - 1;
////            //int start = 0;

////            //while (start < end)
////            //{
////            //    var temp = array[start];
////            //    array[start] = array[end];
////            //    array[end] = temp;
////            //    start++;
////            //    end--;
////            //}

////            ////swap

////            //for (int i = 0; i < array.Length; i++)
////            //{
////            //    Console.Write($"{array[i]}");
////            //}



////            //int [] i = new int [1];
////            //i[0]= array[0];
////            //array[0] = array[4];
////            //array[4] = i[0];
////            //foreach (var ss in array)
////            //{
////            //    Console.Write($"{ss}");
////            //}


////            //Console.WriteLine("Enter the Number");
////            //int number = Convert.ToInt32(Console.ReadLine());
////            //for (int i = 1; i <= number; i++)
////            //{
////            //    var value = (i % (3 * 7) == 0);
////            //    // var value = (((i % 3)==0) || ((i % 7)==0));
////            //    if (value == false)
////            //    {
////            //        Console.WriteLine($"{i} Number is not divisible by:3 and 7");
////            //    }
////            //}

////            //    for (int i = 1; i < number; i++)
////            //    {
////            //        if (i % (3 * 7) != 0) Console.WriteLine(i);
////            //    }



////            //Console.WriteLine("Enter Number:");
////            //var number = Convert.ToUInt32(Console.ReadLine());
////            //for(int i=1;i<=number;i++)
////            //{
////            //    Console.Write($"{i} ");
////            //}
////            //Console.WriteLine(" ");

////            //var result = Tuple.Create(1, 2, 3, 4, 5, Tuple.Create(6, 7, 8, 9));
////            //var person = (1, "value1", "value2");
////            //person.Item1.ToString();
////            //var notAValidTuple = (1);
////            //notAValidTuple.ToString();

////            ////var result = display();
////            ////result.Item1;
////            ////result.
////            //(var personId, var Name, _) = GetPerson();

////        }
////        static (int, string, string) GetPerson()
////        {
////            return (1, "Person", "Marks");
////        }

////        public static Tuple<int, string, Tuple<int, int>> display()
////        {
////            return Tuple.Create(1, "vale1", Tuple.Create(1, 2));
////        }
////        static void array(int[] a)
////        {
////            int[] b = new int[5];
////            a = b;
////        }

////        public void print(params int[] b)
////        {
////            foreach (int i in b)
////            {
////                Console.WriteLine(i);
////            }
////        }
////    }
////}
