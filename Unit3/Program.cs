using System;

namespace Unit3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Valeria";
            byte age = 20;
            bool pet = true;
            double size = 39.5;

            Console.WriteLine("My name is " + name);
            Console.WriteLine("I'm "+ age+ " years old");
            Console.WriteLine("I have a dog "+ pet);
            Console.WriteLine("I have "+ size+ " size of shoes");


            Console.ReadKey();
        }
    }
}
