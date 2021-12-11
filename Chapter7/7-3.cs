using System;

namespace ClassSample{

        class Program{
                static void Main(string[] arg){
                        var book = new Book();
                        book.Title = "吾輩は猫である";
                        book.Author = "夏目漱石";
                        book.Pages = 610;
                        book.Ratings = 4;

                        var title = book.Title;
                        var author = book.Author;
                        var pages = book.Pages;
                        var ratings = book.Ratings;

                        Console.WriteLine($"書籍名:{title}");
                        Console.WriteLine($"著者名:{author}");
                        Console.WriteLine($"ページ数:{pages}");
                        Console.WriteLine($"評価:{ratings}");
                }
        }

        class Book{
                public string Title {get; set;}
                public string Author {get; set;}
                public int Pages {get; set;}
                public int Ratings {get; set;}
        }
}

