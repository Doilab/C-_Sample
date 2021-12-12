using System;

namespace ClassSample{

        class Program{
                static void Main(string[] arg){

                        var date = new DateTime(2019,10,8);	//インスタンス生成時に「2019年10月8日」の値を渡す
			var year = date.Year;
			var month = date.Month;
			var day = date.Day;

			Console.WriteLine("{0}年{1}月{2}日",year,month,day);
			
			var date0 = new DateTime(2019,4,30);	//2019年4月30日のインスタンスを生成
			var date1 = date0.AddDays(1);	//1日後を求める
			var date2 = date0.AddMonths(6);	//6ヶ月後を求める
			Console.WriteLine(date0);
			Console.WriteLine(date1);
			Console.WriteLine(date2);
                }

	}
}

