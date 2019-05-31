using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Animal
    {
        static int legCount;

        public string mName;
        public string mSound;

        public Animal(string name, string sound)
        {
            mName = name;
            mSound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", mName, mSound);
        }

    }
}
