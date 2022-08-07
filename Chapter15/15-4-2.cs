// リスト15-16 ~ 15-17

using System;
using System.IO;

namespace Example{
    class Program{
        static void Main(string[] arg){
            try{
                ReadSample();
            }catch {
                Console.WriteLine("ReadSampleでエラーが発生");
            }
        }

        private static void ReadSample(){
            using(var file = new StreamReader("test.txt")){
                var line = file.ReadLine();
                Console.WriteLine(line);
            }   // Disposeメソッドが書かれていないが，最後にfile.Disposeが呼ばれる
        }
    }
}