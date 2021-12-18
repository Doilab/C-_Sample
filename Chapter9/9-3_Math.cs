using System;

class Program{
    static void Main(){
//9-3-1
        var abs1 = Math.Abs(150);
        var abs2 = Math.Abs(-320);
        Console.WriteLine(abs1);
        Console.WriteLine(abs2);

        var abs3 = Math.Abs(-5.67M);
        var abs4 = Math.Abs(-1.414);
        Console.WriteLine(abs3);
        Console.WriteLine(abs4);
//9-3-2
        var value1 = 340;
        var value2 = 500;
        var max = Math.Max(value1, value2);
        Console.WriteLine(max);

        var min = Math.Min(value1, value2);
        Console.WriteLine(min);

        int max2 = (value1 < value2) ? value2:value1;   //条件演算子：条件がTrue時=value2, False時=value1
        Console.WriteLine(max2);

//9-3-3
        var n = 3.7;
        var floor = Math.Floor(n);  // 小数点以下を切り捨て
        var ceiling = Math.Ceiling(n); // 小数点以下を切り上げ
        Console.WriteLine($"{floor}, {ceiling}");

//9-3-4
        var r1 = Math.Round(6.4, MidpointRounding.AwayFromZero);  // 四捨五入
        var r2 = Math.Round(6.4);  // 偶数丸め
        Console.WriteLine($"{r1}, {r2}");
        var r3 = Math.Round(6.5, MidpointRounding.AwayFromZero);  // 四捨五入
        var r4 = Math.Round(6.5);  // 偶数丸め
        Console.WriteLine($"{r3}, {r4}");
        var r5 = Math.Round(6.6, MidpointRounding.AwayFromZero);  // 四捨五入
        var r6 = Math.Round(6.6);  // 偶数丸め
        Console.WriteLine($"{r5}, {r6}");

//9-3-5
        var str7 = "MicroSoft";
        var str8 = str7.ToUpper();  //大文字変換
        Console.WriteLine(str7);
        Console.WriteLine(str8);
//9-3-6
        var str9 = "インスタンスを生成せずに利用できるメソッドをstaticメソッドと言います。";
        var str10 = str9.Replace("staticメソッド", "静的メソッド");  // 一部の文字列を置き換える
        Console.WriteLine(str9);
        Console.WriteLine(str10);
//9-3-7
        var str11 = "インスタンスを生成せずに利用できるメソッドを静的メソッドと言います。";
        if (str11.Contains("静的メソッド"))
        {
            Console.WriteLine("文字列の中に「静的メソッド」が含まれています。");
        }else Console.WriteLine("文字列の中に「静的メソッド」が含まれていません。");
//9-3-8
        var str12 = "銀河鉄道の夜,宮沢賢治";
        var items = str12.Split(',');  // カンマで分割する。itemsはstringの配列（string[]）になる
        Console.WriteLine("Title: {0}", items[0]);
        Console.WriteLine("Author: {0}", items[1]);
    }
}
