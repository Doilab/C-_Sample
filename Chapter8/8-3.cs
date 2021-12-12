using System;

namespace ClassSample{

        class Program{
                static void Main(string[] arg){

                        var isLeapYear = DateTime.IsLeapYear(2020);
			
			if(isLeapYear){
				Console.WriteLine("うるう年です\n");
			}else Console.WriteLine("うるう年ではありません\n");

			var today = DateTime.Today;	//Todayは静的プロパティ，todayはDateTime型
			Console.WriteLine($"{today.Year}年{today.Month}月{today.Day}日");
                }

	}
}

