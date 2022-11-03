using System;

namespace CalculatorConundrum{
    class Activity7{
        public static void Main(string[] args){
            Console.WriteLine(SimpleCalculator.Calculate(16 ,51, "+"));
            Console.WriteLine(SimpleCalculator.Calculate(32 ,6, "*"));
            Console.WriteLine(SimpleCalculator.Calculate(512 ,4, "/"));
            Console.WriteLine(SimpleCalculator.Calculate(512, 0, "/"));
            Console.WriteLine(SimpleCalculator.Calculate(512, 0, " "));
            System.Console.WriteLine();
        }
    }

    class SimpleCalculator{
        
        public static string Calculate(int a, int b, string oper){
            string errMsg = "Error!";
            try{
                if(oper == "+"){
                    return $"{a} {oper} {b} = {a + b}";
                }else if(oper == "*"){
                    return$"{a} {oper} {b} = {a * b}";
                }else if(oper == "/"){
                    if(b == 0){
                        return "Division by zero is not allowed";
                    }
                    return $"{a} {oper} {b} = {a / b}";
                }
            }catch{
                if(oper == " "){
                    throw new ArgumentException(errMsg);
                }else if(oper == null){
                    throw new ArgumentNullException();
                }
            }
            throw new ArgumentOutOfRangeException(errMsg);
        }
    }
}