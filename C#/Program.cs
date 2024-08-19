// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;   // for different currency conversion

//Hello World
/*namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}*/

//Use of Main Method
/*
The Main method is used as the entry point of a C# program.
1. Program Entry Point-
2. Structured Program Initialization- 
    The Main method is responsible for initializing the application.
    This could involve setting up variables, initializing data structures, creating objects, or starting services.
    It's the place where the program's workflow is set up before it moves into more complex operations.
3. Command-Line Interface
    As mentioned earlier, the Main method can accept command-line arguments via the string[] args parameter.
    This allows the program to receive input directly from the command line, making it flexible and adaptable to different scenarios without changing the code.
4. Return Status-
    If you use a Main method that returns an int, it can provide an exit code to the operating system when the program finishes.
5. Standard Convention-
6. Flexibility
*/


//Command-Line-Arguments(Strings[] args)
// Why we use (Strings[] args)?
// 1- static void Main() - No command-line arguments.
// 2- static int Main(string[] args) - Returns an integer (typically used as an exit code).
// 3- static void Main(string[] args) - No return value (typically used for console).
/*namespace CommandLineArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of arguments: " + args.Length);
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
            //OutPut--
            //Number of arguments: 3
            //one
            //two
            //three
            
        }

    }
}*/


//Debug.Log For Unity in MonoBeheavier vs Console.WriteLine for .NET C#


//Numeric Data Types
/*
1. Integers

Type   SIZE      Range
byte    8       0 to 255
sbyte   8       -128 to 127
short   16      -32,768 to 32,767
ushort  16      0 to 65,535
int     32      -2,147,483,648 to 2,147,483
int     32      -2,147,483,648 to 2,147,483
uint    32      0 to 4,294,967,295
long    64      -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
ulong   64      0 to 18,446,744,073,709,551

Difference between signed and unsigned?

>short is signed, allowing it to represent both negative and positive values.
>ushort is unsigned, meaning it can only represent non-negative values.

>Use int when your application needs to handle both negative and positive numbers.
>Use uint when you only need to handle non-negative numbers and require a larger positive range.

>Use byte when you need a small, non-negative integer, such as for binary data or color components.
>Use sbyte when you need a small integer that can be either positive or negative.

2. Floating-Point Types

Type   SIZE      Range
float   32     1.4E-45 to 3.4E+38
double  64     4.9E-324 to 1.8E+308
decimal 128    1.0E-28 to 7.9E+28

3. Special Types

Type   SIZE      Range
char    16      
bool    1      True or False

*/

/*namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 15;
            //int z = x + y;

            //int x = 10,
            //    y = 15,
            //    z = 20;
            
            //int x, y, z;

            
            
            int age = 24;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = 100;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.ReadLine();
        }
    }
}*/

//Text Based DataType
//int, long, float, double, decimal, bool, char, string

//Console.WriteLine(); for next line && Console.Write(); for without next line

/*namespace TextBasedDataTypes
{
    internal class Program
    {
        static void Main(String[] args)
        {
            string names = "Ali";
            char letters = 'a';

            Console.Write("Your Name ");
            Console.Write(names);
            Console.WriteLine();
            Console.Write(letters);

        }
    }
}*/


//Convert String to number
/*namespace ConvertStringToNumber
{
    internal class Program
    {
        static void Main(String[] args)
        {
            string textAge = "-21";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age); 
        }
    }
}*/

// Bool DataType
/*namespace boolDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool value = true;

            bool isMale = true;
            Console.WriteLine(isMale);

            isMale = false;
            Console.WriteLine(isMale);

        }
    }
}*/



//operators
/*namespace Operators
{
    internal class Program
    {
        static void Main(String[] args)
        {
            float age = 21;

            //age += 1;
            //age *= 10;
            //age -= 1;
            age /= 10;
            //age = age + 1;
            Console.WriteLine(age);
            
            //age++;
            //Console.WriteLine(age);
            //age--;
            //Console.WriteLine(age);

            //string name = "Ali";
            //name += " is Programming";  // Giving a space between a letters before
            //Console.WriteLine(name);

            char ch = 'a';
            ch +=  'b';
            Console.WriteLine(ch);

            int i = 0;
            //i++;     // prefix and postfix ++i && i++
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(++i);
        }
    }
}*/

