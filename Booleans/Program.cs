/*
Very often, in programming, you will need a data type that can only have one of two values, like:
- YES / NO
- ON / OFF
- TRUE / FALSE
For this, C# has a bool data type, which can take the values true or false.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // A boolean type is declared with the bool keyword and can only take the values true or false.
        bool isCSharpFun = true;
        bool isFishTasty = false;
        Console.WriteLine("true is: " + isCSharpFun);   // Outputs True
        Console.WriteLine("false is: " + isFishTasty);   // Outputs False

        /*
        Boolean expression returns a boolean value: True or False, by comparing values/variables. This is useful to 
        build logic, and find answers.For example, you can use a comparison operator, such as the greater than (>) 
        operator to find out if an expression (or a variable) is true.
        */
        int x = 10;
        int y = 9;
        Console.WriteLine("x(" + x + ") > " + "y(" + y + ") evaluates to: " + (x > y)); // returns True, because 10 is higher than 9
        Console.WriteLine("Or even easier: 10 < 9, evaluates to: " + (10 < 9));  // Or even easier.

        Console.WriteLine("x(" + x + ") == 10 is: " + (x == 10)); // returns True, because the value of x is equal to 10
        Console.WriteLine("10 == 15 is: " + (10 == 15)); // returns False, because 10 is not equal to 15

        // The >= comparison operator is used to find out if the age (25) is greater than OR equal to the voting age limit, which is 18.
        int myAge = 25;
        int votingAge = 18;
        Console.WriteLine(myAge + " >= " + votingAge + " evaluates to: " + (myAge >= votingAge));

        if (myAge >= votingAge) 
        {
            Console.WriteLine("Old enough to vote!");
        } 
        else 
        {
            Console.WriteLine("Not old enough to vote.");
        }
    }
}