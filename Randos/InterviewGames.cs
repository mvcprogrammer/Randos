using System;

namespace Randos;

public static class InterviewGames
{
    public static void ShowReverseNumber()
    {
        Console.WriteLine("Enter a number to reverse");
        var valueEntered = Console.ReadLine();

        var result = ReverseNumber(valueEntered);
        
        if (result == null)
        {
            Console.WriteLine($"{valueEntered} is not a number");
            return;
        }

        Console.WriteLine($"Reverse number is {result}");
    }
    
    private static long? ReverseNumber(string? numberToReverse)
    {
        if (!int.TryParse(numberToReverse, out var number))
            return null;

        var reversedNumber = 0;

        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number /= 10;
        }

        return reversedNumber;
    }
    public static void ShowReverseString()
    {
        Console.WriteLine("Enter a string");
        var value = Console.ReadLine();

        var reversedString = ReverseString(value);
         
        Console.WriteLine($"The reverse string is {reversedString}");
        Console.ReadKey();
    }

    private static string ReverseString(string? toReverse)
    {
        var valueArray = toReverse?.ToCharArray();
        Array.Reverse(valueArray ?? Array.Empty<char>());
        return new string(valueArray);
    }

    public static void ShowFactorial()
    {
        Console.WriteLine("Enter a number to factor");
        var valueEntered = Console.ReadLine();

        if (!int.TryParse(valueEntered, out var number))
        {
            Console.WriteLine($"{valueEntered} is not a number");
            return;
        }
            
        var result = Factorial(number);

        if (result == null)
        {
            Console.WriteLine($"Exception while factoring {number}");
            return;
        }
        
        Console.WriteLine($"Factorial is {result}");
    }

    private static double? Factorial(int number)
    {
        try
        {
            if (number == 1)
                return 1;
        
            return number * Factorial(number - 1);
        }
        catch(Exception)
        {
            return null;
        }
    }
    
    public static void ShowFibonacci()
    {
        Console.Write("Enter the length of the Fibonacci Series: ");  
        int length = Convert.ToInt32(Console.ReadLine());  
        for (int i = 0; i < length; i++)  
        {  
            Console.Write("{0} ", FibonacciSeries(i));  
        }  
        Console.ReadKey(); 
    }
    
    private static int FibonacciSeries(int n)  
    {  
        if (n == 0) return 0; //To return the first Fibonacci number   
        if (n == 1) return 1; //To return the second Fibonacci number   
        return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);  
    }   
}

