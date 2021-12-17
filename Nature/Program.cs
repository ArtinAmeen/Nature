using System;
using System.Collections.Generic;
using System.Text;

namespace Nature
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("SpongeBob SquarePants");
            Console.WriteLine();

            // 3.3-10: we can only place the animals we've created in the same list if the list
            // is of the Animal type
            var Animals = new List<Animal>
            {
                // new Horse ("Hasse", 8, 450, 3, true),
                new Dog ("Emma", 5, 25, 12, "Golden retriever"),
                new Hedgehog ("Harry", 3, 0.8, 9, 5000),
                new Worm ("Slimy", 2, 0.001, 3, 50),
                new Bird ("Carry", 4, 0.02, 8, 1700),
                new Wolf ("Greg", 6, 75, 4.5, "Yellow"),
                new Wolfman ("Vanja", 24, 70, 7.5, "Lime", true),
                new Pelican ("Pelle", 22, 9.6, 3.7, 8000, 33.3),
                new Flamingo ("Fanny", 32, 3.9, 5, 3000, false),
                new Swan ("Sam", 2, 10.6, 8, 6500, "White")
            };

            foreach (var a in Animals)
            {
                object o = a;
                Console.Write($"The {a.GetType()} says: ");
                a.DoSound();

                if (a is IPerson)
                {
                    var b = (IPerson) a;
                    Console.Write($"{b.GetType()} also says: ");
                    b.Talk();

                }
            }

            // 3.3-9: we cannot place a horse in a list with dogs because they are not objects of the same
            // class. The fact that they do not have exacly the same arguments does not matter too much,
            // you would still not be able to place an object of the class Horse in this list.
            var Dogs = new List<Dog>
            {
                new Dog ("Bella", 5, 26.5, 12.5, "Labrador"),
                new Dog ("Diego", 3, 2, 15, "Chihuahua"),
                new Dog ("Charlene", 4, 9.2, 12, "Beagle"),
                //new Horse ("Marley", 9, 440, 3, true)
            };

            Console.WriteLine();


            // in this foreach loop, we want to output the stats of every animal in our Animals list. But
            // since Stats() returns a string, I've decided to store it in a string that I will output at
            // the end of the loop.

            // below the string in question, with WriteLine, I decided to output an introduction of every
            // animal in the list. I got their names using GetName (which is available in every subclass
            // to Animal) and what animals they are via the GetType() method.
            foreach (var a in Animals)
            {
                string stats = a.Stats();
                string animalName = Convert.ToString(a.GetType());
                string animalNameLC = animalName.ToLower();
                Console.WriteLine($"Stats of {a.GetName}, the {animalNameLC}:");
                Console.WriteLine(stats);
            }

            foreach (var a in Animals)
            {

            }
        }
    }
}