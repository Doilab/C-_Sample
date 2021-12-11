using System;

namespace ClassSample{

        class Program{
        	static void Main(string[] arg){
            		var bmiCalc = new BMICalculator();
					var bmi = bmiCalc.GetBMI(175,51);
					var type = bmiCalc.GetBodyType(bmi);

					Console.WriteLine("BMI:{0:.00}",bmi);
					Console.WriteLine($"あなたは「{type}」です");
			}
        }

        class BMICalculator{
                public double GetBMI(double height, double weight){
					var metersTall = height / 100.0;	//cm -> m 変換ｍ
					var bmi = weight / (metersTall * metersTall);
					return bmi;
				}

				public string GetBodyType(double bmi){

					if(bmi < 18.5){
						return "痩せ型";
					}
					if(bmi < 25){
						return "普通";
					}
					if(bmi < 30){
						return "肥満(1度)";
					}
					if(bmi < 35){
						return "肥満(2度)";
					}
					if(bmi < 40){
						return "肥満(3度)";
					}
					
					return "肥満(4度)";
				}
        }
}

