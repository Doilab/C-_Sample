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

	            	Console.WriteLine($"Book1 Title:{book1.Title}");
			Console.WriteLine($"Book1 Author:{book1.Author}");
			Console.WriteLine($"Book1 Pages:{book1.Pages}");
			Console.WriteLine($"Book1 Ratings:{book1.Ratings}\n");

			Console.WriteLine($"Book2 Title:{book2.Title}");
			Console.WriteLine($"Book2 Author:{book2.Author}");
			Console.WriteLine($"Book2 Pages:{book2.Pages}");
			Console.WriteLine($"Book2 Ratings:{book2.Ratings}");
		}
        }

        class Book{
                public string Title {get; set;}
                public string Author {get; set;}
                public int Pages {get; set;}
                public int Ratings {get; set;}
        }
}

