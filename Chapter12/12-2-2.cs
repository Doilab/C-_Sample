// リスト12-13

using System;
using System.Collections.Generic;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var nums = new List<int>{12, 56, 75, 8, 12, 95, 32, 85, 24, 49};
            foreach(var x in nums){
                if(x >= 50){
                    Console.WriteLine(x);
                }
            }
        }
    }
}