using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine("It is a prime number.");
        }
        else
        {
            Console.WriteLine("It is not a prime number.");
        }
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false; // Not prime if less than or equal to 1

        if (number == 2)
            return true; // 2 is prime

        if (number % 2 == 0)
            return false; // Not prime if divisible by 2

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
                return false; // Not prime if divisible by any other number
        }

        return true; // Return true if it is prime
    }
}
