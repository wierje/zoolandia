using System;

namespace Zoolandia.Animals

{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.name = args[0]; // set { }
            Console.WriteLine(animal.name);

        }
    }

}
