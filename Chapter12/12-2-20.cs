// リスト12-31

using System;
using System.Collections.Generic;
using System.Linq;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var words = new List<string>{
                "effect", "access", "condition", "sign", "profit", "line", "result"
            };

            var array = words.OrderBy(x => x).ToArray();    // OrderByの結果をstring[]に変換する
            Console.WriteLine(array[0]);
        }
    }
}