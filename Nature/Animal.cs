using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nature
{
    // 14: if all the animals need a new attribute/method, we will place it in the Animal class.
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected double weight;
        protected double hoursSleeping;
        protected bool livesIndoors;

        public string GetName
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        }

        public double GetWeight
        {
            set
            {
                weight = value;
            }

            get
            {
                return weight;
            }
        }

        public int GetAge
        {
            set
            {
                age = value;
            }

            get
            {
                return age;
            }
        }

        public double GetHoursSleeping
        {
            set
            {
                hoursSleeping = value;
            }

            get
            {
                return hoursSleeping;
            }
        }

        public bool GetLivesIndoors
        {
            set
            {
                livesIndoors = value;
            }

            get
            {
                return livesIndoors;
            }
        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight}\nAge: {GetAge}\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}");
        }
    }

    public class Horse : Animal
    {
        protected bool wearsHorseShoes;
        public Horse (string name, int age, double weight, double hoursSleeping, bool livesIndoors, bool wearsHorseShoes)
        {
            GetName = name;
            GetAge = age;
            GetWeight = weight;
            GetHoursSleeping = hoursSleeping;
            GetLivesIndoors = livesIndoors;
            this.wearsHorseShoes = wearsHorseShoes;
        }

        public bool GetWearsHorseShoes
        {
            set
            {
                wearsHorseShoes = value;
            }

            get
            {
                return wearsHorseShoes;
            }
        }

        public override void DoSound()
        {
            Console.WriteLine("Neigh neigh");
        }

        public override string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight} kg\nAge: {GetAge} years\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}\nThe horse wear horseshoes: {GetWearsHorseShoes}");
        }
    }

    public class Dog : Animal
    {
        protected string race;

        public Dog (string name, int age, double weight, double hoursSleeping, bool livesIndoors, string race)
        {
            GetName = name;
            GetAge = age;
            GetWeight = weight;
            GetHoursSleeping = hoursSleeping;
            GetLivesIndoors = livesIndoors;
            this.race = race;
        }

        public string GetRace
        {
            set
            {
                race = value;
            }

            get
            {
                return race;
            }
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof woof");
        }

        public override string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight} kg\nAge: {GetAge} years\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}\nRace: {GetRace}");
        }
    }

    public class Hedgehog : Animal
    {
        protected int amountOfSpikes;

        public Hedgehog(string name, int age, double weight, double hoursSleeping, bool livesIndoors, int amountOfSpikes)
        {
            GetName = name;
            GetAge = age;
            GetWeight = weight;
            GetHoursSleeping = hoursSleeping;
            GetLivesIndoors = livesIndoors;
            this.amountOfSpikes = amountOfSpikes;
        }

        public int GetSpikeAmount
        {
            set
            {
                amountOfSpikes = value;
            }

            get
            {
                return amountOfSpikes;
            }
        }

        public override void DoSound()
        {
            Console.WriteLine("Hog hog");
        }

        public override string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight} kg\nAge: {GetAge} years\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}\nNumber of spikes: {GetSpikeAmount}");
        }
    }

    public class Worm : Animal
    {
        public double lengthInMM;

        public Worm(string name, int age, double weight, double hoursSleeping, bool livesIndoors, double lengthInMM)
        {
            GetName = name;
            GetAge = age;
            GetWeight = weight;
            GetHoursSleeping = hoursSleeping;
            GetLivesIndoors = livesIndoors;
            this.lengthInMM = lengthInMM;
        }

        public double GetLengthInMM
        {
            set
            {
                lengthInMM = value;
            }

            get
            {
                return lengthInMM;
            }
        }


        public override void DoSound()
        {
            Console.WriteLine("Slither slither");
        }

        public override string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight} kg\nAge: {GetAge} years\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}\nThe length of the worm in millimetres: {GetLengthInMM}");
        }
    }

    // 13: if we want to give all the birds a new attribute/method, it must be placed in the Bird
    // class, but we also have to "update" the constructor of every class that inherits from Bird.
    public class Bird : Animal
    {
        protected int featherAmount;
        public int GetFeatherAmount
        {
            set
            {
                featherAmount = value;
            }

            get
            {
                return featherAmount;
            }
        }

        public override void DoSound()
        {
            Console.WriteLine("Tweet tweet");
        }

        public override string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight} kg\nAge: {GetAge} years\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}\nNumber of feathers: {GetFeatherAmount}");
        }
    }

    public class Wolf : Animal
    {
        protected string eyeColour;

        public string GetEyeColour
        {
            set
            {
                eyeColour = value;
            }

            get
            {
                return eyeColour;
            }
        }

        public override void DoSound()
        {
            Console.WriteLine("Howl howl");
        }

        public override string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight} kg\nAge: {GetAge} years\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}\nIs a alpha wolf: {GetEyeColour}");
        }
    }

    public class Wolfman : Wolf, Person
    {
        protected bool inHumanForm;
        public Wolfman(string name, int age, double weight, double hoursSleeping, bool livesIndoors, string eyeColour, bool inHumanForm)
        {
            GetName = name;
            GetAge = age;
            GetWeight = weight;
            GetHoursSleeping = hoursSleeping;
            GetLivesIndoors = livesIndoors;
            GetEyeColour = eyeColour;
            this.inHumanForm = inHumanForm;
        }

        public bool GetCurrentForm
        {
            set
            {
                inHumanForm = value;
            }

            get
            {
                return inHumanForm;
            }
        }

        public void Talk ()
        {
            Console.WriteLine("Rawr rawr");
        }

        public override string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight} kg\nAge: {GetAge} years\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}\nEye colour: {GetEyeColour}\nIn human form currently?: {GetCurrentForm}");
        }
    }
    public class Pelican : Bird
    {
        protected double beakLength;
        public Pelican(string name, int age, double weight, double hoursSleeping, bool livesIndoors, int featherAmount, double beakLength)
        {
            GetName = name;
            GetAge = age;
            GetWeight = weight;
            GetHoursSleeping = hoursSleeping;
            GetLivesIndoors = livesIndoors;
            GetFeatherAmount = featherAmount;
            this.beakLength = beakLength;
        }

        public double GetBeakLengthInCM
        {
            set
            {
                beakLength = value;
            }

            get
            {
                return beakLength;
            }
        }

        public override void DoSound()
        {
            Console.WriteLine("Quark quark");
        }

        public override string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight} kg\nAge: {GetAge} years\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}\nNumber of feathers: {GetFeatherAmount}\nBeak length in centimetres: {GetBeakLengthInCM}");
        }
    }

    public class Flamingo : Bird
    {
        protected bool inWater;
        public Flamingo(string name, int age, double weight, double hoursSleeping, bool livesIndoors, int featherAmount,  bool inWater)
        {
            GetName = name;
            GetAge = age;
            GetWeight = weight;
            GetHoursSleeping = hoursSleeping;
            GetLivesIndoors = livesIndoors;
            GetFeatherAmount = featherAmount;
            this.inWater = inWater;
        }

        public bool GetIfFlamingoInWater
        {
            set
            {
                inWater = value;
            }

            get
            {
                return inWater;
            }
        }

        public override void DoSound()
        {
            Console.WriteLine("Quack quack");
        }

        public override string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight} kg\nAge: {GetAge} years\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}\nNumber of feathers: {GetFeatherAmount}\nIs the flamingo in water?: {GetIfFlamingoInWater}");
        }
    }

    public class Swan : Bird
    {
        protected string colour;
        public Swan(string name, int age, double weight, double hoursSleeping, bool livesIndoors, int featherAmount, string colour)
        {
            GetName = name;
            GetAge = age;
            GetWeight = weight;
            GetHoursSleeping = hoursSleeping;
            GetLivesIndoors = livesIndoors;
            GetFeatherAmount = featherAmount;
            this.colour = colour;
        }

        public string GetColour
        {
            set
            {
                colour = value;
            }

            get
            {
                return colour;
            }
        }

        public override void DoSound()
        {
            Console.WriteLine("Quack quack");
        }
        public override string Stats()
        {
            return ($"Name: {GetName}\nWeight: {GetWeight} kg\nAge: {GetAge} years\nHours of sleep: {GetHoursSleeping}\nLives indoors: {GetLivesIndoors}\nNumber of feathers: {GetFeatherAmount}\nColour: {GetColour}");
        }
    }
}

public interface Person
{
    void Talk();
}