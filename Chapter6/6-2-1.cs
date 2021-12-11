using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			var scores = new int[]{65, 54, 78, 96, 81};
			var total = 0;
			for(var i = 0; i < scores.Length; i++){
				total += scores[i];
			}
			var average = (double)total / scores.Length;
			Console.WriteLine("平均点:{0}",average);
		}
	}
}
