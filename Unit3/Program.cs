using System;

namespace Unit3
{
    enum DayOfWeek
    {
        Monday = 1,
        Teusday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string name = "Valeria";
             byte age = 20;
             bool pet = true;
             double size = 39.5;

             Console.WriteLine("My name is " + name);
             Console.WriteLine("I'm "+ age+ " years old");
             Console.WriteLine("I have a dog "+ pet);
             Console.WriteLine("I have "+ size+ " size of shoes");

             Console.WriteLine("IntMin = " + int.MinValue);

             Console.WriteLine($"Мой возраст {age}");

             Console.WriteLine("\t Привет, \nмир!"); */

            
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);
            Console.WriteLine("What is your favorite day of the week?");
            DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day of the week is {0}", day);
            Console.WriteLine("Enter your bithday: ");
            var birthday = Console.ReadLine();
            Console.WriteLine("Your birthday: {0}", birthday);



            Console.ReadKey();
        }
    }
}
