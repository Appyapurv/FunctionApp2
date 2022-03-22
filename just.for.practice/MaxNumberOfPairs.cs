//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace just.For.practice
//{
//    public class MaxNumberOfPairs
//    {
//        public  void Main(string[] args)
//        {
//            var tempA = bool.Parse("false");
//            var tempA1 = bool.Parse("true");
//            //: How to perform Right circular rotation of an array?
//            //    Ans: The user will input an integer array and the method should shift each element of input array to its Right by one position in circular fashion. The logic is to iterate loop from 0 to Length-1 and swap each element with first element

//            //input: 1 2 3 4 5, output: 5 1 2 3 4
//            //1 2 3 4 5
//            //5 1 2 3 4

//            //21345
//            //31245
//            //41235
//            //512345


//            var ss=Guid.NewGuid().ToString("N");
//            var arrays = new int[] { 1, 2, 3, 4, 5 };
//            for (int i = 0; i < arrays.Length-1; i++)
//            {
//                var temp = arrays[0];
//                arrays[0] = arrays[i];
//                arrays[i] = temp;

//            }
           
//            Console.WriteLine(arrays);



































//int[] array = new int[] { 1, 2, 3, 4, 5 };
//            //int j = array.Length;
//            for (int i = 0; i < array.Length - 1; i++)
//            {
//                int temp = array[0];
//                array[0] = array[i+1];
//                array[i+1] = temp;
//            }














//            //    //Q.7: How to find all possible substring of a given string?
//            //    //    Ans.: This is a very frequent interview question.Here we need to form all the possible substrings from input string, varying from length 1 to the input string length. The output will include the input string also.

//            //    //    input: abcd , output: a ab abc abcd b bc bcd c cd d

//            //    string str = "abcd";
//            //    for (int i = 0; i < str.Length; i++)
//            //    {
//            //        StringBuilder stringBuilder = new StringBuilder(str.Length - i);

//            //        for (int j = i; j < str.Length; j++)
//            //        {
//            //            stringBuilder.Append(str[j]);
//            //            Console.Write(stringBuilder + " ");
//            //        }
//            //    }















//            ////Q.6: How to remove duplicate characters from a string?
//            ////    Ans.: The user will input a string and the method should remove multiple occurrences of characters in the string

//            ////input: csharpcorner, output: csharpone
//            //string str = "csharpcorner";
//            //var result = string.Empty;
//            //var strArray = str.ToCharArray();
//            //var sss = strArray.Distinct();
//            //foreach (var character in strArray)
//            //{

//            //    if (!result.Contains(character))
//            //    {
//            //        //result += character;
//            //        result = String.Concat(result + character);
//            //    }
//            //}
//            //Console.WriteLine(result);


















//            //    //Q.4: How to reverse each word in a given string?
//            //    //    Ans.: The user will input a sentence and we need to reverse each word individually without changing its position in the sentence.

//            //    //    input: Welcome to Csharp corner, output: emocleW ot prahsC renroc


//            //    string str = "Welcome to Csharp corner";
//            //    string[] sortedSet = str.Split(' ');

//            //    List<string> list = new List<string>();
//            //    foreach (var set in sortedSet)
//            //    {
//            //        var array = set.ToArray();
//            //        int j = array.Length - 1;
//            //        //reverse logic
//            //        for (int i = 0; i < array.Length / 2; i++)
//            //        {
//            //            var temp = array[i];
//            //            array[i] = array[j];
//            //            array[j] = temp;
//            //            j--;
//            //        }

//            //        var strr = string.Concat(array);
//            //        list.Add(strr);

//            //    }

//            //    string Combination = String.Join(" ", list);
//            //    Console.WriteLine(Combination);








//            ////How to count the occurrence of each character in a string?
//            ////    Ans.: The user will input a string and we need to find the count of each character of the string and display it on console. We won’t be counting space character.
//            ////    input: hello world;
//            ////output: h – 1
//            ////e – 1
//            ////l – 3
//            ////o – 2
//            ////w – 1
//            ////r – 1
//            ////d – 1

