using System;

namespace MySample{
	class Program{
		static void Main(string[] args){
			var total = 980;
			var discount = total * 0.1;	//int型*double型
			var payment = total - discount;
			Console.WriteLine("割引額:￥{0}\n",discount);
			Console.WriteLine("支払額:￥{0}\n",payment);
		}
	}
}
