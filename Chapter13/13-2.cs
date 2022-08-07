// リスト13-1

using System;

namespace Example{
    class Program{
        static void Main(string[] arg){

        }
    }
    // 従業員クラス
    class Employee{
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string FullName{
            get {return LastName + FirstName;}
        }

        // 従業員番号
        public int Number{get; set;}
        // 入社年月日
        public DateTime HireDate{get; set;}
        // Emailアドレス
        public string Email{get; set;}
    }
    // 顧客クラス
    class Customer{
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string FullName{
            get {return LastName + FirstName;}
        }

        // 顧客ID
        public string Id{get; set;}
        // Emailアドレス
        public string Email{get; set;}
        // 顧客ランク 1~5, 5が最上ランク
        public int Rank{get; set;}
        // クレジットカード番号
        public int CreditCardNumber{get; set;}
    }
}