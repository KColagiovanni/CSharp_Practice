/*
The public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.

C# has the following access modifiers:

Modifier	Description
public	The code is accessible for all classes
private	The code is only accessible within the same class
protected	The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
internal	The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
There's also two combinations: protected internal and private protected.

If you declare a field with a private access modifier, it can only be accessed within the same class:
*/

class Program
{
  static void Main(string[] args)
  {
    CarPrivate myObj = new CarPrivate();
    Console.WriteLine(myObj.model);
 
    CarPublic myObj = new CarPublic();
    Console.WriteLine(myObj.model);
  }
}