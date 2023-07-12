using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Line Comparison statement");
            Operation operation = new Operation(2, 1, 4, 3);
            operation.CalculateLength();
        }
    }
}
