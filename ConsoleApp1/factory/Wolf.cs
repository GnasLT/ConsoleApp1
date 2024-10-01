using static System.Console;

namespace ConsoleApp1.factory
{
    public class Wolf : ICarnivore
    {
        public void Eat(IHerbivore h) =>
            WriteLine($"{GetType().Name} eats {h.GetType().Name}");
    }
}
