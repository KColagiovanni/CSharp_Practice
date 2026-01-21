/*
Everything in C# is associated with classes and objects, along with its attributes and methods. For example: in real 
x`life, a car is an object. The car has attributes, such as weight and color, and methods, such as drive and brake.

A Class is like an object constructor, or a "blueprint" for creating objects.

When a variable is declared directly in a class, it is often referred to as a field (or attribute).

It is not required, but it is a good practice to start with an uppercase first letter when naming classes. Also, it is 
common that the name of the C# file and the class matches, as it makes our code organized. However it is not required 
(like in Java).

An object is created from a class. We have already created the class named Car, so now we can use this to create 
objects.

To create an object of Car, specify the class name, followed by the object name, and use the keyword new:
*/
class Car 
{
    string color = "red";

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
    }
}