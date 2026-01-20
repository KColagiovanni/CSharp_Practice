using System;

class Program
{

    static void Main(string[] args)
    {
        ForLoop();
        Console.WriteLine("-------------------------");
        ForEachLoop();
    }

    static void ForLoop()
    {
        /*
        When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop

        for (statement 1; statement 2; statement 3) 
        {
            // code block to be executed
        }
    
        Statement 1 is executed (one time) before the execution of the code block.
        Statement 2 defines the condition for executing the code block.
        Statement 3 is executed (every time) after the code block has been executed.

        The example below will print the numbers 0 to 4:
        */
        for (int i = 0; i < 5; i++) 
        {
            Console.WriteLine(i);
        }

        // This example will only print even values between 0 and 10:

        for (int i = 0; i <= 10; i = i + 2) 
        {
            Console.WriteLine(i);
        }

        /*
        It is also possible to place a loop inside another loop. This is called a nested loop. The "inner loop" will 
        be executed one time for each iteration of the "outer loop".
        */

        // Outer loop
        for (int i = 1; i <= 3; ++i) 
        {
            Console.WriteLine("Outer: " + i);  // Executes 2 times

            // Inner loop
            for (int j = 1; j <= 3; j++) 
            {
                Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
            }
        }

    }

    static void ForEachLoop()
    {
        /*
        There is also a foreach loop, which is used exclusively to loop through elements in an array (or other data 
        sets):
        foreach (type variableName in arrayName) 
        {
            // code block to be executed
        }
        */

        // The following example outputs all elements in the cars array, using a foreach loop
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string i in cars) 
        {
            Console.WriteLine(i);
        }


    }
}
