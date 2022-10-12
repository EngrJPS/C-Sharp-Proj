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

        void Surname(string? x){
            Console.Write("This is the Users surname:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}", x);
            Console.ResetColor();
        }

        void Firstname(string? y){
            Console.Write("This is the users First name:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}", y);
            Console.ResetColor();
        }

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

        void guessGame(int c, int d, int e){
            while(c != d){
                Console.WriteLine("Guess the number from 1 to {0}", e);
                string? num1 = Console.ReadLine() ?? "0";
                c = Int32.Parse(num1);

                if(c > d){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{DateTime.Now}: Incorrect! Number too high, please try again!");
                    Console.ResetColor();
                }else if (c < d){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{DateTime.Now}:Incorrect! Number too low, please try again!");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{DateTime.Now}: " + "Yay! You've guessed the number {0}", d);
            Console.ResetColor();
        }

        String[] names = {"Jimson", "Paul", "Serafin"};

        static void Main (String[] args){
            Names name = new Names();
            Random rand = new Random();
            SampleColor sple = new SampleColor();
            
            // for(int i = 0; i < name.names.Length; i ++){
            //     Console.WriteLine(name.names[i]);
            // }
            // name.nums();

            // Console.WriteLine("Hello! What's your name? ");
            // string s = Console.ReadLine();
            // Console.WriteLine("Hello!\t"+ s);
            // Console.ReadKey(); 

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("What is your Surname?\t");
            Console.ResetColor();
            string? Sname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("What is your first name?\t");
            Console.ResetColor();
            string? Fname = Console.ReadLine();
            
            //Prints the surname from the input of the user
            name.Surname(Sname);
            
            //Prints the firstname from the input of the user
            name.Firstname(Fname);

            //Prints the full name of the user
            name.Fullname(Sname, Fname);   

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to guessing game ver. 1.0.0 by {0}, {1}", Sname, Fname);
            Console.ResetColor();

            Console.WriteLine("Enter range to guess:\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? num = Console.ReadLine() ?? "0";
            int maxNum = 0;
            Console.ResetColor();
            
            while(!int.TryParse(num, out maxNum)){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Make sure that you enter an integer type:\t");
                Console.ResetColor();

                num = Console.ReadLine();

                if(int.TryParse(num, out maxNum)){
                    maxNum = Int32.Parse(num);
                    Console.WriteLine("Please enter any key to continue...");
                    Console.ReadLine();
                }
            }
            int range = rand.Next(1, maxNum);
            int guessAns = 0;

            name.guessGame(guessAns, range, maxNum);

            Console.Write("Pick any color:\t");
            string? color = Console.ReadLine();
            sple.colorSomething(color);
            Console.Write("Enter your favorite number:\t");
            string? n = sampleClass.favNum(Console.ReadLine() ?? " ");
            int someThing;

            while(!int.TryParse(n, out someThing)){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please enter an integer data type:\t");
                Console.ResetColor();
                n = Console.ReadLine();
                if(int.TryParse(n, out someThing)){
                    Console.ForegroundColor = ConsoleColor.Green;
                    someThing = Int32.Parse(n ?? "");
                    Console.ResetColor();
                }
            }

            Console.WriteLine("Your favorite number is: {0}", someThing);
        }
    }
}