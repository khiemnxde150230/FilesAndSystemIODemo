using System;

class Program
{
    static void Main(string[] args)
    {
        String FileName = @"MyFile.txt";
        Console.WriteLine("****Demo FileInfo Class****\n");
        File.WriteAllText(FileName, "Hello World.");
        Console.WriteLine("Read file:");
        string content = File.ReadAllText(FileName);
        Console.WriteLine(content);
        Console.WriteLine("File information:");
        FileInfo testFile = new FileInfo(FileName);
        Console.WriteLine($"Name:{testFile.Name}");
        Console.WriteLine($"Creation time:{testFile.CreationTime}");
        Console.WriteLine($"Last time write:{testFile.LastWriteTime}");
        Console.WriteLine($"Directory name:{testFile.DirectoryName}");
        Console.ReadLine();
    }
}