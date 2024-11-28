using System;


internal class Program
{
    private static string word = "world";
    private static string Word(string word)
    {
        return word;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine($"Hello {Word(word)}");
    }
}
