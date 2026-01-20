/*
With method overloading, multiple methods can have the same name with different parameters. Instead of defining two 
methods that should do the same thing, it is better to overload one. In the example below, we overload the PlusMethod 
method to work for both int and double:
*/

using System;

class Program
    {
    
    static int PlusMethod(int x, int y)
    {
        return x + y;
    }

    static double PlusMethod(double x, double y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        int myNum1 = PlusMethod(8, 5);
        double myNum2 = PlusMethod(4.3, 6.26);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Double: " + myNum2);
    }
}