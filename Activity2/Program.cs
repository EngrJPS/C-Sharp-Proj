using System;
using System.Collections.Generic;

namespace activity2{
    /*
    Make a program that uses List
    Make an interactive program that Lists all the item
    */
    class Activity2{
        public static void Main(string[] args){

            carModel car = new carModel();

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
            decision = stringUpper(decision);

            bool start = true;
            while(start){
                switch(decision){
                    case "Y":
                        Console.Write("Please enter a number for the weight of the array:\t");
                        data = Convert.ToInt32(Console.ReadLine() ?? "0");
                        arrNames(data);

                        Console.Write("Do you want to Continue (Y/N):\t");
                        decision = Console.ReadLine() ?? "0";
                        decision = stringUpper(decision);
                        
                        break;
                    case "N":
                        start = false;
                        break;
                    }
                }
            Console.WriteLine("The program is complete!");

            Console.Write("What is the car model:\t");
            car.model = Console.ReadLine();

            Console.Write("What is the car maxSpeed:\t");
            car.maxSpeed = Convert.ToInt32(Console.ReadLine() ?? "0");

            if(car.isCar == true){
                Console.Write($"The car is {car.model} and its max speed is {car.maxSpeed}, the car is {car.isCar}");
            }else{
                Console.Write($"The car is a {car.isCar}");
            }
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

        public static string stringUpper(string x){
            if(string.Equals(x, "y", StringComparison.OrdinalIgnoreCase)){
                x = x.ToUpper();
            }else if(string.Equals(x, "n", StringComparison.OrdinalIgnoreCase)){
                x = x.ToUpper();
            }
            return x;
        }
    }
}