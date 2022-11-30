/*
Problem: Fibonacci Numbers
Fibonacci's numbers in mathematics form a sequence that looks like this: 1, 1, 2, 3, 5, 8, 13, 21, 34, ….

The formula to form the Fibonacci sequence is:

F0 = 1
F1 = 1
Fn = Fn-1 + Fn-2

Problem: Numbers Pyramid

Print the numbers 1 … n in a pyramid as in the examples below. 
On the first line we print one number, on the second line 
we print two numbers, on the third line we print three numbers, 
and so on, until the numbers are over. On the last line we print 
as many numbers as we get until we get to n.
*/
using System;

namespace Activity15{
    class Activity15{

        public static void Main(string[] args){
            Console.WriteLine("Please enter a number: ");
            Console.WriteLine(Fibonacci.fibCount(Convert.ToInt32(Console.ReadLine()??"This is not null")));
            Console.WriteLine("Enter a number: ");
            Pyramid.numPyramid(Convert.ToInt32(Console.ReadLine()??""));
        }   
    }
    class Fibonacci{
        public static int fibCount(int input){
        int f0, f1, sum;
        f0 =1;
        f1 =1;
        for(int i = 0; i < input - 2; i++){
            sum = f0 + f1;
            f0 = f1;
            f1 = sum;
        }
        return f0 + f1;	
        }
    }

    class Pyramid{
    public static void numPyramid(int input){
	int i = 1;
	for(int row = 1; row < input; row++){
	    for(int col = 1; col < row; col++){
		Console.Write(i + " ");
		i++;
	    }
	    Console.WriteLine(" ");
        if(i > input){
            break;
        }
	    }
        }
    }  
}