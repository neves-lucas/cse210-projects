using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    public string ToFileString()
    {
        return $"{Date}~|~{Prompt}~|~{Response}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("~|~");
        
        Entry entry = new Entry();
        entry.Date = parts[0];
        entry.Prompt = parts[1];
        entry.Response = parts[2];
        
        return entry;
    }
}
