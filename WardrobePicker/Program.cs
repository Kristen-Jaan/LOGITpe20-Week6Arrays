using System;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            string[] wardrobe = { "hat", "hoodie", "jeans", "dress", "shirt" };
            string[] colors = { "red", "blue", "white", "green", "pink" };
            string[] patterns = { "flowery", "striped", "polka dot", "circles", "checkered"};
            Random rnd = new Random();
            Console.WriteLine("Would you like me to help you to pick clothes?");
            string userinput = Console.ReadLine();
            if(userinput == "no")
            {
                Console.WriteLine("Farewell, meanie");
                
            }
            else
            {
                Console.WriteLine($"Today you should wear " +
                    $"{colors[rnd.Next(0, colors.Length)]} " +
                    $"{patterns[rnd.Next(0, patterns.Length)]} " +
                    $"{wardrobe[rnd.Next(0, colors.Length)]} ");
                    
            }
           
            
               
            


        }
    }
}
