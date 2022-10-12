using System;

class Car{
    string color = "";
    int platNumber;
    string model = "";
    public void describeCar(string x, int y, string z){
        Console.WriteLine("The color of the car is:\t{0}", x);
        Console.WriteLine("The plate number of the car is:\t{0}", y);
        Console.WriteLine("The model of the car is:\t{0}", z);
    }
}