//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace just.For.practice
//{
//    public class reflection
//    {
//        public class User
//        {
//            public string Username { get; set; }
//            public string Address { get; set; }
//            public string Name { get; set; }
//            public string Lastname { get; set; }
//        }
//        public class Person
//        {
//            public string Name { get; set; }
//            public string Lastname { get; set; }
//        }
//        [AttributeUsage(AttributeTargets.Property)]
//        public class MatchParentAttribute : Attribute
//        {
//            public readonly string ParentPropertyName;
//            public MatchParentAttribute(string parentPropertyName)
//            {
//                ParentPropertyName = parentPropertyName;
//            }
//        }
//        public class PersonMatch
//        {
//            [MatchParent("Name")]
//            public string NameMatch { get; set; }
//            [MatchParent("Lastname")]
//            public string LastnameMatch { get; set; }

//        }

//        public  void Main(string[] args)
//        {
//            var userDetail = new User
//            {
//                Address = "Delhi",
//                Lastname = "Upadhyay",
//                Name = "Apurv",
//                Username = "ApurvUpadhyay"

//            };
//            //var personDetail = new Person
//            //{
//            //    Name = userDetail.Name,
//            //    Lastname = userDetail.Lastname

//            //};
//            var person = new Person();
//            var personmatch = new PersonMatch();
//            //PropertyCopyier<User, Person>.copy(userDetail, person);
//            PropertyMatcher<User, PersonMatch>.GenerateMatchedObject(userDetail, personmatch);
//            Console.WriteLine("Person");
//            Console.WriteLine(personmatch.NameMatch);
//            Console.WriteLine(personmatch.LastnameMatch);

//            PropertyCopyier<User, Person>.copy(userDetail, person);
//        }
//    }
//}
