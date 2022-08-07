// リスト12-11 ~ 12-12

using System;
using System.Collections.Generic;
using System.Linq;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var nums = new List<int>{12, 56, 75, 8, 12, 95, 32, 85, 24, 49};
            var query = nums.Where(x => x >= 50);
            foreach(var n in query){
                Console.WriteLine(n);
            }

            // リスト12-12
            var nums2 = new int[] {12, 56, 75, 8, 12, 95, 32, 85, 24, 49};
            var query2 = nums2.Where(x => x >= 50);
            foreach(var n2 in query2){
                Console.WriteLine(n2);
            }
        }
    }
}