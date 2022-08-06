// リスト11-3

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var week = DayOfWeek.Sunday;

            if(week == DayOfWeek.Friday){
                Console.WriteLine("金曜日です");
            }else{
                Console.WriteLine("金曜日ではありません");
            }
        }
    }
}