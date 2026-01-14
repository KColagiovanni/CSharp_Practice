using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // Standard Variables
      int myNum = 5;  // Integer: (4 bytes) Stores whole numbers from -2,147,483,648 to 2,147,483,647.
      double myDoubleNum = 5.99D;  // Floating point number: (8 bytes) Stores fractional numbers. Sufficient for storing 15 decimal digits.
      char myLetter = 'D';  // Character: (2 bytes) Stores a single character/letter, surrounded by single quotes.
      bool myBool = true;  // Boolean: (1 byte) Stores true or false values.
      string myText = "Hello";  // String: (2 bytes per character) Stores a sequence of characters, surrounded by double quotes
      
      Console.WriteLine(myNum);
      Console.WriteLine(myDoubleNum);
      Console.WriteLine(myLetter);
      Console.WriteLine(myBool);
      Console.WriteLine(myText);

      // Constants. This will declare the variable as "constant", which means unchangeable and read-only.
      const int constVar = 15;
      //constVar = 20;  // Throws error: error CS0131
      Console.WriteLine("Constant Varible: " + constVar);


      // Display Variables
      string name = "John";
      Console.WriteLine("Hello " + name);

      string firstName = "John ";
      string lastName = "Smith";
      string fullName = firstName + lastName;
      Console.WriteLine(fullName);

      int x = 5;
      int y = 6;
      Console.WriteLine(x + y);  // Print the value of x + y

      // Multiple Variables
      int a = 5, b = 6, c = 50;
      Console.WriteLine(a + b + c);

      int d, e, f;
      d = e = f = 50;
      Console.WriteLine(d + e + f);

    }
  }
}