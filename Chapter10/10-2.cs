//リスト10-5 ~ 10-6

using System;

namespace  ClassSample{

    class Program{
        static void Main(string[] arg){
            var scores = new int[]{55, 60, 45, 70, 85, 93, 68};
            var total = ArrayUtils.Total(scores);
            Console.WriteLine(total);
            var scores2 = new double[]{5.9, 9.6, 12.4, 8.0, 7.9};
            var total2 = ArrayUtils.Total(scores2);
            Console.WriteLine(total2);
        }
    }
    
    static class ArrayUtils{
        // ①int型の配列内の数値の合計を求める
        public static int Total(int[] numbers){
            var total = 0;
            foreach (var n in numbers){
                total += n;
            }
            return total;
        }


        // ②double型の配列内の数値の合計を求める
        public static double Total(double[] numbers){ // 同じメソッド名で引数だけが異なる
            var total = 0.0;
            foreach (var n in numbers){
                total += n;
            }
            return total;
        }
    }
}
