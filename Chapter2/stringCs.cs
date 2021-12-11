using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			var str= "Hello world!";
			Console.WriteLine("文字列は二重引用符(\")で囲む");	//エスケープシーケンス
			Console.WriteLine("おはよう\nこんにちは\nこんばんは\n");
			var length = str.Length;	//文字列の長さを格納
			Console.WriteLine("{0}は{1}文字です",str,length);
		}
	}
}
