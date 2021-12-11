using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			var line = "";

			do{
				Console.WriteLine("何か入力してください");
				line = Console.ReadLine();
			}while(line =="");

			Console.WriteLine(line);
		}
	}
}
