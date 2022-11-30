/*
Reverse a string

For example: input: "cool" output: "looc"
*/
using System;

namespace Activty13{
    class Activty13{
        public static void Main(string[] args){
            Console.WriteLine(Word.Reverse("cool"));
        }
    }

    class Word{
        public static string Reverse(string message){
            foreach(char s in message){
                Console.Write(s + " ");
            }
            Console.WriteLine();
            if(message.Length <= 1) return message;
            return message.Substring(message.Length - 1, 1) + Reverse(message.Substring(0, message.Length - 1)); 
        }
    }
}