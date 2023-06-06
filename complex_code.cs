using System;
using System.Collections.Generic;

public class ComplexCode
{
    public static void Main()
    {
        int n = 100;
        List<int> primes = CalculatePrimes(n);
        List<long> fib = CalculateFibonacciSequence(n);
        double piApproximation = CalculatePi(n);

        Console.WriteLine("Prime numbers up to " + n + ": " + string.Join(", ", primes));
        Console.WriteLine("Fibonacci sequence up to " + n + ": " + string.Join(", ", fib));
        Console.WriteLine("Approximation of pi using " + n + " terms: " + piApproximation);
    }

    public static List<int> CalculatePrimes(int n)
    {
        List<int> primes = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes;
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static List<long> CalculateFibonacciSequence(int n)
    {
        List<long> fib = new List<long>();
        long a = 0;
        long b = 1;
        fib.Add(a);
        fib.Add(b);

        for (int i = 2; i < n; i++)
        {
            long c = a + b;
            fib.Add(c);
            a = b;
            b = c;
        }

        return fib;
    }

    public static double CalculatePi(int n)
    {
        double piSum = 0.0;
        for (int i = 0; i < n; i++)
        {
            double term = Math.Pow(-1, i) / (2 * i + 1);
            piSum += term;
        }
        return 4 * piSum;
    }
}
