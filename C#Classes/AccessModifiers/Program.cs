/*
The public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, 
methods and properties.

C# has the following access modifiers:

Modifier	Description
public:	    - The code is accessible for all classes.
private:	- The code is only accessible within the same class.
protected:	- The code is accessible within the same class, or in a class that is inherited from that class.
internal:	- The code is only accessible within its own assembly, but not from another assembly.
**There's also two combinations: protected internal and private protected.

If you declare a field with a private access modifier, it can only be accessed within the same class.

Why Access Modifiers?
To control the visibility of class members (the security level of each individual class and class member).
To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users. This is 
done by declaring fields as private.
**Note: By default, all members of a class are private if you don't specify an access modifier.
*/

class Program
{
  static void Main(string[] args)
  {
    CarPublic myObj = new CarPublic();
    Console.WriteLine(myObj.model);

    // CarPrivate myObj = new CarPrivate();  // Throws and error.
    // Console.WriteLine(myObj.model); 
  }
}