//Remainder(%)
/*namespace Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secoundNumber = 3;

            //10 / 3 = 3r1
            //3x3 = 9, 1 left over to get 10

            Console.WriteLine(firstNumber / secoundNumber);
            Console.WriteLine(firstNumber % secoundNumber);

            Console.WriteLine(1000%90);
            Console.WriteLine(100 % 90);
            Console.WriteLine(71 % 10);
        }
    }
}*/

//Var Keywords
/*namespace varKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = 21;
            Console.WriteLine(age);

            var bigNumber = 90000L;
            Console.WriteLine(bigNumber);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.0000001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            Console.WriteLine(money);

            var name = "Ali";
            Console.WriteLine(name);

            var letter = 'a';
            Console.WriteLine(letter);
        }
    }
}*/


//Constant Keyword
/*namespace constantKeyword
{
    internal class Program
    {
        static void Main(String[] args)
        {
            const int vat = 20;
            const double percentVAT = vat / 100D;
            int balance = 1000;

            Console.WriteLine(balance * (vat / 100D));
            Console.WriteLine(balance * percentVAT);

            const string version = "v1.0";

            Console.WriteLine(vat);
        }
    }
}*/


// EXERCISE - Sorting User data
/*
>Define Variable to hold your name
>Define Variable to hold your Phone number
>Define Variable to hold your age
>Print varialbe line-by-line to the screen
>Extra- define varialbe using the var keyword
*/

/*namespace SortingUserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Ali";
            //string number = "07607868151";
            //byte age = 21;

            //define varialbe using the var keyword
            var name = "Ali";
            var number = "07607868151";
            var age = 21;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);
        }
    }
}*/

// EXERCISE - Odd/Even Checker
/*
>Create & initialize two ints
>make a variable to work our of two remainder
>Output remainder to the screen
>change the first int variable to another number
    > and recalculate the remainder
    > output new remainder to the screen
*/

/*namespace evenOddChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;
            Console.WriteLine(remainder);

            num1 = 11;
            remainder = num1 % num2;
            Console.WriteLine(remainder);
        }
    }
}*/

//Console Input/Output
/*namespace consoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assalamalikum, Welcome to the Black HUD Corporation");

            Console.Write("Enter your name: ");     //Remove Line from WriteLine because of printing same line, Do need to terminate the end of a line or nextline
            // First method
            //string name;
            //name = Console.ReadLine();

            //Secound Method
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Emter your age: ");
            //string age = Console.ReadLine();
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            //Console.WriteLine(age);

            //Intoduce to a Notation called string concatenation
            //Console.Write("Your name is ");
            //Console.Write(name);
            //Console.Write(" and your age is ");
            //Console.Write(age);

            //better method of writing string concatenation
            Console.WriteLine("Your name is " + name + " and your age is " + age);

            Console.ReadLine();
        }
    }
}*/

// If Statement

/*namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //string ageInput = Console.ReadLine();
            //int age = Convert.ToInt32(ageInput);

            //Console.WriteLine();
            //Console.WriteLine("Your name is " + name + " and your age is " + age);

            // ==(Equal to)
            //>(Greather than)
            //>=(Greather than Equals to)
            //<(Less than)
            //<=(Less than equal to)
            //!=(not equals t0)
            //  ||(or)
            //  &&(and)

            //on Console(Terminal), On the O/P If you give space after the age digit you will not get "You are 18"
            //to overcome this use #2 if Statement for age Convert.ToInt32(ageInput)

            /*if (ageInput == "18")
            {
                Console.WriteLine("You are 18");
            }*/

            /*if (age >= 18 && age <= 25)  // use and to give statement of between two statement
            {
                Console.WriteLine("You are Between 18 and 25");
            }
            else if (age >= 25)
            {
                Console.WriteLine("You are 25 or older");
            }*/

            /*if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid Age");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are Between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 26 or older");
                }
                Console.WriteLine("Valid Age");
            }*/
            /*Console.Write("Enter the first Number: ");
            string numberInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberInput);

            Console.Write("Enter the secound Number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + "X" + numberB + ": " );
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if (actualAnswer == answer)
            {
                Console.WriteLine("Well done!");
            }
            else if (actualAnswer != answer)
            {
                Console.WriteLine("Close but it was a wrong answer");
            }
        }
    }
}*/

