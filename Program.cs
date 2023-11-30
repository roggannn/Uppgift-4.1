using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[]args)
        {
            int tal = 10;
            while (tal != 30)
            {
                tal++;
                Console.WriteLine(tal);
            }
            tal = 201;
            while (tal != 180)
            {
                tal--;
                Console.WriteLine(tal);
            }
            tal = 950;
            while (tal != 1450)
            {
                tal += 50;
                Console.WriteLine(tal);
            }
            Console.ReadKey();
        }
    }
}