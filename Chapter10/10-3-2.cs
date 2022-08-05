// リスト10-10 ~ リスト10-11
using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            // 1. 配列の要素を0, 10, 20, 30, 40, ... に設定する
            var array = new int[10];
            ArrayUtils.SetValue(array, 0, 10);

            // 2. 配列のすべての要素を1に設定する
            var array2 = new int[10];
            ArrayUtils.SetValue(array2,1);

            // 3. 配列のすべての要素を0に設定する
            var array3 = new int[10];
            ArrayUtils.SetValue(array3);
        }
    }

    static class ArrayUtils{
        public static void SetValue(int[] array, int value = 0, int inc = 0){
            for(var i = 0; i < array.Length; i++){
                array[i] = value;
                value += inc;
            }
        }
    }
}