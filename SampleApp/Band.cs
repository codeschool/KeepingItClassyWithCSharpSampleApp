using System;
using System.Collections.Generic;

public class Band
{
    public string Name;
    public List<Musician> Muscians = new List<Musician>();

    public void Announce()
    {
        Console.WriteLine("Welcome " + Name + " to the stage!");

        foreach(var musician in Muscians)
        {
            Console.WriteLine("With " + musician.Name + " on the " + musician.Insturment + ".");
        }
    }

    public void AddMusician()
    {
        var musician = new Musician();
        Console.WriteLine("What is the name of the musician to be added?");
        musician.Name = Console.ReadLine();
        Console.WriteLine("What insturment does " + musician.Name + " play?");
        musician.Insturment = Console.ReadLine();
        Muscians.Add(musician);
    }

    public void AddMusician(string name, string instrument)
    {
        var musician = new Musician();
        musician.Name = name;
        musician.Insturment = instrument;
        Muscians.Add(musician);
        Console.WriteLine(musician.Name + " was added.");
    }
}
