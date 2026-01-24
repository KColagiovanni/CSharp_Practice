/*
Private variables can only be accessed within the same class (an outside class has no access to it). However, 
sometimes they need to be accessed and it can be done with properties.

A property is like a combination of a variable and a method, and it has two methods: a get and a set method.

class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}

Example explained
The Name property is associated with the name field. It is a good practice to use the same name for both the property 
and the private field, but with an uppercase first letter.

The get method returns the value of the variable name.

The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.
*/

class Person
{
  public string Name  // property
  { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}