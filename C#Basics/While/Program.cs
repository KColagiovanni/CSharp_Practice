using System;

class Program
{
    static void Main(string[] args)
    {
        // The while loop loops through a block of code as long as a specified condition is True
        int i = 0;
        while (i < 5) 
        {
            Console.WriteLine(i);
            i++;
        }

        /*
        The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking 
        if the condition is true, then it will repeat the loop as long as the condition is true.
        */
        int y = 0;
        do 
        {
            Console.WriteLine(y);
            y++;
        }
        while (y < 5);

    }
}