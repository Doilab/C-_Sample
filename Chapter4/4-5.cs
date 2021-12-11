using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			Console.WriteLine("気温を入力してください");
			var stringTemperature = Console.ReadLine();
			var temperature = double.Parse(stringTemperature);

			if(temperature >= 35.0){
				Console.WriteLine("猛暑日です");
			}else if(temperature >= 30.0){
				Console.WriteLine("真夏日です");
			}else if(temperature >= 25.0){
				Console.WriteLine("夏日です");
			}else if(temperature <= -57.0){
				Console.WriteLine("南極の内陸部の平均気温以下です");
			}else{
				Console.WriteLine("いずれでもありません");
			}
		}
	}
}
