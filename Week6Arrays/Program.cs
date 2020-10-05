using System;

namespace Week6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            string[] predictions = { "will win a million", "lose your smartphone", "fall in love", "buy youtube premium", "join the dark side" };
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, predictions.Length);
            Console.WriteLine($"Today you will {predictions[RandomIndex]}");
        }
    }
}
