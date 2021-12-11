using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			for(var i = 1; i < 20; i++){
				var s = Console.ReadLine();
				if(s == ""){
					break;
				}
				Console.WriteLine(s);
			}
			Console.WriteLine("ループを終了しました");
		}
	}
}
