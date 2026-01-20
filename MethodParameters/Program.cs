using System;

class Program
{

    static void Main(string[] args)
    {
        Parameters("Kevin", 42);
        Parameters("Vicky", 38);
        Parameters("Derik", 5);
        Console.WriteLine("-------------------------");
        DefaultParameters("America");
        DefaultParameters("Mexico");
        DefaultParameters();
        DefaultParameters("Brazil");
        Console.WriteLine("-------------------------");
        int z = ReturnValues(5, 3);
        Console.WriteLine(z);
        Console.WriteLine("-------------------------");
        NamedArguments(child3: "John", child1: "Liam", child2: "Liam");
    }

    static void Parameters(string fname, int age)
    {
        /*
        Information can be passed to methods as parameter. Parameters act as variables inside the method. They are 
        specified after the method name, inside the parentheses. You can add as many parameters as you want, just 
        separate them with a comma.
        */
        Console.WriteLine(fname + " is " + age);
    }

    static void DefaultParameters(string country = "Norway")
    {
        /*
        Adefault parameter value cna be used, by using the equals sign (=). If the method is called without an 
        argument, it uses the default value ("Norway"):
        */
        Console.WriteLine(country);
    }

    static int ReturnValues(int x, int y)
    {
        /*
        If there is no return value, the void keyword is used in the method definition, which indicates that the 
        method should not return a value. If the method does return a value, a primitive data type (such as int or 
        double) can be used instead of void, and use the return keyword inside the method:
        */
        return x + y;
    }

    static void NamedArguments(string child1, string child2, string child3)
    {
        /*
        It is also possible to send arguments with the key: value syntax. That way, the order of the arguments does 
        not matter:
        */
        Console.WriteLine("The youngest child is: " + child3);

    }

}
