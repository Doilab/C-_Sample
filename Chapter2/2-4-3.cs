using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			var price = 1280m;
			var priceIncludingTax = price * 1.08m;
			Console.WriteLine(priceIncludingTax);
		}
	}
}
