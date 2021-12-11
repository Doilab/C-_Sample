using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			for(var i = 1; i < 100; i++){
				if(i % 13 != 0){
					continue;
				}
			Console.WriteLine($"{i}は13で割り切れる数です");
			}
		}
	}
}
