/*
Using for loop print the following output on console.
    1
   121
  12321
 1234321
123454321
 1234321
  12321
   121
    1
*/

using System;
namespace Activity16{
    class Activity16{
        public static void Main(string[] args){
            Console.Write("Enter a number: ");
            Diamond(Convert.ToInt32(Console.ReadLine() ?? "This is not a null"));
        }

        public static void Diamond(int input){

            /*
            Create a loop for row
            Create a loop for column
            Create a loop for space
            */
            int n = 0;
            int space = input;
            for(int row = 1; row <= input; row++){
                for(int column = 1; column <= row; column++){
                    Console.Write(" ");
                    space--;
                    if(space >= 0){
                        Console.Write(" ");
                    }
                    n++;
                    if(n >= column){
                        Console.Write(column);
                    }
                }
                
                Console.WriteLine(" ");
            }
            
        }
    }
}