using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			var x = +100;
			var y = -5;
			var a = +(x+y);
			var b = -(x+y);
			Console.WriteLine("a:{0}, b:{1}\n",a,b);
		}
	}
}
