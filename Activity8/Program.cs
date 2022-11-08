using System;
using System.Text;

namespace Activity8{
    class squekyClean{
        public static void Main(string[] args){
            string name = "my   ID";
            Identifier.Clean(name);
            Identifier.Clean("my\0ID");
            Identifier.Clean("a-bc");
        }
    }

    class Identifier{
        
        public static void Clean(string notClean){
            StringBuilder sb = new StringBuilder(notClean, notClean.Length);
            foreach(var character in notClean){
                switch(character){
                    case ' ':
                    sb.Replace(' ', '_');
                    continue;
                    case '\0':
                    sb.Append("CTRL");
                    continue;
                    case '-':
                    sb.Replace("-","");
                    continue;
                }
                if(character == 'b'){
                    sb.Append('B');
                }else{
                    sb.Append(char.ToUpperInvariant(character));
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}