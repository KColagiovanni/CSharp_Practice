using System;

class Program
{

    static void Main(string[] args)
    {
        Strings();
        Console.WriteLine("-------------------------");
        Concatenation();
        Console.WriteLine("-------------------------");
        Interpolation();
        Console.WriteLine("-------------------------");
        AccessStrings();
        Console.WriteLine("-------------------------");
        SpecialCharacters();
    }

    static void Strings()
    {
        // Strings are used for storing text. A string variable contains a collection of characters surrounded by double quotes.
        string greeting1 = "Hello";
        string greeting2 = "Nice to meet you!";
        Console.WriteLine(greeting1);
        Console.WriteLine(greeting2);

        /*
        A string in C# is actually an object, which contain properties and methods that can perform certain operations 
        on strings. For example, the length of a string can be found with the Length property.
        */
        string txtLen = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Console.WriteLine("The length of " +  txtLen + " is: " + txtLen.Length);

        /*
        here are many string methods available, for example ToUpper() and ToLower(), which returns a copy of the 
        string converted to uppercase or lowercase.
        */
        string txt = "Hello World";
        Console.WriteLine(txt + " to uppercase is: " + txt.ToUpper());   // Outputs "HELLO WORLD"
        Console.WriteLine(txt + " to lowercase is: " + txt.ToLower());   // Outputs "hello world"

    }

    static void Concatenation()
    {
        // The + operator can be used between strings to combine them. This is called concatenation.
        string firstName1 = "John ";
        string lastName1 = "Doe";
        string name1 = firstName1 + lastName1;
        Console.WriteLine("Concatenation using the + symbol is: " + name1);

        // You can also use the string.Concat() method to concatenate two strings.
        string firstName2 = "John ";
        string lastName2 = "Doe";
        string name2 = string.Concat(firstName2, lastName2);
        Console.WriteLine("Concatenation using the string.concat() methid is: " + name2);

        /* 
        WARNING! C# uses the + operator for both addition and concatenation. Remember: Numbers are added.
        Strings are concatenated.
        */

        // if two numbers are added together, the result will be a number.
        int x1 = 10;
        int y1 = 20;
        int z1 = x1 + y1;  // z will be 30 (an integer/number)
        Console.WriteLine("int(" + x1 + ") + int(" + y1 + ") is: " + z1);

        // If two strings are added together, the result will be a string concatenation
        string x2 = "10";
        string y2 = "20";
        string z2 = x2 + y2;  // z will be 1020 (a string)
        Console.WriteLine("string(" + x2 + ") + string(" + y2 + ") is: " + z2);

    }

    static void Interpolation()
    {
        /*
        Another option of string concatenation, is string interpolation, which substitutes values of variables into 
        placeholders in a string. Note that you do not have to worry about spaces, like with concatenation.
        Also note that you have to use the dollar sign ($) when using the string interpolation method.
        */
        string firstName = "John";
        string lastName = "Doe";
        string name = $"My full name is: {firstName} {lastName}";
        Console.WriteLine("String Concatenation using interpolation is: " + name);

    }

    static void AccessStrings()
    {
        /*
        You can access the characters in a string by referring to its index number inside square brackets []. This 
        example prints the first character in myString
        */
        string myString = "Hello";
        Console.WriteLine(myString + "[0] is: " + myString[0]);  // Outputs "H"

        // This example prints the second character (1) in myString
        Console.WriteLine(myString + "[1] is: " + myString[1]);  // Outputs "e"

        // You can also find the index position of a specific character in a string, by using the IndexOf() method.
        Console.WriteLine("The index of \"" + myString[1] + "\" in \"" + myString + "\" is: " + myString.IndexOf("e"));  // Outputs "1"

        /*
        Another useful method is Substring(), which extracts the characters from a string, starting from the specified 
        character position/index, and returns a new string. This method is often used together with IndexOf() to get 
        the specific character position:
        */
        // Full name
        string name = "John Doe";

        // Location of the letter D
        int charPos = name.IndexOf("D");

        // Get last name
        string lastName = name.Substring(charPos);

        // Print the result
        Console.WriteLine("The last name of \"" + name + "\" is: " + lastName);

    }

    static void SpecialCharacters()
    {
        /*
        Because strings must be written within quotes, C# will misunderstand this string, and generate an error:
            string txt = "We are the so-called "Vikings" from the north."

        The solution to avoid this problem, is to use the backslash escape character.

        The backslash (\) escape character turns special characters into string characters:

        Escape character	Result	Description
        \'	                '	    Single quote
        \"	                "	    Double quote
        \\	                \	    Backslash

        Other useful escape characters in C# are:
        Code	Result
        \n	    New Line
        \t	    Tab
        \b	    Backspace
        */

        // The sequence \"  inserts a double quote in a string.
        string txt1 = "We are the so-called \"Vikings\" from the north.";
        Console.WriteLine(txt1);

        // The sequence \'  inserts a single quote in a string.
        string txt2 = "It\'s alright.";
        Console.WriteLine(txt2);

        // The sequence \\  inserts a single backslash in a string.
        string txt3 = "The character \\ is called backslash.";
        Console.WriteLine(txt3);

    }
}
