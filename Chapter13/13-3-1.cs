// リスト13-2 ~ 13-5

using System;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var emploee = new Employee{
                Number = 352,
                FirstName = "涼太",
                LastName = "田中",
                HireDate = new DateTime(2015, 10, 1)
            };
            Console.WriteLine("従業員番号{0}の{1}は，{2}年に入社しました．", emploee.Number, emploee.FullName, emploee.HireDate.Year);
        }
    }
    class Person{
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string FullName{
            get {return LastName + FirstName;}
        }
        public string Email{get; set;}
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