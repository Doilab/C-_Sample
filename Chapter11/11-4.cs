// リスト11-12

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var book = GetBook();
            if(book == null){
                Console.WriteLine("Bookオブジェクトは生成できませんでした");
            }else {
                Console.WriteLine($"{book.Title} {book.Author}");
            }
        }

        private static Book GetBook(){
            var line = Console.ReadLine();
            var items = line.Split(',');
            if(items.Length != 2){
                return null;
            }
            var book = new Book{
                Title = items[0],
                Author = items[1],
            };
            return book;
        }
    }

    class Book{
       	public string Title {get; set;}
        public string Author {get; set;}
        public int Pages {get; set;}
        public int Ratings {get; set;}
        	
		public void ThisPrint(){
			Console.WriteLine($"*{this.Title}");
			Console.WriteLine($" 著者:{this.Author} {this.Pages}ページ 評価:{this.Ratings}");
		}

		public void Print(){
			Console.WriteLine($"*{Title}");
            Console.WriteLine($" 著者:{Author} {Pages}ページ 評価:{Ratings}");
        }
	}
}