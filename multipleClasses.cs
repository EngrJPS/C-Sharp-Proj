using System;

class SampleColor{
    public void colorSomething(string? x){
        Console.WriteLine("The color is:\t{0}",x);
    }
}


public static class sampleClass{
    public static int favNum(string? n){
        int num = 0;

        while(string.IsNullOrWhiteSpace(n)){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter your favorite number:\t");
            Console.ResetColor();
            n = Console.ReadLine() ?? "0";
            
            if(!string.IsNullOrWhiteSpace(n)){
                num = Int32.Parse(n ?? "0");
            }
        }
        return num;
    }
}