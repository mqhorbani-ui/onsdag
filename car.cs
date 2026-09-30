using System;

public class Car
{
    public string Brand;
    public string Model;
    public int Year;

    public void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
    }
}
