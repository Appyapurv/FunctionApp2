//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace just.For.practice
//{
//    public class SingleTonExample
//    {
//        public void Main(string[] args)
//        {
//            SingleTon s1 = SingleTon.GetSingleton;
//            Console.WriteLine("s1 is initated");
//            SingleTon s2 = SingleTon.GetSingleton;
//            Console.WriteLine("s2 is initated");

//        }
//    }
//    public sealed class SingleTon
//    {
//        private static int Count = 0;
//        private static SingleTon _intance = null;
//        public static SingleTon GetSingleton
//        {
//            get
//            {
//                if (_intance == null)
//                {
//                    _intance = new SingleTon();
//                }
//                return _intance;
//            }
//        }

//        private SingleTon()
//        {
//            Count++;
//            Console.WriteLine(Count);

//        }
//        public void printable()
//        {
//            Console.WriteLine("Printable item:");
//        }

//    }
//}
