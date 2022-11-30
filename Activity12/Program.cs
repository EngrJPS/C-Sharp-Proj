//Exercism Exercise called 'Bob'

/*
Bob is a lackadaisical teenager. In conversation, his responses are very limited.

Bob answers 'Sure.' if you ask him a question, such as "How are you?".

He answers 'Whoa, chill out!' if you YELL AT HIM (in all capitals).

He answers 'Calm down, I know what I'm doing!' if you yell a question at him.

He says 'Fine. Be that way!' if you address him without actually saying anything.

He answers 'Whatever.' to anything else.

Bob's conversational partner is a purist when it comes to written communication and always follows normal rules regarding sentence punctuation in English.
*/

using System;
using System.Timers;

namespace Activity12{
    
    class Activity12{
        
        public static void Main(String[] args){
            Console.WriteLine("You can now interact with Bob!");
            bool dec = true;
            lackadaisicalBob.intervalTimer();
            string ans = Console.ReadLine()??" ";
            if(!string.IsNullOrWhiteSpace(ans)){
                while(dec){
                    Console.WriteLine(lackadaisicalBob.Response(Console.ReadLine()??""));
                    Console.Write("Do you want to interact again? ");
                    string choice = Console.ReadLine()??" ";

                    switch(choice){
                        case "Y":
                        Console.WriteLine(lackadaisicalBob.Response(Console.ReadLine()??""));
                        break;
                        case "N":
                        dec = false;
                        break;
                        default:
                        Console.WriteLine("I don't know anymore");
                        break;
                    }
                    Console.WriteLine("Thank you for using this app!");
                }
            }
            lackadaisicalBob.tTimes.Stop();
            lackadaisicalBob.tTimes.Dispose();
            Console.WriteLine("Thank you for using this app!");
        }
        
    }

    class lackadaisicalBob{
        public static System.Timers.Timer tTimes;
        public static string Response(string message){
            
            if(isSilence(message))
                return "Fine. Be that way!";
            if(isQuestion(message) && isYell(message))
                return "Calm down, I know what I'm doing!";
            if(isYell(message))
                return "Whoa, chill out!";
            
            return "Whatever";
        }

        private static bool isSilence(string message){
            return string.IsNullOrWhiteSpace(message);
        }

        private static bool isQuestion(string message){
            return message.TrimEnd().EndsWith("?");
        }

        private static bool isYell(string message){
            return message.Any(char.IsLetter) && message.ToUpperInvariant() == message;
        }

        public static void intervalTimer(){
            tTimes = new System.Timers.Timer(5000);
            tTimes.Elapsed += bobAwkward;
            tTimes.AutoReset = true;
            tTimes.Enabled = true;
        }

        public static void bobAwkward(Object source, ElapsedEventArgs e){
            Console.WriteLine("Okay, bye!", e.SignalTime);
        }

    }
}