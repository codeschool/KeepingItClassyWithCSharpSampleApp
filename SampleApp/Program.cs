using System;

class Program
{
    static void Main(string[] args)
    {
        //Get band name / create band
        var band = new Band();
        Console.WriteLine("What is the name of your band?");
        band.Name = Console.ReadLine();

        Console.WriteLine("Type 'Add' to add a musician.");
        Console.WriteLine("Type 'Announce' to announce the band.");
        Console.WriteLine("Type 'Quit' to quit the application.");

        var repeat = true;
        while (repeat)
        {
            Console.WriteLine("Add, Announce, or Quit?");
            var action = Console.ReadLine();
            if (action == "Add")
                band.AddMusician();
            else if(action.StartsWith("Add"))
            {
                var arguments = action.Split(' ');
                band.AddMusician(arguments[1], arguments[2]);
            }
            else if (action == "Announce")
                band.Announce();
            else if (action == "Quit")
                repeat = false;
            else
                Console.WriteLine(action + " is not a valid command.");
        }
        Console.Read();
    }
}