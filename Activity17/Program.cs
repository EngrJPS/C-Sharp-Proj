/*
Collatz Conjecture

The Collatz Conjecture or 3x+1 problem can be summarized as follows:

Take any positive integer n. If n is even, divide n by 2 to get n / 2. 
If n is odd, multiply n by 3 and add 1 to get 3n + 1. Repeat the process indefinitely. 
The conjecture states that no matter which number you start with, 
you will always reach 1 eventually.

Given a number n, return the number of steps required to reach 1.
*/
using System;

namespace Activity17{
    class Activity17{
        public static void Main(string[] args){
            Random rand = new Random();
            double xx = rand.Next(1, 5);
            double yy = rand.Next(1, 5);
            Console.WriteLine(collatzConjecture.Conjecture(12));
            Console.WriteLine();
            Console.WriteLine(Dart.bullsEye(xx, yy));
        }
    }

    class collatzConjecture{
        public static int Conjecture(int N){

            while(N > 1){
                if(N % 2 == 0){
                    N = N/2;
                    Console.WriteLine(N);
                }else{
                    N = 3*N + 1;
                    Console.WriteLine(N);
                }
            }
            return N;
        }
        
    }

    class Dart{
        private static double measurement(double xx, double yy) => System.Math.Sqrt(xx * xx +  yy * yy);
        public static int bullsEye(double x, double y) =>
            measurement(x, y) switch{
                <= 1.0 => 10,
                <= 5.0 => 5,
                <= 10.0 => 1,
                _ => 0
            };
    }
}