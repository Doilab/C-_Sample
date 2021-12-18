using System;
using System.IO;        //Fileクラスを使用するには，using System.IO とする必要がある

class Program{
    static void Main(){
//9-5-1 ファイルの書き出し
        var lines1 = new string[]{
                "祇園精舍の鐘の声、諸行無常の響きあり。",
                "娑羅双樹の花の色、盛者必衰の理をあらはす。",
                "奢れる人も久しからず、ただ春の夜の夢のごとし。",
                "猛き者もつひにはほろびぬ、ひとへに風の前の塵に同じ。"
        };
        File.WriteAllLines("./祇園精舎.txt", lines1);

//9-5-2 ファイルの読み込み
        var lines2 = File.ReadAllLines(@"./祇園精舎.txt");
        foreach (var line2 in lines2){
                Console.WriteLine(line2);
        }
    }
}
