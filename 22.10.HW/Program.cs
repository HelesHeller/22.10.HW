using System;

public class Program
{
    // Завдання 1: Додаток для відображення текстового повідомлення за допомогою делегата
    public delegate void DisplayMessageDelegate(string message);

    public static void DisplayMessage(string message)
    {
        Console.WriteLine($"Повідомлення: {message}");
    }

    // Завдання 2: Додаток для арифметичних операцій за допомогою делегата
    public delegate double ArithmeticOperation(double a, double b);

    public static double Addition(double a, double b)
    {
        return a + b;
    }

    public static double Subtraction(double a, double b)
    {
        return a - b;
    }

    public static double Multiplication(double a, double b)
    {
        return a * b;
    }

    // Завдання 3: Додаток для перевірки чисел за допомогою делегата типу Predicate
    public delegate bool CheckNumberDelegate(int number);

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsFibonacci(int number)
    {
        int a = 0, b = 1;
        while (b < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b == number;
    }

    public static void Main()
    {
        // Завдання 1: Виклик методів через делегата для відображення повідомлення
        DisplayMessageDelegate displayMessage = DisplayMessage;
        displayMessage("Привіт, це відображення повідомлення через делегат!");

        // Завдання 2: Виклик арифметичних операцій через делегата
        ArithmeticOperation add = Addition;
        ArithmeticOperation subtract = Subtraction;
        ArithmeticOperation multiply = Multiplication;

        double resultAddition = add(5, 3);
        double resultSubtraction = subtract(5, 3);
        double resultMultiplication = multiply(5, 3);

        Console.WriteLine($"Додавання: {resultAddition}");
        Console.WriteLine($"Віднімання: {resultSubtraction}");
        Console.WriteLine($"Множення: {resultMultiplication}");

        // Завдання 3: Виклик перевірок чисел через делегата Predicate
        CheckNumberDelegate isEven = IsEven;
        CheckNumberDelegate isOdd = IsOdd;
        CheckNumberDelegate isPrimeNumber = IsPrime;
        CheckNumberDelegate isFibonacciNumber = IsFibonacci;

        int numberToCheck = 7;
        Console.WriteLine($"{numberToCheck} є парним: {isEven(numberToCheck)}");
        Console.WriteLine($"{numberToCheck} є непарним: {isOdd(numberToCheck)}");
        Console.WriteLine($"{numberToCheck} є простим числом: {isPrimeNumber(numberToCheck)}");
        Console.WriteLine($"{numberToCheck} є числом Фібоначчі: {isFibonacciNumber(numberToCheck)}");

        // Завдання 4: Виклик методів через Invoke
        ArithmeticOperation additionDelegate = new ArithmeticOperation(Addition);
        ArithmeticOperation subtractionDelegate = new ArithmeticOperation(Subtraction);
        ArithmeticOperation multiplicationDelegate = new ArithmeticOperation(Multiplication);

        double result1 = additionDelegate.Invoke(10, 5);
        double result2 = subtractionDelegate.Invoke(10, 5);
        double result3 = multiplicationDelegate.Invoke(10, 5);

        Console.WriteLine($"Додавання: {result1}");
        Console.WriteLine($"Віднімання: {result2}");
        Console.WriteLine($"Множення: {result3}");
    }
}
