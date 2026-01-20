using System;

class Program
{

    static void Main(string[] args)
    {
        ForBreak();
        Console.WriteLine("-------------------------");
        ForContine();
        Console.WriteLine("-------------------------");
        WhileBreak();
        Console.WriteLine("-------------------------");
        WhileContinue();
    }

    static void ForBreak()
    {
        /*
        You have already seen the break statement used in an earlier chapter of this tutorial. It was used to "jump 
        out" of a switch statement. The break statement can also be used to jump out of a loop. This example jumps out 
        of the loop when i is equal to 4:
        */
        for (int i = 0; i < 10; i++) 
        {
            if (i == 4) 
            {
                break;
            }
        Console.WriteLine(i);
        }

    }

    static void ForContine()
    {
        /*
        The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with 
        the next iteration in the loop. This example skips the value of 4:
        */
        for (int i = 0; i < 10; i++) 
        {
            if (i == 4) 
            {
                continue;
            }
        Console.WriteLine(i);
        }

    }

    static void WhileBreak()
    {
        // You can also use break in while a loop:
        int i = 0;
        while (i < 10) 
        {
            Console.WriteLine(i);
            i++;
            if (i == 4) 
            {
                break;
            }
        }
        
    }

    static void WhileContinue()
    {
        // You can also use continue in while a loop:
        int i = 0;
        while (i < 10) 
        {
            if (i == 4) 
            {
                i++;
                continue;
            }
        Console.WriteLine(i);
        i++;
        }

    }

}
