using System;

class Program{
    static void Main(){
//9-2-1
        var str1 = "ようこそ、C#の世界へ";

        string str2 = "ようこそ、C#の世界へ";

        String str3 = "ようこそ、C#の世界へ";

        Console.WriteLine("str1:{0} str2:{1} str3:{2}",str1, str2, str3);

//9-2-2
        var str = "ようこそ、C#の世界へ";

        var length = str.Length;    //

        Console.WriteLine($"{length}文字です");
//9-2-3
        var str4 = "オブジェクト指向";
        var sub1 = str4.Substring(0, 6); //開始位置0から6文字を取り出して新たな文字列を得る
        var sub2 = str4.Substring(6, 2); //開始位置6から2文字を取り出して新たな文字列を得る

        Console.WriteLine(str4);
        Console.WriteLine(sub1);
        Console.WriteLine(sub2);

//9-2-4
        var str5 = " オブジェクト指向 ";
        var str6 = str5.Trim(); //文字列前後の空白を取り除く
        Console.WriteLine($"[{str5}]");
        Console.WriteLine($"[{str6}]");
//9-2-5
        var str7 = "MicroSoft";
        var str8 = str7.ToUpper();  //大文字変換
        Console.WriteLine(str7);
        Console.WriteLine(str8);
//9-2-6
        var str9 = "インスタンスを生成せずに利用できるメソッドをstaticメソッドと言います。";
        var str10 = str9.Replace("staticメソッド", "静的メソッド");  // 一部の文字列を置き換える
        Console.WriteLine(str9);
        Console.WriteLine(str10);
//9-2-7
        var str11 = "インスタンスを生成せずに利用できるメソッドを静的メソッドと言います。";
        if (str11.Contains("静的メソッド"))
        {
            Console.WriteLine("文字列の中に「静的メソッド」が含まれています。");
        }else Console.WriteLine("文字列の中に「静的メソッド」が含まれていません。");
//9-2-8
        var str12 = "銀河鉄道の夜,宮沢賢治";
        var items = str12.Split(',');  // カンマで分割する。itemsはstringの配列（string[]）になる
        Console.WriteLine("Title: {0}", items[0]);
        Console.WriteLine("Author: {0}", items[1]);
    }
}
