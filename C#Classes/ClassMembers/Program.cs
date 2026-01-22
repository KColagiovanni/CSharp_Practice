/*
Variables inside a class are called fields, they can be accessed by creating an object of the class, and by using the 
dot syntax (.).
The fields can be left blank, and modified when creating the object. This is especially useful when creating multiple 
objects of one class.
Just like with fields, you can access methods with the dot syntax. However, note that the method must be public. 
Remember that we use the name of the method followed by two parentheses () and a semicolon ; to call (execute) the 
method.
Why did we declare the method as public, and not static. The reason is simple, a static method can be accessed without 
creating an object of the class, while public methods can only be accessed by objects.
*/
class Program
{
  static void Main(string[] args)
  {
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.Write("A " + Ford.color + " " + Ford.year + " " + Ford.model + ". ");
    Ford.fullThrottle();
    Console.Write("A " + Opel.color + " " + Opel.year + " " + Opel.model + ". ");
    Opel.fullThrottle();
  }
}