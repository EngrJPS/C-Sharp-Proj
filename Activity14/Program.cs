using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Activity14{
    class Activity14{
        public static void Main(string[] args){
            Console.Write(RotationalCipher.Rotational("OMG", 5));
            Console.Write(RotationalCipher.Rotational("\nGur dhvpx oEbja sbk whzcf bire gur ynml qbt", 13));
            Console.Write(RotationalCipher.leftRot("\nThe quick brown fox jumps over the lazy dog", 13));
        }
        //This is the class for Rotational Cipeher named RotationalCipher
        public static class RotationalCipher{
            //This method is called Rotational that returns a string
            //This method shifts rotational to the right
            public static string Rotational(string text, int index){
                //This is a variable named Rotation
                char Rotation(char c){
                    //If variable c is not a letter return the original value
                    if(!char.IsLetter(c)) return c;
                    //If the variable c is an uppercase or lowercase return 1 or 0
                    int num = char.IsLetter(c)? 'a':'A';
                    return (char)((c - num + index) % 26 + num);
                }
                //return variable Rotation in a string format
                return string.Concat(text.Select(Rotation));
            }

            public static string leftRot(string text, int index){
                char Rotation(char c){
                    if(!char.IsLetter(c)) return c;
                    int num = char.IsLetter(c) ? 'a':'A';
                    //This returns a shift to the left
                    return (char)((c + num - index) % 26 + num);
                }
                return string.Concat(text.Select(Rotation));
            }
        }
    }
}