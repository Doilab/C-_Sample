// リスト12-29

using System;
using System.Collections.Generic;
using System.Linq;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var nums = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9};
            
            var any = nums.Any(x => x < 0);
            Console.WriteLine(any);
        }
    }
}