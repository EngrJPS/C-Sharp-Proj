using System;

namespace Activity6{
    class Activity6{
        public static void Main(string[] args){
            var spm = new SecurityPassMaker();
            Console.WriteLine(spm.GetDisplayName(new Manager()));
            Console.WriteLine(spm.GetDisplayName(new Physio()));
            Console.WriteLine(spm.GetDisplayName(new InternSecurity()));
            Console.WriteLine(spm.GetDisplayName(new OffensiveCoach()));
            Console.WriteLine(spm.GetDisplayName(new SecurityTeamMember()));
        }
    }

    public class SecurityPassMaker{

        public string GetDisplayName(TeamSupport support){
            if(support is Staff){
                var displayName = support.Title;
                if(!(support is JuniorSecurity) && !(support is InternSecurity) && !(support is LiasonPolice)
                && !(support is Physio) && !(support is GoalKeepingCoach) && !(support is OffensiveCoach)){
                    displayName += " Priority Personnel";
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                return displayName;
            }
            Console.ForegroundColor = ConsoleColor.Red;
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

        public class OffensiveCoach : Staff{
            public override string Title{
                get;
            } = "The Offensive Coach";
        }

        public class GoalKeepingCoach : Staff{
            public override string Title{
                get;
            } = "The Goalkeeping Coach";
        }

        public class JuniorSecurity : Staff{
            public override string Title{
                get;
            } = "Security Junior";
        }

        public class InternSecurity : Staff{
            public override string Title{
                get;
            } = "Security Intern";
        }

        public class LiasonPolice : Staff{
            public override string Title{
                get;
            } = "Police Liason";
        }

        public class SecurityTeamMember : Staff{
            public override string Title{
                get;
            }= "Security Team Member";
        }
}