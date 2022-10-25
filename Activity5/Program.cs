using System;


namespace Activity5{
    class Activity5{
        public static void Main(string[] args){
            var rand = new Random();
            
            var knightIsAwake = rand.NextDouble() > 0.5;
            var archerIsAwake = rand.NextDouble() > 0.5;
            var prisonerIsAwake = rand.NextDouble() > 0.5;
            var isPetDog = rand.NextDouble() > 0.5;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Annalyn\'s Infiltration RPG");
            Console.ResetColor();

            while(true){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Select what move can Annalyn take? ");
                var d = Console.ReadLine() ?? "0";
                switch(d){
                    case "FastAttack":
                    questLogic.CanFastAttack(knightIsAwake);
                    break;

                    case "CanSpy":
                    questLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
                    break;

                    case "SignalPrisoner":
                    questLogic.SignalPrisoner(archerIsAwake, prisonerIsAwake);
                    break;

                    case "FreePrisoner":
                    questLogic.FreePrisoner(isPetDog, archerIsAwake, knightIsAwake, prisonerIsAwake);
                    break;

                    default:
                    Console.WriteLine($"No command found: {d}");
                    break;

                }
            }
        }
    }

    public static class questLogic{
        public static bool CanFastAttack(bool knightState){
            if(knightState == true){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Knight\'s state is awake");
                Console.ResetColor();
                return false;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Knight\'s state is asleep");
            Console.ResetColor();
            return true;
        }

        public static bool CanSpy(bool knightState, bool archerState, bool prisonerState){
            if(knightState == false && archerState == true && prisonerState == true){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You can\'t! The knight\'s state is {(knightState ? "asleep" : "awake")} and archer\'s state is {(archerState ? "asleep" : "awake")}");
                return true;
            }else if(knightState == true && archerState == true && prisonerState == false){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You can\'t! The knight\'s state is {(knightState ? "asleep" : "asleep")} and archer\'s state is {(archerState ? "asleep" : "awake")}");
                return true;
            }else if(knightState == true && archerState == false && prisonerState == true){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You can\'t! The knight\'s state is {(knightState ? "asleep" : "awake")} and archer\'s state is {(archerState ? "asleep" : "awake")}");
                return true;
            }else if(knightState == false && archerState == true && prisonerState == true){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You can\'t! The knight\'s state is {(knightState ? "asleep" : "awake")} and archer\'s state is {(archerState ? "asleep" : "awake")}");
                return true;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You can! The knight\'s state is {(knightState ? "awake" : "asleep")} and archer\'s state is {(archerState ? "awake" : "asleep")}");
            return false;
        }

        public static bool SignalPrisoner(bool archerState, bool prisonerState){
            if(prisonerState == true && archerState == false){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Signal the prisoner!");
                Console.ReadLine();
                return true;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You can\'t, the prisoner is {prisonerState}");
            return false;
        }

        public static bool FreePrisoner(bool petDog, bool archerState, bool knightState, bool prisonerState){
            if(petDog == true && archerState == false){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can't free the prisoner");
                Console.ResetColor();
                return true;
            }else if(archerState == false && knightState == false &&prisonerState == true){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can't free the prisoner");
                Console.ResetColor();
                return true;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You can free the prisoner!");
            Console.ResetColor();
            return false;
        }
    }
}