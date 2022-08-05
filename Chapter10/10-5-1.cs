// リスト10-19 ~ 10-21

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var book = new Book();
            book.Ratings = 10;
            Console.WriteLine(book.Ratings);
        }
    }

    class Book{
        int _rating;
        public int Ratings{
            get{
                return _rating;
            }
            set{
                if(value <= 1){
                    _rating = 1;
                }else if(value >= 6){
                    _rating = 5;
                }else{
                    _rating = value;
                }
            }
        }
    }
}