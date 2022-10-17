using System;

/*
Make a program that asks the users Surname, Firstname and the time and date that he/she
logged in.
Make a guessing game
*/

namespace activity1{
    class activity1{
        public static void Main(string[] args){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter your surname:\t");
            Console.ResetColor();
            string n = Console.ReadLine() ?? "0";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter your firstname:\t");
            Console.ResetColor();
            string o = Console.ReadLine() ?? "0";
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(surName(n));
            Console.WriteLine(firstName(o));
            Console.WriteLine("Welcome! " + fullName(n, o) + $" you logged in at {DateTime.Now}.");
            Console.ResetColor();

            Console.Write("Enter a number to guess from 1 to x?:\t");
            string p = Console.ReadLine() ?? "0";
            Console.WriteLine(guessingGame(p));
        }

        public static string surName(string sname){
            string x = "The users\' surname is:\t" + sname;
            return x;
        }

        public static string firstName(string fname){
            string y = "The users\' first name is:\t" + fname;
            return y;
        }

        public static string fullName(string sname, string fname){
            string z = "The users\' fullname is:\t" + sname + ", " + fname;
            return z;
        }

        public static int guessingGame(string number){
            Random rand = new Random();
            int n = 0;
            string userStAns = " ";
            int userInAns = 0;

            while(string.IsNullOrWhiteSpace(number)){
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please enter your number:\t");
                Console.ResetColor();
                number = Console.ReadLine() ?? "0";
            }

            while(!int.TryParse(number, out n)){

                if(string.IsNullOrWhiteSpace(number)){
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please enter your number:\t");
                    Console.ResetColor();
                    number = Console.ReadLine() ?? "0";
                }else{
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please enter an integer data type:\t");
                    Console.ResetColor();
                    number = Console.ReadLine() ?? "0";
                }

            }

            Console.ForegroundColor = ConsoleColor.Green;
            n = Convert.ToInt32(number);
            Console.ResetColor();

            int guessAns = rand.Next(1, n);

            Console.Write($"Guess the number from 1 to {n}\n" + "Now enter a number:\t");
            userStAns = Console.ReadLine() ?? "0";

            while(!int.TryParse(userStAns, out n)){

                if(string.IsNullOrWhiteSpace(userStAns)){
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please enter a number to guess:\t");
                    Console.ResetColor();
                    userStAns = Console.ReadLine() ?? "0";
                }else{
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please enter an integer data type:\t");
                    Console.ResetColor();
                    userStAns = Console.ReadLine() ?? "0";
                }
                
            }

            userInAns = Convert.ToInt32(userStAns);
            
            while(userInAns != guessAns){
                if(userInAns > guessAns){
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Err! Number is too high, please try again\t");
                    Console.ResetColor();
                }else if(userInAns < guessAns){
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Err! Number is too low, please try again:\t");
                    Console.ResetColor();
                }
                userInAns = Convert.ToInt32(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Yay! You got the right answer:\t");
            Console.ResetColor();

            return guessAns;
        }
    }
}