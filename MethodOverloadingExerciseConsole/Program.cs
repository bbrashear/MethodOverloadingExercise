using System;

namespace MethodOverloadingExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many dollars are in your pocket?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("How many dollars are in your friend's pocket?");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("True or False: Do you like money?");
            bool isTrue = bool.Parse(Console.ReadLine());
            Console.WriteLine(Add(a, b, isTrue));



        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isTrue)
        {

            if (isTrue)
            {
                int c = a + b;

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
