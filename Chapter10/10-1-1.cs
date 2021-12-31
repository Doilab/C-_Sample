using System;

namespace ClassSample{

    class Program{
        static void Main(string[] arg){
			
			var nums = ArrayUtils.GetArray(5);	//変数numsの型はint[]
			// nums配列内の要素の合計を求める
			var total = 0;
			foreach(var x in nums){
				total += x;
			}

			Console.WriteLine($"合計:{total}");

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
/*** 10-1 メソッドはどんな型でも返せる ここから ***/
		//int[]を指定して配列を返す静的メソッドを定義
		public static int[] GetArray(int count){	//int[]を指定して配列を返す静的メソッドを定義する
			
			var array = new int[count];

			for(var i = 0; i < count; i++){
				Console.WriteLine("数字を入力してください．");
				var line = Console.ReadLine();
				array[i] = int.Parse(line);
			}

			return array;	//int型の配列を返す
		}
	}
}

