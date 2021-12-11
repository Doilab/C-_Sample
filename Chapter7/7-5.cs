using System;

namespace ClassSample{

        class Program{
                static void Main(string[] arg){

                        var book1 = new Book{
				Title = "吾輩は猫である",
				Author = "夏目漱石",
				Pages = 610,
				Ratings = 4
			};

                        var book2 = new Book{
				Title = "人間失格",
				Author = "太宰治",
				Pages = 212,
				Ratings = 5
			};
			
			Console.WriteLine("Printメソッドを呼び出します");
			book1.Print();
			book2.ThisPrint();
			Console.WriteLine("Printメソッドの呼び出しを終了しました");
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

