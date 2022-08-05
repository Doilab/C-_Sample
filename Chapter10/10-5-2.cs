// リスト10-22

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var person = new Person{
                LastName = "渡部",
                FirstName = "智史"
            };
            var name = person.GetFullName();
            Console.WriteLine(name);
            var name2 = person.FullName;
            Console.WriteLine(name2);
        }
    }

    class Person{
        // 名
        public string FirstName{get; set;}
        // 姓
        public string LastName{get; set;}
        // 姓名
        public string GetFullName(){
            return LastName + FirstName;
        }
        public string FullName{
            get {return LastName + FirstName;}
        }
    }
}