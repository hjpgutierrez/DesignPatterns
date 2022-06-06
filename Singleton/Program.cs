using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInterface1 = BusinessErrorHandler.GetInstance();
            var userInterface2 = BusinessErrorHandler.GetInstance();

            // Confirm these are the same instance
            if (userInterface1 == userInterface2)
            {
                Console.WriteLine("Same instance");
            }

            Console.WriteLine("Error clientCode1: " + userInterface1.GetErrorMessage(1001).Message);
            Console.WriteLine("Error clientCode2: " + userInterface2.GetErrorMessage(1003).Message);
        }
    }
}
