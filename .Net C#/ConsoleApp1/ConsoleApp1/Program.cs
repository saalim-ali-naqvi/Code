using System;
using System.Globalization;


// C# BASICS
/*
-VARIABLES
-FUNCTIONS
-CONDITIONS
-COLLECTIONS
-LOOPS
-COMMENTS
-ENUMS
-CLASES
-ACCESSORS
-SCOPE
 */
namespace cSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AssalaamAlaikum");

            double money = 10D / 3D;  //3.33333

            //when you get negative values
            Console.WriteLine(money);
            Console.WriteLine(string.Format("10 / 3 = {0:0.00}", money));  // 3.33
            Console.WriteLine(money.ToString("C"));   // print the string format to display the best format
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-IN")));
            Console.WriteLine(money.ToString("C0", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C1", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}