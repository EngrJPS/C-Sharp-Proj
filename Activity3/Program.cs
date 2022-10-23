using System;

namespace dinnerDate{
    class dinnerDate{
        public static void Main(string[] args){
            var lasanga = new Lasanga();

            Console.Write("The expected minutes to cook a lasanga is:\t" + lasanga.ExpectedMinutesOven()+"\n");

            Console.Write("How long is the lasanga in the oven?\t");
            int timeOven = Convert.ToInt32(Console.ReadLine() ?? "0");
            Console.WriteLine("Time remaining to cook the lasanga is:\t"+ lasanga.RemainingMinutesInOver(timeOven));

            Console.Write("How many layers to of lasanga did you prepare?\t");
            int layerLasanga = Int32.Parse(Console.ReadLine()?? "0");

            if(layerLasanga == 1){
                Console.WriteLine($"The time to prep a {layerLasanga} layer of lasanga is " + lasanga.PreparationTimeInMinutes(layerLasanga)+ " mins");
            }else{
                Console.WriteLine($"The time to prep a {layerLasanga} layers of lasanga are " + lasanga.PreparationTimeInMinutes(layerLasanga)+ " mins");
            }

            Console.Write("The total time you've worked on the lasanga is " + lasanga.ElapsedTimeInMinutes(layerLasanga, timeOven)+ " mins");
        }
    }

    class Lasanga{

        int mins = 40;

        int totalLayer = 0;

        public int ExpectedMinutesOven(){
            return mins;
        }
        public int RemainingMinutesInOver(int value){
            return mins - value;
        }
        
        public int PreparationTimeInMinutes(int layerLasanga){
            totalLayer = layerLasanga * 2;
            return totalLayer;
        }

        public int ElapsedTimeInMinutes(int layers, int numMinOven){
            return PreparationTimeInMinutes(layers) + numMinOven;
        }
    }
}