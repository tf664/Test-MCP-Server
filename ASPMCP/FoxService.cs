using System;

public static class FoxService
{
    private static readonly string[] Facts = new[]
    {
        "Foxes have whiskers on their legs as well as their faces, helping them to navigate.",
        "A group of foxes is called a skulk or leash.",
        "Foxes can make over 40 different sounds.",
        "The red fox is the most common fox species.",
        "Foxes use the Earth's magnetic field to hunt."
    };

    public static string GetRandomFact()
    {
        var random = new Random();
        return Facts[random.Next(Facts.Length)];
    }

    public static string[] GetAllFacts()
    {
        return Facts;
    }

    public static string GetFactByIndex(int index)
    {
        if (index < 0 || index >= Facts.Length)
            return "Invalid index.";
        return Facts[index];
    }

    public static string GetAsciiArt()
    {
        // Improved ASCII art
        return @"
              /^._
,___,--~~~~--' /'~
`~--~\ )___,)/'
    (/\\_  (/\\_     
        ";
    }
}