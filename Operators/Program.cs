using System;

class Program
{

    static void Main(string[] args)
    {
        Arithmetic();
        Console.WriteLine("-------------------------");
        Assignment();
        Console.WriteLine("-------------------------");
        Comparison();
        Console.WriteLine("-------------------------");
        Logical();
    }

    static void Arithmetic()
    {
        /*
        Although the + operator is often used to add together two values, it can also be used to add together a
        variable and a value, or a variable and another variable:
        */
        int sum1 = 100 + 50;        // 150 (100 + 50)
        int sum2 = sum1 + 250;      // 400 (150 + 250)
        int sum3 = sum2 + sum2;     // 800 (400 + 400)
        Console.WriteLine("sum1 is: " + sum1);
        Console.WriteLine("sum2 is: " + sum2);
        Console.WriteLine("sum3 is: " + sum3);
    }

    static void Assignment()
    {
        // Assignment operators are used to assign values to variables.
        int x = 10;
        Console.WriteLine("x = 10 is: " + x);
        x += 5;
        Console.WriteLine("x += 5 is: " + x);
    }

    static void Comparison()
    {
        /*
        Comparison operators are used to compare two values (or variables). This is important in programming, because 
        it helps us to find answers and make decisions.
        The return value of a comparison is either True or False. These values are known as Boolean values.
        In the following example, we use the greater than operator (>) to find out if 5 is greater than 3:
        */
        int x = 5;
        int y = 3;
        Console.Write("x > y is: ");
        Console.WriteLine(x > y); // returns True because 5 is greater than 3
    }

    static void Logical()
    {
        /*
        As with comparison operators, you can also test for True or False values with logical operators.
        Logical operators are used to determine the logic between variables or values:
        && --> and
        || --> or
        ! --> not
        */
        int x = 7;
        Console.WriteLine("x is: " + x);

        Console.Write("x < 5 && x < 10 is: ");
        Console.WriteLine(x > 5 &&  x < 10);

        Console.Write("x < 5 || x < 10 is: ");
        Console.WriteLine(x < 5 &&  x < 8);

        Console.Write("!(x < 5 && x < 10) is: ");
        Console.WriteLine(!(x > 5 &&  x < 10));
    }

}
