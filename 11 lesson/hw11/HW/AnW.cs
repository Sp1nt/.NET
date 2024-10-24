using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class AnW
    {
        abstract class Continent
        {
            public abstract void Print();
        }

        abstract class Herbivore
        {
            public int Weight { get; set; }
            public bool Life { get; set; } = true;

            public Herbivore(int weight)
            {
                Weight = weight;
            }
            public abstract void eatGrass();
        }

        abstract class Carnivore
        {
            public int Power { get; set; }

            public Carnivore(int power)
            {
                Power = power;
            }
            public void eatHerb(Herbivore herbivore)
            {
                if (!herbivore.Life)
                {
                    Console.WriteLine($"{herbivore.GetType().Name} is already dead.");
                    return;
                }

                if (Power > herbivore.Weight)
                {
                    Console.WriteLine($"{this.GetType().Name} eats {herbivore.GetType().Name}. (+10 power)");
                    Power += 10;
                    herbivore.Life = false;
                }
                else
                {
                    Console.WriteLine($"{this.GetType().Name} fails to eat {herbivore.GetType().Name}. (-10 power)");
                    Power -= 10;
                }

                Console.WriteLine($"{this.GetType().Name} now has {Power} power.");
            }
        }

        class Africa : Continent
        {
            public override void Print()
            {
                Console.WriteLine("\nContinent: Africa");
            }
        }

        class NorthAmerica : Continent
        {
            public override void Print()
            {
                Console.WriteLine("\nContinent: North America");
            }
        }

        class Australia : Continent
        {
            public override void Print()
            {
                Console.WriteLine("Continent: Australia");
            }
        }

        class Wildebeest : Herbivore
        {
            public Wildebeest() : base(50) { }

            public override void eatGrass()
            {
                Weight += 10;
                Console.WriteLine("Wildebeest is eating grass. Weight increased by 10.");
            }
        }

        class Bison : Herbivore
        {
            public Bison() : base(80) { }

            public override void eatGrass()
            {
                Weight += 10;
                Console.WriteLine("Bison is eating grass. Weight increased by 10.");
            }
        }

        class Kangaroo : Herbivore
        {
            public Kangaroo() : base(40) { }

            public override void eatGrass()
            {
                Weight += 10;
                Console.WriteLine("Kangaroo is eating grass. Weight increased by 10.");
            }
        }

        class Lion : Carnivore
        {
            public Lion() : base(100) { }
        }

        class Wolf : Carnivore
        {
            public Wolf() : base(70) { }
        }

        class AustralianWolf : Carnivore
        {
            public AustralianWolf() : base(60) { }
        }

        abstract class AnimalFactory
        {
            public abstract Continent CreateContinent();
            public abstract Herbivore CreateHerbivore();
            public abstract Carnivore CreateCarnivore();
        }

        class AfricaFactory : AnimalFactory
        {
            public override Continent CreateContinent()
            {
                return new Africa();
            }

            public override Herbivore CreateHerbivore()
            {
                return new Wildebeest();
            }

            public override Carnivore CreateCarnivore()
            {
                return new Lion();
            }
        }

        class NorthAmericaFactory : AnimalFactory
        {
            public override Continent CreateContinent()
            {
                return new NorthAmerica();
            }

            public override Herbivore CreateHerbivore()
            {
                return new Bison();
            }

            public override Carnivore CreateCarnivore()
            {
                return new Wolf();
            }
        }

        class AustraliaFactory : AnimalFactory
        {
            public override Continent CreateContinent()
            {
                return new Australia();
            }

            public override Herbivore CreateHerbivore()
            {
                return new Kangaroo();
            }

            public override Carnivore CreateCarnivore()
            {
                return new AustralianWolf();
            }
        }

        class AnimalWorld
        {
            private Continent continent;
            private Herbivore herbivore;
            private Carnivore carnivore;

            public AnimalWorld(AnimalFactory factory)
            {
                continent = factory.CreateContinent();
                herbivore = factory.CreateHerbivore();
                carnivore = factory.CreateCarnivore();
            }

            public void SimulateLife()
            {
                continent.Print();
                herbivore.eatGrass();
                carnivore.eatHerb(herbivore);
            }

            public void MealsHerbivores()
            {
                herbivore.eatGrass();
            }

            public void NutrCarnivores()
            {
                carnivore.eatHerb(herbivore);
            }
        }

        static void Main(string[] args)
        {

            AnimalFactory africaFactory = new AfricaFactory();
            AnimalFactory northAmericaFactory = new NorthAmericaFactory();
            AnimalFactory australiaFactory = new AustraliaFactory();

            Console.WriteLine("Simulation for Africa:");
            AnimalWorld africaWorld = new AnimalWorld(africaFactory);
            africaWorld.SimulateLife();

            Console.WriteLine("\nSimulation for North America:");
            AnimalWorld northAmericaWorld = new AnimalWorld(northAmericaFactory);
            northAmericaWorld.SimulateLife();

            Console.WriteLine("\nSimulation for Australia:");
            AnimalWorld australiaWorld = new AnimalWorld(australiaFactory);
            australiaWorld.SimulateLife();

            Console.WriteLine("\nAdditional Actions:");
            africaWorld.MealsHerbivores();
            northAmericaWorld.NutrCarnivores();
            australiaWorld.MealsHerbivores();
        }
    }
}
