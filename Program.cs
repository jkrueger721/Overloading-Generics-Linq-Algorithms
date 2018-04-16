using System;
using System.Linq;


namespace OverloadingGenericsLinqAlgorithms
{
    class Overloading
    {
        // Implement two overloaded methods named Display.
        // The first overloaded version takes a single parameter of type
        // int and displays that parameter in the console output.
        // The second overloaded version takes a single parameter of type
        // string and displays that parameter in the console output.
        public static void Display(int num)
        {
            Console.WriteLine(num);
        }
        public static void Display(string hi)
        {
            Console.WriteLine(hi); 
        }
    }

    class IndexerProperty
    {
        // Implement a read-only indexer property that simply
        // returns the string representation of its int type index value.

        public string this[string index]    // Indexer declaration  
        {
            get
            {
                return index;
            }
            
        }

    }

    class Generics
    {
        // Implement a generic method named GenericSwapMethod that takes
        // two parameters of any type and swaps them in a persistent way.
       public static void GenericSwapMethod<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }

    class Linq
    {
        static public void DisplayEvens(int[] numbers)
        {
            // Google for examples on using LINQ query syntax and then
            // implement a LINQ query that selects only those elements
            // in the int array parameter named numbers, and then display
            // the results of the that query in the console output from
            // within a foreach loop.
            var query = from number in numbers
                        select number;
            foreach (int number in query)
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                
            

        }
    }

    class Gauss
    {
        static public int AddIntegersFromOneUpTo(int limit)
        {
            
            // Google for a description of "Gauss sum of integers"
            // Then implement that algorithm here and return the result.
            int s = limit *(limit + 1) / 2;
            return s;
        }
    }

    class Program
    {
        static void Main()
        {
            // Call the two overloaded versions of the Display method.
            // The first call passes in the int value of 42.
            // The second call passes in the string value of "Hello Overloading".
            Overloading.Display(42);
            Overloading.Display("Hello Overloading");


            // Access the indexer property on the IndexerProperty class,
            // specifying the index value of 42, and display the result
            // in the console output.
            IndexerProperty ip = new IndexerProperty();
            Console.WriteLine(ip["42"]);

            // Declare two int variables named x and y with the initial
            // values of 3 and 4. Then display the two values on the console.
            // Then call the GenericSwapMethod, passing in the two parameters.
            // After that, display the values on the console output and see
            // that they are swapped.
            int x = 3;
            int y = 4;
            Console.WriteLine($"x: {x}, y: {y}");
            Generics.GenericSwapMethod<int>(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");
            System.Console.WriteLine(x + " " + y);

            // Declare an array of int named numbers and initialize
            // it with the element values: 1, 2, 3, 4, 5, 6, 7, 8.
            // Then call the DisplayEvens method and see that only even
            // elements are displayed.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Linq.DisplayEvens(numbers);


            // Call the AddIntegersFromOneUpTo method with a parameter set to 100.
            // Then display the result on the console output.
           int gaussResult = Gauss.AddIntegersFromOneUpTo(100);
            Console.WriteLine(gaussResult);

        }
    }
}