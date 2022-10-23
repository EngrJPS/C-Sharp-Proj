using System;

namespace Activity5{
    class Activity5{
        public static void Main(string[] args){
            var knightIsAwake = false;
            var archerIsAwake = true;
            var prisonerIsAwake = false;
            var isPetDog = false;

            Console.WriteLine(questLogic.CanFastAttack(knightIsAwake));
            bool val = questLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
            Console.WriteLine(val);

            Console.WriteLine(questLogic.SignalPrisoner(archerIsAwake, prisonerIsAwake));

            Console.WriteLine(questLogic.FreePrisoner(isPetDog, knightIsAwake, archerIsAwake, prisonerIsAwake));
        }
    }

    public static class questLogic{
        public static bool CanFastAttack(bool knightState){
            if(knightState == true){
                return false;
            }
            return true;
        }

        public static bool CanSpy(bool knightState, bool archerState, bool prisonerState){
            if(knightState == false && archerState == true && prisonerState == true){
                return true;
            }else if(knightState == true && archerState == true && prisonerState == false){
                return true;
            }else if(knightState == true && archerState == false && prisonerState == true){
                return true;
            }
            return false;
        }

        public static bool SignalPrisoner(bool archerState, bool prisonerState){
            if(prisonerState == true && archerState == false){
                return true;
            }
            return false;
        }

        public static bool FreePrisoner(bool petDog, bool archerState, bool knightState, bool prisonerState){
            if(petDog == true && archerState == false){
                return true;
            }else if(archerState == false && knightState == false &&prisonerState == true){
                return true;
            }
            return false;
        }
    }
}