using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			var scores = new int[10];
			var total = 0.0;
			for(var i = 0; i < scores.Length; i++){
				var line = Console.ReadLine();
				var number = int.Parse(line);
				scores[i] = number;
			}
			
			for(var i = 0; i < scores.Length; i++){
				total += scores[i];
			}
			var average = (double)total / scores.Length;
			Console.WriteLine("合計:{0} 平均:{1}",total,average);
		}
	}
}
