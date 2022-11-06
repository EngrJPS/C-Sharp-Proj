using System;
using System.Text;

namespace Activity8{
    class squekyClean{
        public static void Main(string[] args){
            string name = "my   ID";
            Identifier.Clean(name);
            Identifier.Clean("my\0ID");
            Identifier.Clean("a-ḃc");
        }
    }

    class Identifier{
        
        public static void Clean(string notClean){
            StringBuilder sb = new StringBuilder(notClean, notClean.Length);
            foreach(char character in notClean){
                if(character == ' '){
                    sb.Replace(' ','_');
                }else{
                    if(char.IsControl(character)){
                        sb.Append("CTRL");
                        continue;
                    }
                    if(character == '-'){
                        if(character == 'ḃ'){
                            sb.Append('Ḃ');
                        }
                    }

                }

                if(char.IsControl(character)){
                    
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}