// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the path to the source file: ");
        string sourcePath = Console.ReadLine();

        Console.Write("Enter the path to the file you want to copy the data to.: ");
        string destinationPath = Console.ReadLine();

        try
        {
            File.Copy(sourcePath, destinationPath); 
            Console.WriteLine("File copied successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Check the path.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("File or path not accessible.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
