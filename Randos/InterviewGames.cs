namespace Randos;

public static class InterviewGames
{
    public static void ShowReverseNumber()
    {
        WriteInputPrompt("Enter a number to reverse");
        var valueEntered = Console.ReadLine();

        var result = ReverseNumber(valueEntered);
        
        if (result == null)
        {
            WriteErrorPrompt($"{valueEntered} is not a number");
            return;
        }

        WriteResultLine($"Reverse number is: {result}");
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
        WriteInputPrompt("Enter a string to reverse");
        var value = Console.ReadLine();

        var reversedString = ReverseString(value);
         
        WriteResultLine($"The reverse string is: {reversedString}");
    }

    private static string ReverseString(string? toReverse)
    {
        var valueArray = toReverse?.ToCharArray();
        Array.Reverse(valueArray ?? Array.Empty<char>());
        return new string(valueArray);
    }

    public static void ShowFactorial()
    {
        WriteInputPrompt("Enter a number to factor");
        var valueEntered = Console.ReadLine();
        
        var result = Factorial(valueEntered ?? string.Empty);

        if (result == null)
        {
            WriteErrorPrompt($"{valueEntered} is not a number");
            return;
        }
        
        WriteResultLine($"Factorial is: {result}");
    }

    private static double? Factorial(string valueEntered)
    {
        if (!int.TryParse(valueEntered, out var number))
            return null;
        
        try
        {
            if (number == 1)
                return 1;
        
            return number * Factorial((number - 1).ToString());
        }
        catch(Exception)
        {
            return null;
        }
    }
    
    public static void ShowFibonacci()
    {
        WriteInputPrompt("Enter the length of the Fibonacci Series: ");

        var valueEntered = Console.ReadLine();
        
        if (!int.TryParse(valueEntered, out var number))
        {
            WriteErrorPrompt($"{valueEntered} is not a number");
            return;
        }
        
        for (var i = 0; i < number; i++)  
        {  
            Console.Write("{0} ", FibonacciSeries(i));  
        }
        
        WriteLine(string.Empty);
    }
    
    private static int FibonacciSeries(int n)
    {
        return n switch
        {
            0 => 0,
            1 => 1,
            _ => FibonacciSeries(n - 1) + FibonacciSeries(n - 2)
        };
    }

    private static void WriteInputPrompt(string prompt)
    {
        WriteLine(prompt, ConsoleColor.Yellow);
    }

    private static void WriteResultLine(string line)
    {
        WriteLine(line, ConsoleColor.Green, true);
    }

    private static void WriteErrorPrompt(string errorPrompt)
    {
        WriteLine(errorPrompt, ConsoleColor.Red, true);
    }
    
    private static void WriteLine(string line, ConsoleColor color = ConsoleColor.White, bool includeLineFeed = false)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(line);
        
        if(includeLineFeed)
            Console.WriteLine("\r");
    }
}

