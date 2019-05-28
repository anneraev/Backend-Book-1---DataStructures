using System.Collections.Generic;
using System;

namespace lists
{
    class Program
    {
        static void Main()
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastPlanetsList = new List<string>() { "Uranus", "Neptune", "Pluto" };
            planetList.AddRange(lastPlanetsList);
            planetList.Insert(0, "Venus");
            planetList.Insert(1, "Earth");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");
            Console.WriteLine("List of All Planets:");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("List of Terrestrial Planets");
            rockyPlanets.ForEach(planet => Console.WriteLine(planet));

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            Console.WriteLine("Random Numbers List");
            numbers.ForEach(number => Console.WriteLine(number));
            for (int i = 0; i < numbers.Count; i++)
            {
                Boolean numberFound = false;
                numbers.ForEach(number =>
                {
                    if (number == i)
                    {
                        numberFound = true;
                    }
                });
                if (numberFound == true)
                {
                    Console.WriteLine($"List contains the number {i}");
                }
                else
                {
                    Console.WriteLine($"List does not contain the number {i}");
                }
            }
        }
    }
}
