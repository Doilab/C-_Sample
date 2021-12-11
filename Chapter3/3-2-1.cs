using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			var price1 = 1100;
			var price2 = 800;
			var price3 = 1250;
			var total = price1 + price2 + price3;	//int型同士の演算 = int型として出力される
			Console.WriteLine("合計金額{0}\n",total);

			var member = 4;
			var perPerson = total / member;	//int型の割り算 = int型になる
			Console.WriteLine("一人あたり:{0}\n",perPerson);

			var remainder = total % member;	//intの型の剰余演算 = int型
			Console.WriteLine("余り:{0}\n",remainder);
		}
	}
}
