/*
A method is a block of code which only runs when it is called.
You can pass data, known as parameters, into a method.
Methods are used to perform certain actions, and they are also known as functions.
Why use methods? To reuse code: define the code once, and use it many times.
*/

using System;

class Program
{

    /*
    A method is defined with the name of the method, followed by parentheses (). C# provides some pre-defined methods, 
    which you already are familiar with, such as Main(), but you can also create your own methods to perform certain 
    actions:
    */
    static void MyMethod() 
    {
        /*
        - MyMethod() is the name of the method.
        - static means that the method belongs to the Program class and not an object of the Program class.
        - void means that this method does not have a return value.
        */
        Console.WriteLine("I just got executed!");
    }

    static void Main(string[] args)
    {
        /*
        To call (execute) a method, write the method's name followed by two parentheses () and a semicolon; In the 
        following example, MyMethod() is used to print a text (the action), when it is called:
        */
        MyMethod();

        // A method can be called multiple times:
        MyMethod();
        MyMethod();
        MyMethod();

    }

    // Outputs "I just got executed!"
}