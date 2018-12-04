using System;

namespace nameInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name?");
            var Name = Console.ReadLine();
            Console.WriteLine("\nWhat is your age?");
            var Age = Console.ReadLine();
            Console.WriteLine($"/n Hello,{Name}, Welcome to my game!");
            Console.Write("Press any key to exit ");
            Console.ReadKey(true);


        }
    }
}
