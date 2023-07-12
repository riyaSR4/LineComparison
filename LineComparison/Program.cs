using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Line Comparison statement");
            Operation operation1 = new Operation(2, 1, 4, 3);
            double line1 = operation1.CalculateLength();
            Operation operation2 = new Operation(2, 1, 4, 3);
            double line2 = operation2.CalculateLength();
            //Equality
            if (line1.Equals(line2))
                Console.WriteLine("Line1 and Line2 are equal");
            else
                Console.WriteLine("Line1 and Line2 are not equal");

        }
    }
}
