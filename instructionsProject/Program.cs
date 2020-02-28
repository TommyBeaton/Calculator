using System;

namespace instructionsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNum1 = "", strNum2 = "";
            double dblNum1 = 0, dblNum2 = 0, dblTotal;
            bool loopProgram = true;

            while (loopProgram)
            {
                strNum1 = "";
                strNum2 = "";

                Console.WriteLine("Hello and welcome to the calculator");
                Console.WriteLine("Here we are going to add 2 numbers together");
                while (!double.TryParse(strNum1, out dblNum1))
                {
                    Console.WriteLine("Please enter number 1");
                    strNum1 = Console.ReadLine();
                }

                while (!double.TryParse(strNum2, out dblNum2))
                {
                    Console.WriteLine("Please enter number 2");
                    strNum2 = Console.ReadLine();
                }

                dblTotal = dblNum1 + dblNum2;
                Console.WriteLine($"Your total is: {dblTotal}");

                Console.WriteLine("---------------");
                Console.WriteLine(
                    "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");

                if (Console.ReadLine() == "n")
                {
                    loopProgram = false;
                }

                Console.Clear();
            }
        }
    }
}
