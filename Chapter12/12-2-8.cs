// リスト12-19

using System;
using System.Collections.Generic;
using System.Linq;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var nums = new List<int>{4, 6, 7, 1, 3, 9, 2, 5, 8};
            var query = nums.OrderBy(x => x);
            var query2 = nums.OrderByDescending(x => x);

            foreach(var n in query){
                Console.WriteLine(n);
            }

            Console.WriteLine("");

            foreach(var n2 in query2){
                Console.WriteLine(n2);
            }
        }
    }
}