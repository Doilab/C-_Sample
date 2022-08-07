// リスト13-16

using System;

namespace Example{
    class Program{
        static void Main(string[] arg){
            
            var employee = new Employee(){
                Number = 512,
                FirstName = "理沙",
                LastName = "石井",
                HireDate = new DateTime(2016, 4, 1)
            };
            var s = employee.ToString();    // Employee型にはToStringメソッドは定義されていないが...
            Console.WriteLine(s);
        }
    }
    class Person{
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string FullName{
            get {return LastName + FirstName;}
        }
        public string Email{get; set;}

        public virtual void Print(){
            Console.WriteLine($"名前: {FullName} ({Email})");
        }
    }

    // 従業員クラス
    class Employee : Person{
        // 従業員番号
        public int Number{get; set;}
        // 入社年月日
        public DateTime HireDate{get; set;}
    }
    // 顧客クラス
    class Customer : Person{
        // 顧客ID
        public string Id{get; set;}
        // 顧客ランク 1~5, 5が最上ランク
        public int Rank{get; set;}
        // クレジットカード番号
        public int CreditCardNumber{get; set;}
    }
}