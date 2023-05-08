using System;

class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Введите число: ");

        string numberString = Console.ReadLine();

        int maxDigit = int.MinValue;

        int minDigit = int.MaxValue;

        for (int i = 0; i < numberString.Length; i++)

        {

            int digit = int.Parse(numberString[i].ToString());

            if (digit > maxDigit)

            {

                maxDigit = digit;

            }

            if (digit < minDigit)

            {

                minDigit = digit;

            }

        }

        Console.WriteLine("Максимальная цифра: " + maxDigit);

        Console.WriteLine("Минимальная цифра: " + minDigit);

        Console.ReadKey();

    }

}