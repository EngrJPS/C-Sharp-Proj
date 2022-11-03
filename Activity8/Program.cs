using System;
using System.Text;

namespace Activity8{
    class squekyClean{
        public static void Main(string[] args){
            string name = "my   ID";
            Identifier.Clean(name);
            Identifier.Clean("my/0ID");
        }
    }

    class Identifier{
        
        public static void Clean(string notClean){
            char[] special = {'/','\'', '0', '1'};
            char []charArr = new char [notClean.Length];
            StringBuilder sb = new StringBuilder(notClean, 50);
            sb.Replace(' ','_');
            for(int i = 0; i < notClean.Length; i++){
                charArr[i] = notClean[i];
                for(int j = 0; j < special.Length; j++){
                    if(charArr[i] == special[j]){
                        sb.Replace(special[j], ' ');
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}