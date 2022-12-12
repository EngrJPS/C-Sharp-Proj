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

/*
              #
             ###
            #####
           ####### 
          #########
         ###########
        #############
       ###############
      #################
     ###################
    #####################
   #######################
  #########################
 ###########################
#############################
            ######
            ######
            ######
            ######                                                   
*/


using System;
namespace Activity16{
    class Activity16{
        public static void Main(string[] args){
            Activity16 act = new Activity16();
            Console.Write("Enter a number: ");
            Diamond(Convert.ToInt32(Console.ReadLine() ?? "This is not a null"));
            Console.Write("Enter a number: ");
            int l = Convert.ToInt32(Console.ReadLine()?? " ");
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine()?? " ");
            act.dumbPass(l, n);
            act.magNum(Convert.ToInt32(Console.ReadLine()??" "));
            Console.Write("Enter a number: ");
            christmasTree(Convert.ToInt32(Console.ReadLine()??" "));
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
                //Decrease the values of the second half of the triangle
                for(int i = row - 1; i >= 1; i--){
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            
        }

        public void dumbPass(int n, int l){
            for(int d1 = 1; d1 <= n; d1++){
                for(int d2 = 1; d2 <= n; d2++){
                    for(char l1 = 'a'; l1 < 'a' + l; l1++){
                        for(char l2 = 'a'; l2 < 'a' + l; l2++){
                            for(int d3 = Math.Max(d1, d2) + 1; d3 <= n; d3++){
                                Console.Write($"{d1}{d2}{l1}{l2}{d3}" + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        public void magNum(int input){
            for(int d1 = 0; d1 <= 9; d1++){
                for(int d2 = 0; d2 <= 9; d2++){
                    for(int d3 = 0; d3 <= 9; d3++){
                        for(int d4 = 0; d4 <= 9; d4++){
                            for(int d5 = 0; d5 <=9; d5++){
                                for(int d6 = 0; d6 <= 9; d6++){
                                    if(d1 * d2 * d3 * d4 * d5 * d6 == input){
                                        Console.WriteLine($"{d1} {d2} {d3} {d4} {d5} {d6}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }

        public static void christmasTree(int input){
            for(int row = 0; row < input; row++){
                for(int space = 0; space < input - row; space++){
                    Console.Write(" ");
                }
                for(int column = 0; column <= row; column++){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");
                    Console.ResetColor();
                }
                for(int column1 = 0; column1 < row; column1++){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            for(int _base = 0; _base < 5; _base++){
                for(int column1 = 0; column1 < input - (input/2); column1++){
                    Console.Write(" ");
                }

                for(int column2 = 0; column2 < input; column2++){
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("*");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}