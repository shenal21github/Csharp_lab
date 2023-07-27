using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClassObj = new MyClass();

            // Trying to access the private method. This will result in a compilation error.
            myClassObj.SayHello();

            Console.WriteLine("End of the program.");
            Console.ReadKey();
        }
    }
}

