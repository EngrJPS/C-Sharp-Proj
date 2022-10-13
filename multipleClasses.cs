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
            Console.Write("Please enter your favorite number:\t");
            Console.ResetColor();
            n = Console.ReadLine();
        }
        while(!int.TryParse(n, out num)){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please enter an integer data type:\t");
            Console.ResetColor();
            n = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(n)){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please enter your favorite number:\t");
                Console.ResetColor();
                n = Console.ReadLine();
            }
        }

        num = Int32.Parse(n);
             
        return num;
    }
}