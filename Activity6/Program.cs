using System;

namespace Activity6{
    class Activity6{
        public static void Main(string[] args){
            var spm = new SecurityPassMaker();
            Console.WriteLine(spm.GetDisplayName(new Manager()));
            Console.WriteLine(spm.GetDisplayName(new Physio()));
        }
    }

    public class SecurityPassMaker{

        public string GetDisplayName(TeamSupport support){
            if(support is Staff){
                var displayName = support.Title;
                if(!(support is Manager)){
                    displayName += " Priority Personnel";
                }
                return displayName;
            }
            return "Too Important for a Security Pass";
        }
    }
        public interface TeamSupport{
            string Title{
                get;
            }
        }
        public abstract class Staff : TeamSupport{
            public abstract string Title{
                get;
            }
        }

        public class Manager : TeamSupport{
            public string Title{
                get;
            }
            = "The Manager";
        }

        public class Chairperson : TeamSupport{
            public string Title{
                get;
            } = "The Chairperson";
        }

        public class Physio : Staff{
            public override string Title{
                get;
            }= "The Physio";
        }

        public class JuniorSecurity : Staff{
            public override string Title{
                get;
            } = "Security Junior";
        }
}