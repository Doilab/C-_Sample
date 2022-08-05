// リスト10-17 ~ 10-18

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var person1 = new Person();
            var person2 = new Person("勇太", "佐々木");
        }
    }

    class Person{
        public string FirstName{get; set;}
        public string LastName{get; set;}

        // コンストラクタ
        public Person(){
            FirstName = "";
            LastName = "";
        }
        public Person(string firstName, string lastName){
            FirstName = firstName;
            LastName = lastName;
        }
    }
}