using System;
using System.Globalization;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double money = 10D / 3D;

        Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
        Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-IN")));
        Console.WriteLine(money.ToString("C0", CultureInfo.CreateSpecificCulture("en-GB")));
        Console.WriteLine(money.ToString("C1", CultureInfo.CreateSpecificCulture("en-US")));
    }
}