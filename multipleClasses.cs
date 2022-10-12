using System;

class SampleColor{
    public void colorSomething(string? x){
        Console.WriteLine("The color is:\t{0}",x);
    }
}


public static class sampleClass{
    public static string favNum(string? n){
        string num = " ";

        while(string.IsNullOrWhiteSpace(n)){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please enter your favorite number:\t");
            Console.ResetColor();
            n = Console.ReadLine();
        }
             
        return num;
    }
}