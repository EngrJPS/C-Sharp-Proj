/*
Convert a phrase to its acronym.

Techies love their TLA (Three Letter Acronyms)!

Help generate some jargon by writing a program that converts a long name 
like Portable Network Graphics to its acronym (PNG).

Punctuation is handled as follows: hyphens are word separators (like whitespace); all other punctuation can be removed from the input.

Punctuation is handled as follows: hyphens are word separators (like whitespace); 
all other punctuation can be removed from the input.
*/
using System;

namespace Activity9{
    class Activity9{
        public static void Main(string[] args){
            Cleaning.stringAcronym("As Soon As Possible");
            Cleaning.stringAcronym("Liquid-crystal display");
            Cleaning.stringAcronym("Thank George It's Friday!");
        }
    }

    class Cleaning{
        public static void stringAcronym(string someCharacters){
            char[]? Acronyms = new char[someCharacters.Length];
            char[]? Acronyms1 = new char[someCharacters.Length];
            for(int k = 0; k < someCharacters.Length; k++){
                Acronyms[k] = someCharacters[k];
            }
            for(int i = 0; i < someCharacters.Length; i++){
                if(char.IsUpper(Acronyms[i])){
                    Acronyms1[i] = Acronyms[i];
                }else if('-'.Equals(Acronyms[i])){
                    Acronyms1[i] = char.ToUpper(Acronyms[i+1]);
                }else if(char.IsWhiteSpace(Acronyms[i]) && char.IsUpper(Acronyms[i])){
                    Acronyms1[i] = char.ToUpper(Acronyms[i+1]);
                }
            }
            for(int j = 0; j < Acronyms1.Length; j++){
                Console.Write(Acronyms1[j]);
            }
            Console.WriteLine();
        }
    }
}