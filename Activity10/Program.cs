using System;

namespace Activity10{
    class Activity10{
        public static void Main(string[] args){
            stringAnagram.Anagram("Stone");
        }
    }

    class stringAnagram{
        public static void Anagram(string ACharacters){
            string[] choices = new string[]{"Stone", "tones", "tons", "notes", "Seton"};
            foreach(string anagrams in choices){
                switch(ACharacters){
                    case "Stone":
                    Console.Write(anagrams + " ");
                    break;
                }
            }
        }
    }
}