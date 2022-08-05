// リスト10-23

using System;

namespace ClassSample{
    class Program{
        static void Main(string[] arg){
            var pet = new VirtualPet("エイミー");
            // 以下，エラー
            pet.Name = "リサ";    //代入できないためエラー
        }
    }
    class VirtualPet{
        public string Name{get; private set;}   // setの前にprivateを指定していることでgetだけが公開される．つまり読み取り専用になる．
        public int Mood{get; set;}
        public int Energy{get; set;}

        // コンストラクタ
        public VirtualPet(string name){
            Name = name;
            Mood = 5;
            Energy = 100;
        }
    }
}