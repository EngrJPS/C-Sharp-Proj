using System;

namespace Program
{
    class Names{
        //Example of the class or object oriented programming (OOP)
        public void nums(){
            int[] num = {10,20,30};
            for(int i = 0; i < num.Length; i++){
                Console.WriteLine(num[i]);
            }
        }
        //Function surname that returns the surname of the user
        void Surname(string? x){
            Console.Write("This is the Users surname:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}", x);
            Console.ResetColor();
        }

        //Function firstname that returns the first name of the user
        void Firstname(string? y){
            Console.Write("This is the users First name:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}", y);
            Console.ResetColor();
        }

        //Function that displays the fullname of the user
        void Fullname(string? a, string? b){
            Console.Write("This is the users' Fullname:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}, {1}",a , b);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome back, {0},{1}, " + $"you logged in at {DateTime.Now}", a, b);
            Console.ResetColor();
            Console.WriteLine(" ");
        }

        //Function of the guessing game for the user
        void guessGame(int c, int d, int e){
            int life = 0;
            //Prints the instruction for the user
            Console.WriteLine("You have only three attempts to guess the number...\nEnter any key to continue...");
            Console.ReadKey();
            //While the user hasn't guessed the answer yet
            while(c != d){
                //Prints the instruction for the user
                Console.Write($"Guess the number from 1 to {e}:\t");
                //Takes the input from the user
                string? num1 = Console.ReadLine() ?? "0";
                //Checks the input from the user if it's integer
                //While the input is not convertable to integer, try again
                while(!int.TryParse(num1, out c)){
                    //Instructs the user to use an integer data type
                    Console.Write("Please enter an integer data type:\t");
                    //User input the nth tries of data
                    num1 = Console.ReadLine() ?? "0";
                }
                //If the user input is greater than the computer generated number prints Err
                if(c > d){
                    //Prints the error in red and instructs the user to try again
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{DateTime.Now}: Incorrect! Number too high, please try again!");
                    Console.ResetColor();
                    //life counter used, increase to 1
                    life++;
                //If the user input is less than the computer generated number, prints Err
                }else if (c < d){
                    //Prints the error in red and instructs the user to try again
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{DateTime.Now}: Incorrect! Number too low, please try again!");
                    Console.ResetColor();
                    //life counter used, increase to 1
                    life++;
                }

                //If life counter is equal to 3, Game Over 
                if(life == 3){
                    //Prints the try again and press any key to continue
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again...\nPress any key to continue...");
                    //Resets the life counter to zero to play again
                    life = 0;
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            //If the user guessed the computer generated number within 3 trials, print celebration
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{DateTime.Now}: " + "Yay! You've guessed the number {0}", d);
            Console.ResetColor();
        }

        public class Tumbler{
            public int mL {
                get; set;
            }
            public string? color{
                get; set;
            }

            public Tumbler(){

            }

            public Tumbler(string a){
                this.color = a;
            }
        }

        String[] names = {"Jimson", "Paul", "Serafin"};

        //Main function of the Program.cs
        static void Main (String[] args){
            //Creating an object name from the class Names
            Names name = new Names();
            //Including rand to generate Random numbers
            Random rand = new Random();
            //Creating an object name sple from the multipleClasses.cs from the class SampleColor
            SampleColor sple = new SampleColor();
            // for(int i = 0; i < name.names.Length; i ++){
            //     Console.WriteLine(name.names[i]);
            // }
            // name.nums();
            
            //Asking the user for his/her surname in dark cyan color
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("What is your surname?\t");
            Console.ResetColor();
            //User input his/her surname
            string? Sname = Console.ReadLine();
            //Asking the user for his/her first name
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("What is your first name?\t");
            Console.ResetColor();
            //User input his/her first name
            string? Fname = Console.ReadLine();
            
            //Prints the surname from the input of the user
            name.Surname(Sname);
            
            //Prints the firstname from the input of the user
            name.Firstname(Fname);

            //Prints the full name of the user w/ the exact time he/she logged in
            name.Fullname(Sname, Fname);   

            //Prints a welcoming message for the user, inviting him/her to a game
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to guessing game ver. 1.0.0 by {0}, {1}", Sname, Fname);
            Console.ResetColor();
            
            //Asking the user to enter a number to guess from 1 to {users.input}
            Console.WriteLine("Enter range to guess:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //User input his/her range for the game
            string? num = Console.ReadLine() ?? "0";
            int maxNum = 0;
            Console.ResetColor();
            
            //While number entered by the user is not an integer, print Err until User enters an integer
            while(!int.TryParse(num, out maxNum)){
                //Prints Error in color red
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Make sure that you enter an integer type:\t");
                Console.ResetColor();

                //User re-enter the data to check the computer again
                num = Console.ReadLine();

                //If string successfully converted from integer, prints Success
                if(int.TryParse(num, out maxNum)){
                    maxNum = Int32.Parse(num);
                    //Asks the user to press a key to continue in the code
                    Console.WriteLine("Please enter any key to continue...");
                    Console.ReadLine();
                }
            }

            //Generates the number to be guess by the user
            int range = rand.Next(1, maxNum);
            //Sets the guessAns to zero
            int guessAns = 0;

            name.guessGame(guessAns, range, maxNum);

            //Asks the user to pick a color
            Console.Write("Pick any color:\t");
            //Computer accepts the data from the user
            string? color = Console.ReadLine();
            //Calls the object named sple with the function colorSomething
            sple.colorSomething(color);
            //Asks the user to enter favorite number
            Console.Write("Enter your favorite number:\t");
            //Computer reads the input value from the user and store it in n
            //Computer calls the sampleClass with the function named favNum
            int? n = sampleClass.favNum(Console.ReadLine() ?? " ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your favorite number is: {n}");
            Console.ResetColor();

            Tumbler aquaFlask = new Tumbler{
                mL = 1000, color = "Yellow"
            };
            Tumbler sameAquaFlask = new Tumbler("Green"){mL = 1000};

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{aquaFlask.color}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{sameAquaFlask.color}");
            Console.ResetColor();

        }
    }
}
