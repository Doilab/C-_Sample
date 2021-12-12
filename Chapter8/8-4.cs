using System;

namespace ClassSample{

    class Program{
        static void Main(string[] arg){
			
			var scores = new int[]{56, 60, 45, 70, 85, 93, 68};
			
			var total = ArrayUtils.Total(scores);	//静的メソッドの呼び出し
			var average = ArrayUtils.Average(scores);	//静的メソッドの呼び出し

			Console.WriteLine("合計点:{0}, 平均点:{1}",total, average);

			//以下，コンパイルエラー(静的クラスのため:static class ArrayUtils → class ArrayUtilsに変更すればビルドは通る)
			/*
			var utils = new ArrayUtils();
			*/
        }
	}

	static class ArrayUtils{	//静的クラス
		//配列内の数値の合計を求める
		public static int Total(int[] numbers){
			var total = 0;

			foreach(var n in numbers){
				total += n;
			}

			return total;
		}

		//配列内の数値平均を求める
		public static double Average(int[] numbers){
			var total = Total(numbers);	//上記Totalメソッドを呼び出す

			return (double)total / numbers.Length;
		}
	}
}

