using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			
			for(var x = 1; x <= 9; x++){
				for(var y = 1; y <= 9; y++){
					var n = x * y;
					Console.WriteLine($"{x}×{y}={n}");
				}
			}
		}
	}
}
