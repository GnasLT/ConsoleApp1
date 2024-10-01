﻿namespace Abstract.NetOptimized;

using static System.Console;
public class Program
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

public interface IContinentFactory
{
    IHerbivore CreateHerbivore();
    ICarnivore CreateCarnivore();
}

public class Africa : IContinentFactory
{
    public IHerbivore CreateHerbivore() => new Wildebeest();

    public ICarnivore CreateCarnivore() => new Lion();
}

public class America : IContinentFactory
{
    public IHerbivore CreateHerbivore() => new Bison();

    public ICarnivore CreateCarnivore() => new Wolf();
}

public interface IHerbivore
{
}

public interface ICarnivore
{
    void Eat(IHerbivore h);
}

public class Wildebeest : IHerbivore
{
}

public class Lion : ICarnivore
{
    public void Eat(IHerbivore h) =>
        WriteLine($"{GetType().Name} eats {h.GetType().Name}");
}


public class Bison : IHerbivore
{
}

public class Wolf : ICarnivore
{
    public void Eat(IHerbivore h) =>
        WriteLine($"{GetType().Name} eats {h.GetType().Name}");
}

public interface IAnimalWorld
{
    void RunFoodChain();
}

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

