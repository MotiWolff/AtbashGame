using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the atbash Game!");
        string[] lines = GetPath();

        List<string> keywords = new List<string> { "bomb", "nukhba", "fighter", "rocket", "secret" };

        // Waiting for function from the decrypter class 
        string decrypted = "";
        // Waiting for function from the threat analyzer class
        int score = 0;
        // Waiting for function from the severity reporter class
    }

    static string[] GetPath()
    {
        Console.WriteLine("Please enter the file path: ");
        string path = Console.ReadLine()!;

        string[] lines = Array.Empty<string>();

        if (File.Exists(path))
        {
            lines = File.ReadAllLines(path);
        }
        else
        {
            Console.WriteLine("File not found.");
            return GetPath();
        }

        return lines;
    }
}