// Switch Statement
/*namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            // comparing if Statement with switch statment
            if (day == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            

            switch (day)
            {
                case 1: Console.WriteLine("Monday");
                break;
                case 2: Console.WriteLine("Tuesday");
                break;
                case 3: Console.WriteLine("Wednesday");
                break;
                case 4: Console.WriteLine("Thursday");
                break;
                case 5: Console.WriteLine("Friday");
                break;
                case 6: Console.WriteLine("Saturday");
                break;
                case 7: Console.WriteLine("Sunday");
                break;
                default: Console.WriteLine("Invalid, Enter the value between 1 and 7");
                break;
            }


            Console.ReadLine();
        }
    }
}*/


// For Loop
/*namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();

            Console.Write("And how many time do you want to repeat?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());
            

            if (loopCounter <= 0)
            {
                Console.WriteLine("Invalid, Enter the value greater than 0");
            }
            else
            {
                for(int i = 0; i < loopCounter; i++) // for i++ alternatively i = i+1; or i += 1;
                {
                    Console.WriteLine(message);
                    Console.WriteLine("Walekum Assalaam");
                }
            }

            
            // print a 5 times hii
            for(int i = 0; i < loopCounter; i++) // for i++ alternatively i = i+1; or i += 1;
            {
                Console.WriteLine("Hii");
            }


            Console.Write("Upto What number have Odd Number?: ");
            int evenLoopCounter = Convert.ToInt32(Console.ReadLine());
            // Print the even number between 0 and 10
            for (int i = 0; i <= evenLoopCounter; i += 2)
            {
                Console.WriteLine(i);
            }


            Console.Write("Upto What number have Odd Number?: ");
            int oddLoopCounter = Convert.ToInt32(Console.ReadLine());
            // Print the Odd numbers between 0 and 10
            for (int i = 1; i <= oddLoopCounter; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}*/

// While Loops
/*namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first  number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            Console.WriteLine();

            int answer  = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("Whats the value of " + numberA + "x" + numberB + "?");
            Console.WriteLine();

            while (answer != actualAnswer)                               // While loop
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (actualAnswer != answer)
                {
                    Console.WriteLine("Close but it was wrong");
                    Console.WriteLine();
                }
            }

            do                                                          // do While loop execute first then check the condition is to be true or not
            {
                //
            } while (answer != actualAnswer);

            Console.WriteLine("Well done, Khuda hafiz");
            Console.ReadLine();
        }
    }
}*/

// Conditional operator(?)
/*namespace conditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Without Conditional Operator
            int age = 10;

            if (age >= 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            // With Conditional Operator

            // condition ? true : false

            string result = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}*/

//Numeric formatting
/*namespace numericFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
                  //(string.Format({0} , {1} , value , 1000))
                                                                             //                |     |
                            // under format(), Inside the speach marks"", type patern {} {}, inside the patern give position number 0 ,1 then then assign numbers to the value respectively.
            
            //look better formatting in decimal
            Console.WriteLine(string.Format("{0:0}", value));   // {0:0.00} gives O/P -> 8.04
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));

            double money = 10D / 3D;  //3.33333

            //when you get negative values
            Console.WriteLine(money);
            Console.WriteLine(string.Format("10 / 3 = {0:0.00}", money));  // 3.33
            Console.WriteLine(money.ToString("C"));   // print the string format to display the best format
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            //curency symbol using the System.Globalization
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-IN")));
            Console.WriteLine(money.ToString("C0", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C1", CultureInfo.CreateSpecificCulture("en-US")));

            Console.ReadLine();
        }
    }
}*/

// TryParse Function
/*namespace tryParseFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = true;

            while(success)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();   //10h
                //int num = Convert.ToInt32(numInput);
                //int num = 0;

                //bool success = int.TryParse(numInput, out num);//false  // this is use for if the user type 10p instaed of 10 then will will back "out num" will be executed, To print num value.

                
                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert");
                }
            }
        }
    }
}*/

// EXERCISE: times table
namespace excerciseTimeTable
{
    class Program
    {
        /*
        1. Ask the user for a number for the table
        2. Write a for loop to print X times table
        */
        static void Main(string[] agrs)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            }
        }
    }
}











