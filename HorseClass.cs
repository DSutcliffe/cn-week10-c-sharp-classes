using System;

namespace cn_week10_c_sharp_classes
{
    class Horse {
        public string HorseName;
        public string JockeyName;
        public string TrainerName;
        public int HorseAge;
        public int NumberOfWins;

        public void RaceHorseDeets() {
            Console.WriteLine("The horses name is: {0}", HorseName);
            Console.WriteLine("The jockey name is: {0}", JockeyName);
            Console.WriteLine("The trainer name is: {0}", TrainerName);
            Console.WriteLine("The horse has an age of: {0}", HorseAge);
            Console.WriteLine("The horse has won {0} times", NumberOfWins);
        }
    }
}