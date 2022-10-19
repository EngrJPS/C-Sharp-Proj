using System;

namespace dinnerDate{
    class dinnerDate{
        public static void Main(string[] args){
            var lasanga = new Lasanga();
            Lasanga lasanga1 = new Lasanga();

            Console.Write("The expected minutes to cook a lasanga is:\t" + lasanga.ExpectedMinutesOven()+"\n");
            Console.Write("How long is the lasanga in the oven?\t");
            int timeLeft = Convert.ToInt32(Console.ReadLine() ?? "0");
            Console.WriteLine("Time remaining to cook the lasanga is\t"+ lasanga.RemainingMinutesInOver(timeLeft));
            Console.Write("How many layers to of lasanga you will prepare?\t");
            int prepTime = Int32.Parse(Console.ReadLine()?? "0");
            Console.WriteLine($"The time to prep a {prepTime} layer/s is " + lasanga.PreparationTime(prepTime)+ " mins");
            Console.Write("The lasanga needs to be in the oven for " + lasanga.ElapsedTimeInMinutes(prepTime, timeLeft)+ " mins");
        }
    }

    class Lasanga{

        int mins = 40;

        int totalPrep = 0;

        public int ExpectedMinutesOven(){
            return mins;
        }
        public int RemainingMinutesInOver(int value){
            return mins - value;
        }
        
        public int PreparationTime(int prep){
            totalPrep = prep * 2;
            return totalPrep;
        }

        public int ElapsedTimeInMinutes(int layers, int numMinOven){
            return (layers * 2) + numMinOven;
        }
    }
}