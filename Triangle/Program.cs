using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Triangle
{
    class Program
    {

        public static void menuFunction()
        {
            Console.WriteLine("1. Enter Tringle Dimension");
            Console.WriteLine("2. Exit");
        }


        public static void Main(string[] args)
        {

            int s1, s2, s3;
            int userInput;

            menuFunction();
            
            do
            {
                Console.WriteLine("Enter the option from above choices: ");

            } while (!int.TryParse(Console.ReadLine(), out userInput) || userInput > 2 || userInput < 1);


            if (userInput == 1)
            {

                Console.Write("Input side 1 of triangle: ");
                s1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 2 of triangle: ");
                s2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 3 of triangle: ");
                s3 = Convert.ToInt32(Console.ReadLine());


                string TriangleType = TriangleSolution.TriangleAnalyze(s1, s2, s3);
                Console.WriteLine("\n\n The Triangle is {0} Type", TriangleType);
                Console.ReadLine();
            }

            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
