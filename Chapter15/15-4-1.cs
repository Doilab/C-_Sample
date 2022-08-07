// リスト15-13 ~ 15-14

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
            var file = new StreamReader("test.txt");
            try{
                while(file.EndOfStream == false){
                    var line = file.ReadLine();
                    if(line == ""){
                        return; // 途中でメソッドから抜け出す
                    }
                    Console.WriteLine(line);
                }
            }
            finally{    // tryブロック内でreturn文が実行されても，このブロックは実行される．
                file.Dispose(); // 必ずDisposeメソッドが最後に呼ばれる．
            }
        }
    }
}