using System;

public class TrianglePrinter
{
    public static void PrintTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the height of the triangle: ");
        int height = int.Parse(Console.ReadLine());

        PrintTriangle(height);
    }
}