//            //string input = "Hello Word";



//            //Dictionary<char, int> Dict = new Dictionary<char, int>();


//            //foreach (var i in input)
//            //{
//            //    if (i != ' ')
//            //    {
//            //        if (Dict.ContainsKey(i))
//            //        {
//            //            Dict.Add(i, 1);
//            //        }
//            //        else
//            //        {
//            //            Dict[i]++;
//            //        }
//            //    }
//            //}

//            //foreach (var character in Dict)
//            //{
//            //    Console.WriteLine($"Key{Dict.Keys} value:{Dict.Values}");
//            //}






//            //    // find the unsorted element in an array
//            //    //Ex{1 2 3 4 2 3 4 2 2 6 7 2 8} , 2 is the majority element because his amount came more then 50%
//            //    try
//            //    {
//            //        MaxNumberOfPairs max = new MaxNumberOfPairs();
//            //        max.GetMajorityElment(new int[] { 1, 2, 3, 4, 2, 3, 4, 2, 2, 6, 7, 2, 8 });
//            //    }
//            //    catch (Exception e)
//            //    {
//            //        Console.WriteLine(e.Message);
//            //    }


//            //}

//            //public int GetMajorityElment(params int[] x)
//            //{
//            //    Dictionary<int, int> Dict = new Dictionary<int, int>();

//            //    int majority = x.Length / 2;

//            //    foreach (int i in x)
//            //    {
//            //        if (Dict.ContainsKey(i))
//            //        {
//            //            Dict[i]++;
//            //            //checks if element just addded is the majority element
//            //            if (Dict[i] > majority)
//            //            {
//            //                return i;
//            //            }
//            //        }
//            //        else
//            //        {
//            //            Dict.Add(i, 1);
//            //        }
//            //    }
//            //    //throw
//            //    throw new Exception("No majority");





//        }















































//        //string str ="Blue red black fues white pink purple Blue purple Blue purple Blue red black white pink purple Blue red black white pink purple";

//        //var result = string.Join("  ", str.Split(' ').Distinct());

//        //Console.WriteLine(result);




//        //var cc= str.ToCharArray();
//        //foreach (var c in cc)
//        //{
//        //    var pp= cc.Distinct();

//        //    var ss = string.Join(" ", pp.SelectMany('a', pp));
//        //    if (pp.Contains('a') == true)
//        //    {
//        //        var value=(byte)Convert.ToChar(c);
//        //        Console.WriteLine($"Found a: {c}");
//        //    }
//        //    Console.WriteLine(c);
//        //}








//        //string[] character = str.Split(' ');
//        //HashSet<string> set = new HashSet<string>();
//        //for (int i = 0; i < character.Length; i++)
//        //{
//        //    set.Add(character[i]);
//        //}

//        //foreach (var ss in set)
//        //{

//        //    Console.WriteLine(ss);

//        //}

//        //var dict = new Dictionary<string, int>();
//        //for (int i = 0; i < character.Length; i++)
//        //{
//        //    try
//        //    {
//        //        //if (dict.ContainsKey(character[i]) == true)
//        //        //{
//        //        int count = 1;
//        //     //   count++;
//        //        if (dict.ContainsKey(character[i]) == true)
//        //        {
//        //            dict.Add(character[i], count + 1);

//        //        }
//        //        else
//        //        {
//        //            dict.Add(character[i], count);
//        //        }
//        //        //}

//        //    }
//        //    catch (Exception e)
//        //    {
//        //        Console.WriteLine(e);
//        //    }
//        //}

//        //foreach (var vv in dict)
//        //{
//        //    Console.WriteLine($"Key{vv.Key} & Value {vv.Value}");
//        //}



//        //string word = "woooooddd";
//        //var distinctCount = word.Distinct();
//        //distinctCount.Any(o => o = 'o');

//        //foreach (var c in distinctCount)
//        //{
//        //    if (word.Count(l => l == c) > 1)
//        //    {
//        //        //do wrok with c
//        //        Console.WriteLine(c);
//        //    }
//        //}

//    }
//}
////}