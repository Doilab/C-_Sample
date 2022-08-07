// リスト15-2 ~ 15-6

using System;

namespace Example{
    class Program{
        static void Main(string[] arg){
            try{
                var total = 1000;
                var line = Console.ReadLine();
                var count = int.Parse(line);
                var ans = total / count;
                Console.WriteLine(ans);
                Console.WriteLine("正常終了");
            }catch(System.DivideByZeroException){   // DivedeByZeroException例外をキャッチする
                Console.WriteLine("ゼロは入力できません");
            }catch(System.FormatException){
                Console.WriteLine("数値を入力してください");    // FormalException例外をキャッチする
            }catch(System.Exception){
                Console.WriteLine("予期しないエラーが発生しました");
            }
        }
    }
}