using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var fibonacciNumbers = new List<Double> { 1, 1 };

        // Generate the next 10 Fibonacci numbers
        for (Double i = 2; i <= 11; i++)
        {
            var previous = fibonacciNumbers[^1];
            var previous2 = fibonacciNumbers[^2];
            fibonacciNumbers.Add(previous + previous2);
        }

        // Print all Fibonacci numbers in the list
        foreach (var item in fibonacciNumbers)
        {
            Console.WriteLine(item);
        }
    }
}

/////////////////////////////////////////////////////////////////////////////////////////////////

var fibonaccinumbers = new List<int> {1, 1};

// Generate the next 20 Fibonacci numbers
while (fibonaccinumbers.Count < 20)
{
    var number1 = fibonaccinumbers[^1];
    var number2 = fibonaccinumbers[^2];
    fibonaccinumbers.Add(number1 + number2);
}

// Print all Fibonacci numbers in the list
foreach (var number in fibonaccinumbers)
{
    Console.WriteLine(number);
}
