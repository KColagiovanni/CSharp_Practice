/*
An enum is a special "class" that represents a group of constants (unchangeable/read-only variables). To create an 
enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma. Enum is short 
for "enumerations", which means "specifically listed".
*/

class Program
{

    //  You can also have an enum inside a class.
    enum Level
    {
        Low,
        Medium,
        High
    }

    /*
    By default, the first item of an enum has the value 0. The second has the value 1, and so on. To get the integer 
    value from an item, you must explicitly convert the item to an int(line 39). You can also assign your own enum 
    values, and the next items will update their numbers accordingly.
    */
    enum Months
    {
        January,    // 0
        February,   // 1
        March=6,    // 6
        April,      // 7
        May,        // 8
        June,       // 9
        July        // 10
    }

    static void Main(string[] args)
    {
        Level myVar = Level.Medium;
        Console.WriteLine(myVar);


        int myNum = (int) Months.April;
        Console.WriteLine(myNum);

        // Enums are often used in switch statements to check for corresponding values:
        switch(myVar) 
        {
            case Level.Low:
            Console.WriteLine("Low level");
            break;
            case Level.Medium:
            Console.WriteLine("Medium level");
            break;
            case Level.High:
            Console.WriteLine("High level");
            break;
        }
    }
}

/*
Why And When To Use Enums?
Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.
*/