using System;
using System.Collections.Generic;

public class Bug
{
    /*
        You can declare a typed public property, make it read-only,
        and initialize it with a default value all on the same
        line of code in C#. Readonly properties can be set in the
        class' constructors, but not by external code.
    */
    public string Name { get; } = "";
    public string Species { get; } = "";
    public ICollection<string> Predators { get; } = new List<string>();
    public ICollection<string> Prey { get; } = new List<string>();

    // Convert this readonly property to an expression member
    public string FormalName => $"{this.Name} the {this.Species}";


    // Class constructor
    public Bug(string name, string species, List<string> predators, List<string> prey)
    {
        this.Name = name;
        this.Species = species;
        this.Predators = predators;
        this.Prey = prey;
    }

    // Convert this method to an expression member
    public string PreyList() => string.Join(", ", this.Prey);

    // Convert this method to an expression member
    public string PredatorList() => string.Join(", ", this.Predators);

    // Convert this to expression method (hint: use a C# ternary)


    public string Eat(string food)
    {
    return this.Prey.Contains(food) ? $"{this.Name} ate the {food}." : $"{this.Name} is still hungry.";
    }
}

public class Program
{
    public static void Main()
    {
        Bug seth = new Bug("Seth", "Bee", new List<string>(){"Birds", "dogs"}, new List<string>(){"flowers", "assholes"});
        System.Console.WriteLine($"A {seth.Species} named {seth.Name} eats: ");
        string didEat = seth.Eat("flowers");
        System.Console.WriteLine(didEat);

        string didntEat = seth.Eat("Dogs");
        System.Console.WriteLine(didntEat);

        string predatorList = seth.PredatorList();
        System.Console.WriteLine($"{seth.Name} is afraid of: {predatorList}");

        string preyList = seth.PreyList();
        System.Console.WriteLine($"{seth.Name} likes to eat: {preyList}");


    }
}