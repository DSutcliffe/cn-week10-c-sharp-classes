using System;

namespace cn_week10_c_sharp_classes
{
    class PrintingClass {
        public void PrintingFunction() {
            Console.WriteLine("*print*");
        }

        public void RandomFunction() {
            Console.WriteLine("*print*");
        }

        public void AllTheData() {
            Console.WriteLine("Hopefully, something is printed below me.");
            PrintingFunction();
            RandomFunction();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create new instance of class
            PrintingClass myNewPrintingClass = new PrintingClass();
            myNewPrintingClass.AllTheData();

            Horse HorseyMcHorseFace = new Horse();
            HorseyMcHorseFace.HorseName = "Horsey McHorseFace";
            HorseyMcHorseFace.JockeyName = "Jockey McJockeyFace";
            HorseyMcHorseFace.TrainerName = "Traner McTraiunerFace";
            HorseyMcHorseFace.HorseAge = 3;
            HorseyMcHorseFace.NumberOfWins = 400;

            // Cannot call Error without somewhereElse because used different namespace
            somewhereElse.Error myNewError = new somewhereElse.Error();
            myNewError.ErrorMessage = "Don't gamble, kids";
        }
    }
}
