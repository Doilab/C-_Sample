// リスト12-32

using System;
using System.Collections.Generic;
using System.Linq;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var nums = new int[] {12, 56, 75, 8, 12, 95, 32, 85, 24, 49};
            var list = nums.Where(x => x <= 10).ToList();   // Whereの結果をList<int>に変換する
            Console.WriteLine(list[0]);
        }
    }
}