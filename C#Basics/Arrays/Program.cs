using System;

class Program
{

    static void Main(string[] args)
    {
        Arrays();
        Console.WriteLine("-------------------------");
        LoopThroughAnArray();
        Console.WriteLine("-------------------------");
        SortArrays();
        Console.WriteLine("-------------------------");
        MultidimentionalArrays();
    }

    static void Arrays()
    {
        // To declare an array, define the variable type with square brackets:
        // string[] cars;  //  Commented out because its defined again below.

        /*
        To insert values to it, we can use an array literal - place the values in a comma-separated list, inside curly 
        braces:
        */
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};  // Array of Strings
        int[] myNum = {10, 20, 30, 40};  // Array if Ints

        /*
        You access an array element by referring to the index number. This statement accesses the value of the first 
        element in cars:
        */
        Console.WriteLine("cars[0] is: " + cars[0]);  // Outputs Volvo.

        // o change the value of a specific element, refer to the index number:
        cars[0] = "Opel";
        Console.WriteLine("cars[0] after re-assigning it is: " + cars[0]);  // Now outputs Opel instead of Volvo.

        // To find out how many elements an array has, use the Length property:
        Console.WriteLine("The number of elements in the \"cars\" Array is: " + cars.Length);  // Outputs 4

        /*
        If you are familiar with C#, you might have seen arrays created with the new keyword, and perhaps you have seen 
        arrays with a specified size as well. In C#, there are different ways to create an array:
        */
        // Create an array of four elements, and add values later
        string[] cars1 = new string[4];

        // Create an array of four elements and add values right away:
        string[] cars2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

        // Create an array of four elements without specifying the size:
        string[] cars3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

        // Create an array of four elements, omitting the new keyword, and without specifying the size:
        string[] cars4 = {"Volvo", "BMW", "Ford", "Mazda"};

        // If you declare an array and initialize it later, you have to use the "new" keyword.

    }

    static void LoopThroughAnArray()
    {
        /*
        You can loop through the array elements with the for loop, and use the Length property to specify how many 
        times the loop should run.
        
        The following example outputs all elements in the cars array:
        */

        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

        // For Loop:
        Console.WriteLine("For Loop:");
        for (int i = 0; i < cars.Length; i++) 
        {
            Console.WriteLine("\t\b\b\b\b\b\b" + (i + 1) + ") " + cars[i]);
        }

        // ForEach Loop:
        Console.WriteLine("\nForEach Loop:");
        foreach (string i in cars) 
        {
            Console.WriteLine("\t\b\b\b\b\b\b* " + i);
        }

    }

    static void SortArrays()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        Array.Sort(cars);
        Console.WriteLine("Sorted \"cars\" Array:");
        foreach (string i in cars)
        {
            Console.WriteLine("\t\b\b\b\b\b\b* " + i);
        }

        int[] myNumbers = {5, 1, 8, 9};
        Array.Sort(myNumbers);
        Console.WriteLine("Sorted Array of Integers:");
        foreach (int i in myNumbers)
        {
            Console.WriteLine("\t\b\b\b\b\b\b* " + i);
        }

        Console.WriteLine("The max int value in the Array is: " + myNumbers.Max());  // returns the largest value
        Console.WriteLine("The min int value in the Array is: " + myNumbers.Min());  // returns the smallest value
        Console.WriteLine("The sum of the values in the Array is: " + myNumbers.Sum());  // returns the sum of elements
    }

    static void MultidimentionalArrays()
    {
        /*
         Single dimension arrays are great, and something that will used a lot while programming in C#. However, to 
         store data as a tabular form, like a table with rows and columns, you need to get familiar with 
         multidimensional arrays. A multidimensional array is basically an array of arrays. Arrays can have any number 
         of dimensions. The most common are two-dimensional arrays (2D).
        */

        /* 
        To create a 2D array, add each array within its own set of curly braces, and insert a comma (,) inside the 
        square brackets:
        Note: The single comma [,] specifies that the array is two-dimensional. A three-dimensional array would have 
        two commas: int[,,].
        */
        int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

        // This statement accesses the value of the element in the first row (0) and third column (2) of the numbers array:
        Console.WriteLine("numbers[0, 2] is: " + numbers[0, 2]);  // Outputs 2

        // To change the value of an element...
        // The following example will change the value of the element in the first row (0) and first column (0):
        Console.WriteLine("number[0, 0] (before reassignment) is: " + numbers[0, 0]); // Outputs 5 instead of 1
        numbers[0, 0] = 5;  // Change value to 5
        Console.WriteLine("number[0, 0] (after reassignment) is: " + numbers[0, 0]); // Outputs 5 instead of 1

        // To loop through the elements of a two-dimensional array with a foreach loop:
        Console.WriteLine("The values in the 2D array(using a foreach loop) are: ");
        foreach (int i in numbers)
        {
            Console.WriteLine("\t\b\b\b\b\b\b* " + i);
        }

        /*
        To use a for loop. For multidimensional arrays, one loop is needed for each of the array's "dimensions". Also 
        note that the GetLength() method is used instead of the Length method to specify how many times the loop 
        should run:
        */
        Console.WriteLine("The values in the 2D array(using a for loop) are: ");
        for (int i = 0; i < numbers.GetLength(0); i++) 
        { 
            for (int j = 0; j < numbers.GetLength(1); j++) 
            { 
                Console.WriteLine("\t\b\b\b\b\b\b* " + numbers[i, j]);
            } 
        }  


    }

}
