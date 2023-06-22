using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Directory: ");
        string directory = Console.ReadLine();
        Console.Write("Regular expression: ");
        string regex = Console.ReadLine();

        if (!Directory.Exists(directory))
        {
            Console.WriteLine("Directory does not exist: " + directory);
            return;
        }

        Console.WriteLine("\nMatches:");

        try
        {
            foreach (string file in Directory.GetFiles(directory))
            {
                if (Regex.IsMatch(Path.GetFileName(file), regex))
                {
                    Console.WriteLine(file);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error searching directory: " + ex.Message);
        }
    }
}