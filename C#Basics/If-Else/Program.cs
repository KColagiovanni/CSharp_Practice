using System;

class Program
{

    static void Main(string[] args)
    {
        If();
        Console.WriteLine("-------------------------");
        Else();
        Console.WriteLine("-------------------------");
        IfElse();
        Console.WriteLine("-------------------------");
        ShortHandIfElse();
    }

    static void If()
    {
        /*
        C# has the following conditional statements:

        Use if to specify a block of code to be executed, if a specified condition is true
        Use else to specify a block of code to be executed, if the same condition is false
        Use else if to specify a new condition to test, if the first condition is false
        Use switch to specify many alternative blocks of code to be executed
        */
        if (20 > 18) 
        {
            Console.WriteLine("20 is greater than 18");
        }

        int x = 20;
        int y = 18;
        if (x > y) 
        {
            Console.WriteLine("x(" + x + ") is greater than y(" + y + ")");
        }

    }

    static void Else()
    {
        // Use the else statement to specify a block of code to be executed if the condition is False.
        int time = 16;
        if (time < 18) 
        {
            Console.WriteLine("Good day.");
        } 
        else 
        {
            Console.WriteLine("Good evening.");
        }
        // Outputs "Good evening."

    }

    static void IfElse()
    {
        // Use the else if statement to specify a new condition if the first condition is False.
        int time = 8;
        if (time < 10) 
        {
            Console.WriteLine("Good morning.");
        } 
        else if (time < 20) 
        {
            Console.WriteLine("Good day.");
        } 
        else 
        {
            Console.WriteLine("Good evening.");
        }
        // Outputs "Good evening."

    }

    static void ShortHandIfElse()
    {
        /* here is also a short-hand if else, which is known as the ternary operator because it consists of three 
        operands. It can be used to replace multiple lines of code with a single line. It is often used to replace 
        simple if else statements
        */
        int time = 20;
        string result = (time < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);

    }
}
