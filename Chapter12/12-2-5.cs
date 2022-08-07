// リスト12-16

using System;
using System.Collections.Generic;
using System.Linq;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var nums = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9};
            var query = nums.Select(x => x*2);
            foreach(var n in query){
                Console.WriteLine(n);
            }
        }
    }
}