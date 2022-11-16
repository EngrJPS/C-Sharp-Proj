using System;

namespace Activity11{
        class Activity11{
            public static void Main(String[] args){
                var log = "[INFO]: File Deleted.";
                var errLog = "[ERROR]: Missing ; on line 20.";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(log.SubstringAfter(": "));
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(log.SubstringBetween("[", "]"));
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(errLog.Message());
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(errLog.LogLevel());
                Console.ResetColor();
            }
        }

        public static class LogAnalysis{
            public static string SubstringAfter(this string str, string lmt){
                return str.Substring(str.IndexOf(lmt) + lmt.Length);
            }
            public static string SubstringBetween(this string str, string start, string end){
                return str.Substring(str.IndexOf(start) + start.Length, str.IndexOf(end) - end.Length);
            }
            public static string Message(this string str){
                return str.SubstringAfter(": ");
            }
            public static string LogLevel(this string str){
                return str.SubstringBetween("[", "]");
            }
        }
}