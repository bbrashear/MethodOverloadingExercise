using System;

namespace MethodOverloadingExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number to add");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to add");
            int b = int.Parse(Console.ReadLine());

            
            Console.WriteLine("How many dollars are in your pocket?");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("How many dollars are in your friend's pocket?");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("True or False: Do you like money?");
            bool isTrue = bool.Parse(Console.ReadLine());
            Console.WriteLine(Add(x, y, isTrue));



        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int x, int y, bool isTrue)
        {

            if (isTrue)
            {
                int c = x + y;

                if (c == 1)
                {
                    return $"{c} dollar";
                }
                else
                {
                    return $"{c} dollars";
                }
            }
            else
            {
                return "I guess you don't like money";
            }


        }
    }
}
