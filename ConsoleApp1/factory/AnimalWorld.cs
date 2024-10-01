using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.factory
{
    public class AnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
    {
        private readonly IHerbivore herbivore;
        private readonly ICarnivore carnivore;

        public AnimalWorld()
        {
            var factory = new T();
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}
