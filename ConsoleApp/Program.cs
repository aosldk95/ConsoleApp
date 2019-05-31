using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal fox = new Animal("fox", "Raaw");
            fox.MakeSound();

            Animal dog = new Animal("dog", "wal");
            dog.MakeSound();

            Animal cow = new Animal("cow", "ema");
            cow.MakeSound();
            Console.ReadLine();
        }
    }
}
