using System;

class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo di = new DirectoryInfo(@"D:\Demo\C#");
        Console.WriteLine("Search pattern demo* returns:");
        foreach (var fi in di.GetDirectories("demo*"))
        {
            Console.WriteLine(fi.Name);
        }
        Console.WriteLine();
        Console.WriteLine("Search pattern TopDirectoryOnly returns:");
        foreach (var fi in di.GetFiles("*cs", SearchOption.TopDirectoryOnly))
        {
            Console.WriteLine(fi.Name);
        }
        Console.ReadLine();
    }
}