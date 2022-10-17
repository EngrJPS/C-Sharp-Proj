using System;

namespace activity2{
    class Activity2{
        public static void Main(string[] args){

            int result = 0;

            Console.Title = "Activity2";
            Console.WriteLine("Hello World!");
            Random rnd = new Random();

            int []arr = new int[4];

            for(int i = 0; i < arr.Length; i++){
                
                int numRandom = rnd.Next(1, 10);
                arr[i] = numRandom;
                Console.Write(arr[i] + " ");
                string sNum = arr[i].ToString();
                int iNum = Convert.ToInt32(sNum);
                result += iNum;
            }

            Console.WriteLine(" ");

            foreach(int i in arr){
                Console.Write(i + " ");
            }
            
            Console.WriteLine(" ");
            Console.WriteLine(result/arr.Length);
        }
    }
}