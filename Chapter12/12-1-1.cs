// リスト12-1 ~ 12-7

using System;
using System.Collections.Generic;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var lines = new List<string>{
                "おはよう",
                "こんにちは",
                "こんばんは",
            };

            foreach(var i in lines){
                Console.WriteLine(i);
            }

            // リスト12-2
            lines.Add("おやすみ");
            lines.Add("さようなら");

            // リスト12-3
            var str = lines[0];
            Console.WriteLine(str);

            // リスト12-4
            foreach(var s in lines){
                Console.WriteLine(s);
            }

            // リスト12-5
            var count = lines.Count;
            Console.WriteLine(count);

            // リスト12-6
            lines.RemoveAt(2);
            foreach(var s2 in lines){
                Console.WriteLine(s2);
            }
            var counts = lines.Count;
            Console.WriteLine($"要素数: {counts}");

            // リスト12-7
            lines.Clear();
            Console.WriteLine($"要素数: {lines.Count}");
        }
    }
}