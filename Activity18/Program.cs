/*
Create a C program that would do the following using FUNCTIONS

Menu:
    - For Loop
    - While Loop
    - Do... While Loop

    Choose

Results:

For loop:   While loop:  Do.. While loop:
* * * *     *            * * * *
* * *       * *          * * * *
* *         * * *        * * * *
*           * * * *      * * * *

*/

using System;

namespace Activity18{
    class Activity18{
        
        public static void Main(string[] args){
            while(true){

                Activity18 loop = new Activity18();
                Console.WriteLine("Menu: ");
                Console.Write("\t1.) For loop\n\t2.) While loop\n\t3.) Do.. While loop\n");
                Console.Write("Enter your choice: ");
                int input = Convert.ToInt32(Console.ReadLine()??"");

                switch(input){

                case 1:
                    loop.fLoop();
                    break;
                case 2:
                    loop.wLoop();
                    break;
                case 3:
                    loop.dwLoop();
                    break;
                default:
                    if(input > 3){
                        continue;
                    }
                    Console.WriteLine("Invalid Input");
                    break;

                }

                Console.Write("Do you want another transaction? (1 - YES; 2 - NO): ");
                int input2 = Convert.ToInt32(Console.ReadLine()??"");

                if(input2 == 1){
                    continue;
                }else if(input2 > 2){
                    Console.Write("Do you want another transaction? (1 - YES; 2 - NO): ");
                    input2 = Convert.ToInt32(Console.ReadLine()??"");
                    continue;
                }else{
                    break;
                }

            }
        }

        public void fLoop(){
            for(int row = 0; row < 4;row++){
                for(int column = 4 - row; column > 0; column--){
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void wLoop(){
            int row = 0;

            while(row < 4){
                row++;
                int column = 0;
                while(column < row){
                    Console.Write("* ");
                    column++;
                }
                Console.WriteLine();
            }
        }

        public void dwLoop(){
            int row = 0;
            do{
                row ++;
                int column = 0;
                do{
                    Console.Write("* ");
                    column++;
                }while(column < 4);
                Console.WriteLine();
            }while(row < 4);
        }
    }
}
