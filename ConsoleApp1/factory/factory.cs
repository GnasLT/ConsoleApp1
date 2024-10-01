namespace ConsoleApp1.factory;

using static System.Console;
public class factory
{
    public static void Main()
    {
        var africa = new AnimalWorld<Africa>();
        africa.RunFoodChain();
        var america = new AnimalWorld<America>();
        america.RunFoodChain();
        ReadKey();
    }
}






public interface IHerbivore
{
}


public class Wildebeest : IHerbivore
{
}



public class Bison : IHerbivore
{
}



public interface IAnimalWorld
{
    void RunFoodChain();
}



