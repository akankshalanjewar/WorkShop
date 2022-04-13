using System;

namespace HarmonicValue
{
    public class Program
    {
        public static void HarmonicNumber()
        {
            Console.WriteLine("Welcome to Harmonic Number Problem");

            Console.WriteLine("please Enter The Range");
            int range = int.Parse(Console.ReadLine());
            if (range == 0 || range < 0)
            {
                Console.WriteLine("Enter Non-Range range");

            }
            else
            {
                float result = 0;
                int n = range;
                for (float i = 1; i <= range; i++)
                {
                    result = result + 1 / i;

                }
                Console.WriteLine("Harmonic Number Upto the Range" + n + "is" + result);

            }
        }
        static void Main(string[] args)
        {
            Program.HarmonicNumber();
        }


    }
}
