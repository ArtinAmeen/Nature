using Nature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Nature
//{
    // 14: if all the animals need a new attribute/method, we will place it in the Animal class, though
    // we would have to update the classes (like overriding the new method in the subclasses of Animal).
    public abstract class Animal
    {        
        public string GetName
        { set; get; }

        public int GetAge
        { set; get; }

        public double GetWeight
        { set; get; }

        public double GetHoursSleeping
        { set; get; }

        public Animal (string name, int age, double weight, double hoursSleeping)
        {
            GetName = name;
            GetAge = age;
            GetWeight = weight;
            GetHoursSleeping = hoursSleeping;
        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return ($"Name: {GetName}\nAge: {GetAge}\nWeight: {GetWeight}\nHours of sleep: {GetHoursSleeping}");
        }
    }

    public class Horse : Animal
    {
        public bool GetIfHorseWearsHorseshoes
        { set; get; }

        public Horse (string name, int age, double weight, double hoursSleeping, bool wearsHorseShoes) :
                 base(name, age, weight, hoursSleeping)
        {
            GetIfHorseWearsHorseshoes = wearsHorseShoes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Neigh neigh");
        }

        public override string Stats()
        {
            return base.Stats() +$"\nThe horse wear horseshoes: {GetIfHorseWearsHorseshoes}";
        }
    }

    public class Dog : Animal
    {
        public string GetRace
        { set; get; }

        public Dog (string name, int age, double weight, double hoursSleeping, string race) :
               base(name, age, weight, hoursSleeping)
        {
            GetRace = race;
        }

        public void LickOwner ()
        {
            Console.WriteLine("*Lick lick*");
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof woof");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nRace: {GetRace}";
        }
    }

    public class Hedgehog : Animal
    {
        public int GetSpikeAmount
        { set; get; }

        public Hedgehog(string name, int age, double weight, double hoursSleeping, int amountOfSpikes) :
                   base(name, age, weight, hoursSleeping)
        {
            GetSpikeAmount = amountOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hog hog");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nNumber of spikes: {GetSpikeAmount}";
        }
    }

    public class Worm : Animal
    {
        public double GetLengthInMM
        { set; get; }

        public Worm(string name, int age, double weight, double hoursSleeping, double lengthInMM) :
               base(name, age, weight, hoursSleeping)
        {
            GetLengthInMM = lengthInMM;
        }

        public override void DoSound()
        {
            Console.WriteLine("Slither slither");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nThe length of the worm in millimetres: {GetLengthInMM}";
        }
    }

    // 13: if we want to give all the birds a new attribute/function, it must be placed in the Bird class, but
    // we will have to "update" the constructor in the Bird class and in every class that inherits from Bird
    // and if we add a method in the Bird class, we will have to override it in its subclasses.
    public class Bird : Animal
    {
        public int GetFeatherAmount
        { set; get; }

        public Bird(string name, int age, double weight, double hoursSleeping, int featherAmount) :
               base(name, age, weight, hoursSleeping)
        {
            GetFeatherAmount = featherAmount;
        }

        public override void DoSound()
        {
            Console.WriteLine("Tweet tweet");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nNumber of feathers: {GetFeatherAmount}";
        }
    }

    public class Wolf : Animal
    {
        public string GetEyeColour
        { set; get; }

        public Wolf(string name, int age, double weight, double hoursSleeping, string eyeColour) :
               base(name, age, weight, hoursSleeping)
        {
            GetEyeColour = eyeColour;
        }

        public override void DoSound()
        {
            Console.WriteLine("Howl howl");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nEye colour: {GetEyeColour}";
        }
    }

    public class Wolfman : Wolf, IPerson
    {
        public bool GetCurrentForm
        { set; get; }

        public Wolfman(string name, int age, double weight, double hoursSleeping, string eyeColour, bool inHumanForm) : 
                  base(name, age, weight, hoursSleeping, eyeColour)

        {
            GetCurrentForm = inHumanForm;
        }

        public void Talk()
        {
            Console.WriteLine("Rawr rawr");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nIn human form currently?: {GetCurrentForm}";
        }
    }
    public class Pelican : Bird
    {
        public double GetBeakLengthInCM
        { set; get; }

        public Pelican(string name, int age, double weight, double hoursSleeping, int featherAmount, double beakLengthInCM) :
                  base(name, age, weight, hoursSleeping, featherAmount)
        {
            GetBeakLengthInCM = beakLengthInCM;
        }

        public override void DoSound()
        {
            Console.WriteLine("Quark quark");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nBeak length in centimetres: {GetBeakLengthInCM}";
        }
    }

    public class Flamingo : Bird
    {
        public bool GetIfFlamingoInWater
        { set; get; }

        public Flamingo(string name, int age, double weight, double hoursSleeping, int featherAmount,  bool inWater) :
                   base(name, age, weight, hoursSleeping, featherAmount)
        {
            GetIfFlamingoInWater = inWater;
        }

        public override void DoSound()
        {
            Console.WriteLine("Quack quack");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nIs the flamingo in water?: {GetIfFlamingoInWater}";
        }
    }

    public class Swan : Bird
    {
        public string GetColour { set; get; }
        public Swan(string name, int age, double weight, double hoursSleeping, int featherAmount, string colour) :
               base(name, age, weight, hoursSleeping, featherAmount)
        {
            GetColour = colour;
        }

        public override void DoSound()
        {
            Console.WriteLine("Quack quack");
        }
        public override string Stats()
        {
            return base.Stats() + $"\nColour: {GetColour}";
        }
    }
//}