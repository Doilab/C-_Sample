using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			var name = "山田";
			var message = name + "さん，こんにちは．";
			Console.WriteLine(message);

			message += "今日もいい天気ですね";
			Console.WriteLine(message);
		}
	}
}
