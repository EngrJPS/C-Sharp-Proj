using System;

namespace birdWatcher{
    class Activity4{

        public static void Main(string[] args){
            int[] birdsPerDay = {2, 5, 0, 1, 4, 7};
            var bird = new birdCounter(birdsPerDay);
            Console.WriteLine(bird.Today());
            Console.WriteLine(bird.IncrementTodaysCount());
            Console.WriteLine(birdCounter.LastWeek());
        }
    }

    class birdCounter{
        private int[] birdsPerDay;

        public birdCounter(int[] someArray){
            this.birdsPerDay = someArray;
        }

        public static int[] LastWeek(){
            return new int []{0, 2, 5, 3, 7, 8, 4};
        }

        public int Today(){
            if(birdsPerDay != null && birdsPerDay.Length > 0){
                return birdsPerDay[birdsPerDay.Length - 1];
            }else{
                return 0;
            }
        }

        public int IncrementTodaysCount(){
            if(birdsPerDay != null && birdsPerDay.Length > 0){
                birdsPerDay[birdsPerDay.Length - 1]++;
                return birdsPerDay[birdsPerDay.Length - 1];
            }
            return 0;
        }

        public bool HasDayWithoutBirds(){
            foreach(int i in birdsPerDay){
                if(i == 0){
                    return true;
                }
            }
            return false;
        }

        public int CountForFirstDays(int value){
            int sum = 0;
            foreach(int i in birdsPerDay){
                sum += i;
            }
            return sum;
        }

        public int BusyDays(){
            int birdBusy = 0;
            foreach(int b in birdsPerDay){
                if(b >= 5){
                    birdBusy++;
                }
            }
            return birdBusy;
        }
    }
}