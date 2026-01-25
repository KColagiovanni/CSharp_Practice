/*
Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
Inheritance lets the user inherit fields and methods from another class. Polymorphism uses those methods to perform 
different tasks. This allows us to perform a single action in different ways.

For example, think of a base class called Animal that has a method called animalSound(). Derived classes of Animals 
could be Pigs, Cats, Dogs, Birds - And they also have their own implementation of an animal sound (the pig oinks, and 
the cat meows, etc.)

C# provides an option to override the base class method, by adding the virtual keyword to the method inside the base 
class, and by using the override keyword for each derived class methods:
*/

class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: oink oink");
  }
}

class Cat : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The cat says: meow meow");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myCat = new Cat();  // Create a Cat object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myCat.animalSound();
    myDog.animalSound();
  }
}