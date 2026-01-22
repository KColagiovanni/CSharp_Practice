/*
A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is 
called when an object of a class is created. It can be used to set initial values for fields.

Note that the constructor name must match the class name, and it cannot have a return type (like void or int).
Also note that the constructor is called when the object is created.
All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. 
However, then you are not able to set initial values for fields.
Constructors save time! Take a look at the last example on this page to really understand why.

onstructors can also take parameters, which is used to initialize fields.

The following example adds a string modelName parameter to the constructor. Inside the constructor we set model to 
modelName (model=modelName). When we call the constructor, we pass a parameter to the constructor ("Mustang"), which 
will set the value of model to "Mustang". You can have as many parameters as you want.

Tip: Just like other methods, constructors can be overloaded by using different numbers of parameters.


*/
class Car
{
  public string model;
  public string color;
  public int year;

  // Create a class constructor with multiple parameters
  public Car(string modelName, string modelColor, int modelYear)
  {
    model = modelName;
    color = modelColor;
    year = modelYear;
  }

}