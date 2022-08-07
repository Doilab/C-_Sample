// リスト15-7

using System;

namespace Example{
    class Program{
        static void Main(string[] arg){
            try{
                Book book = null;
                var title = book.Title;
                Console.WriteLine(title);
            }catch(Exception ex){
                Console.WriteLine($"Type: {ex.GetType().Name}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"TargetSite: {ex.TargetSite}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
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