using System;

class Program
{

    static void Main(string[] args)
    {
        Basic();
        Age();
    }

    static void Basic()
    {
        // Type your username and press enter
        Console.Write("Enter username: ");

        // Create a string variable and get user input from the keyboard and store it in the variable
        string userName = Console.ReadLine();

        // Print the value of the variable (userName), which will display the input value
        Console.WriteLine("Username is: " + userName);
    }

    static void Age()
    {
        /*
        The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type,
        such as int. User input can be converted to any type explicitly, by using one of the Convert.To methods.
        */
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age); 
    }

}
