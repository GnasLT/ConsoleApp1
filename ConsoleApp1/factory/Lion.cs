using static System.Console;


namespace ConsoleApp1.factory
{
    public class Lion : ICarnivore
    {
        public void Eat(IHerbivore h) =>
            WriteLine($"{GetType().Name} eats {h.GetType().Name}");
    }

}
