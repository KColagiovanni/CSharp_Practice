/*
 You can also create an object of a class and access it in another class. This is often used for better organization 
 of classes (one class(Cars.cs) has all the fields and methods, while the other class(Program.cs) holds the Main() 
 method).

 The "public" keyword is called an access modifier, which specifies that the color variable/field of Car is accessible 
 for other classes as well, such as Program.
*/
class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
  }
}