using System;
using System.Collections.Generic;

namespace activity2{
    /*
    Make a program that uses List
    Make an interactive program that Lists all the item
    */
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

            Console.Write("Please enter a number for the weight of the array:\t");
            int data = Convert.ToInt32(Console.ReadLine() ?? "0");

            arrNames(data);

            Console.Write("Do you want to Continue (Y/N):\t");
            string decision = Console.ReadLine() ?? "0";
            bool start = true;

            if(string.Equals(decision, "y", StringComparison.OrdinalIgnoreCase)){
                decision = decision.ToUpper();
            }else if(string.Equals(decision, "n", StringComparison.OrdinalIgnoreCase)){
                decision = decision.ToUpper();
            }

            while(start){
                switch(decision){
                    case "Y":
                        Console.Write("Please enter a number for the weight of the array:\t");
                        data = Convert.ToInt32(Console.ReadLine() ?? "0");

                        arrNames(data);
                        Console.Write("Do you want to Continue (Y/N):\t");
                        decision = Console.ReadLine() ?? "0";

                        if(string.Equals(decision, "y", StringComparison.OrdinalIgnoreCase)){
                            decision = decision.ToUpper();
                        }else if(string.Equals(decision, "n", StringComparison.OrdinalIgnoreCase)){
                            decision = decision.ToUpper();
                        }
                        
                        break;
                    case "N":
                        start = false;
                        break;
                    }
                }
            Console.WriteLine("The program is complete!");
        }

        public static void arrNames(int data){
            string[] input = new string [data];

            List<string> something = new List<string>(input);

            Console.WriteLine("Write names:\t");
            for(int i = 0; i < input.Length; i++){
                string name = Console.ReadLine() ?? "0";
                input[i] = name;
                something.Add(input[i]);
            }
            
            foreach(string somethings in something){
                Console.Write(somethings + " ");
            }

            Console.WriteLine($"\n Capacity of input: \t{something.Capacity}\n");
            something.AddRange(input);

            Console.WriteLine("Write another names:");

            input = new string[data];
            
            for(int i = 0; i < input.Length; i++){
                string name = Console.ReadLine() ?? "0";
                input[i] = name;
                something.Add(input[i]);
            }

            // something.InsertRange(input.Length, input);

            foreach(string somethings in something){
                Console.Write(somethings + " ");
            }

            Console.WriteLine();
        }
    }
}