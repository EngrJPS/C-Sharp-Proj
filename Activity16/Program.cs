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
            //First pyramid 
            for(int row = 1; row <= input; row++){
                //This is the loop for space
                for(int column = 1; column <= input - row; column++){
                    Console.Write(" ");
                }
                //This is the loop for column
                for(int column = 1; column <= row; column++){
                    Console.Write(column);
                }
                //This is the loop for number
                for(int i = row - 1; i >= 1; i--){
                    Console.Write(i);
                }
                Console.WriteLine(" ");
            }
            //Second pyramid
            for(int row = input - 1; row >= 1; row--){
                //Loop for space
                for(int column = 1; column <= input - row; column++){
                    Console.Write(" ");
                }
                //Increase the number of columns
                for(int column = 1; column <= row; column++){
                    Console.Write(column);
                }
                //Decrease the number of rows
                for(int i = row - 1; i >= 1; i--){
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            
        }
    }
}