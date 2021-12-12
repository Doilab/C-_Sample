using System;

namespace ClassSample{

    class Program{
        static void Main(string[] arg){
			
			var book1 = new Book{Title = "伊豆の踊子", Author = "川端康成"};
			book1.PrintTitle();

			var book2 = new Book{Title = "走れメロス", Author = "太宰治"};
			book2.PrintTitle();

			var book3 = new Book{Title = "銀河鉄道の夜", Author = "宮沢賢治"};
			book3.PrintTitle();

			Book.ClearCount();
			Console.WriteLine(Book.Count);
        }
	}

	class Book{
		//静的プロパティ
		public static int Count{get; set;}	//static キーワードで静的プロパティを定義

		//静的メソッド
		public static void ClearCount(){	//static キーワードで静的メソッドを定義
			Count = 0;
		}

		public string Title{get; set;}
		public string Author{get; set;}

		public void PrintTitle(){
			Console.WriteLine("書籍名:{0}",Title);
			Count++;	//自分の所属クラスのプロパティなので，Book.Count++;とクラス名を指定する必要はない．
			Console.WriteLine(Count);
		}
	}
}

