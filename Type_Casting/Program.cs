/*
Type casting is when you assign a value of one data type to another type.

In C#, there are two types of casting:

Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double

Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char
*/
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // Implicit casting
      int myInt = 9;
      double myDouble = myInt;       // Automatic casting: int to double

      Console.WriteLine("Int: " + myInt);      // Outputs 9
      Console.WriteLine("Double(" + myDouble + ") to Int: " + myDouble);   // Outputs 9
      Console.WriteLine("----------------------------------------");

      //Explicit Casting
      double myDouble1 = 9.78;
      int myInt1 = (int) myDouble1;    // Manual casting: double to int

      Console.WriteLine("Double: " + myDouble1);   // Outputs 9.78
      Console.WriteLine("Int(" + myInt1 + ") to Double: " + myInt1);      // Outputs 9
      Console.WriteLine("----------------------------------------");

      // Type Conversion Methods
      int myInt2 = 10;
      double myDouble2 = 5.25;
      bool myBool = true;

      Console.WriteLine("Int(" + myInt2 + ") to string: " + Convert.ToString(myInt2));    // convert int to string
      Console.WriteLine("Int(" + myInt2 + ") to Double: " + Convert.ToDouble(myInt2));    // convert int to double
      Console.WriteLine("Double(" + myDouble2 + ") to Int32: " + Convert.ToInt32(myDouble2));  // convert double to int
      Console.WriteLine("Bool(" + myBool + ") to String: " + Convert.ToString(myBool));   // convert bool to string

    }
  }
}