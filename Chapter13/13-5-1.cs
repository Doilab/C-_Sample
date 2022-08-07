// リスト13-14

using System;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var book = new Book();
            DoSomething(book);
        }
        public static void DoSomething(object obj){
        
        }
    }

    class Book{
       	public string Title {get; set;}
        public string Author {get; set;}
        public int Pages {get; set;}
        public int Rating {get; set;}

        public Book(string title, string author, int pages, int rating){
            Title = title;
            Author = author;
            Pages = pages;
            Rating = rating;
        }
	}
}