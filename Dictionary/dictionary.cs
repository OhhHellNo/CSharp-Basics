
/*
 A Dictionary<TKey, TValue> in C# is like a List, but instead of storing just values, it stores key-value pairs.
 If you need to find something quickly by a key, a dictionary is extremely fast (O(1) average).
 Dictionary is not for storing everything — it’s chosen for speed and structure.
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        var f1Cars = new Dictionary<string, string>()
        {
            { "Max Verstappen", "Red Bull RB20" },
            { "Lewis Hamilton", "Mercedes W15" },
            { "Lando Norris", "McLaren MCL60" }
        };


        Console.WriteLine("Verstappen drives: " + f1Cars["Max Verstappen"]);


        Console.WriteLine("\nF1 Driver → Car Map:");
        foreach (var pair in f1Cars)
        {
            Console.WriteLine($"{pair.Key} → {pair.Value}");
        }
    }
}