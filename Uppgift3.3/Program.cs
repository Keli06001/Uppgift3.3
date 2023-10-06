using System;

namespace uppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int timmar=int.Parse(Console.ReadLine());
            int pris = (timmar * 80);
            if (timmar < 2) 
            {
                Console.WriteLine("Du kan inte hyra bilen så kort tid");
            }
            if (pris > 950)
            {
                Console.WriteLine("Det kommer att kosta dig 950kr");
            }
            else 
            {
                Console.WriteLine("Det kommer att kosta dig "+pris+"kr");
            }
            Console.ReadKey();
        }
    }
}