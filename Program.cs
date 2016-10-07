using System;

namespace Zoolandia.Animals

{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.name = args[0];
            animal.size = args[1];
            animal.habitat = args[2];
            animal.diet = args[3];
            Console.WriteLine($"The {animal.name}, a {animal.size} animal, lives in {animal.habitat} and eats {animal.diet}.");
        }
    }
}
