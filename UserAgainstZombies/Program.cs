using System;

namespace UserAgainstZombies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            
            string[] userbag = new string[5];
            int i = 0;
            while(i < userbag.Length)
            {
                Console.WriteLine("What's there is OUR bag?");
                userbag[i] = Console.ReadLine();
                i++;
            }
            Random rnd = new Random();
            Console.WriteLine($"In case of zombie apocalypse you will have to " + $"fight zombies off with a {userbag[rnd.Next(0, userbag.Length)]}");
        }
    }
}
