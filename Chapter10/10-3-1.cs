// リスト10-7 ~ リスト10-9

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var person = new Person{
                FirstName = "隆之",
                LastName = "森下"
            };
            var name1 = person.AddTitle("先生");
            var name2 = person.AddTitle();
            Console.WriteLine(name1);
            Console.WriteLine(name2);
        }
    }

    class Person{
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string AddTitle(string title = "様"){
            return $"{LastName}{FirstName} {title}";
        }
    }
}