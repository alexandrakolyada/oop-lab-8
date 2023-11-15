// See https://aka.ms/new-console-template for more information
// Коляда Олександра
using System;
public class Calculator
{
    private double _result;
    private void SetResult(double value)
    {
        _result = value;
    }
    public double GetResult()
    {
        return _result;
    }
    public void Add(double a, double b)
    {
        SetResult(a + b);
    }
    public void Subtract(double a, double b)
    {
        SetResult(a - b);
    }
    public void Multiply(double a, double b)
    {
        SetResult(a * b);
    }
    public void Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Ділення на нуль неможливе.");

            SetResult(0);
        }
        else
        {
            SetResult(a / b);
        }
    }
    public void Modulus(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Ділення на нуль неможливе.");
           
            SetResult(0);
        }
        else
        {
            SetResult(a % b);
        }
    }
    public void Power(double a, double b)
    {
        SetResult(Math.Pow(a, b));
    }
    public void LogB(double b)
    {
        SetResult(Math.Log10(b));
    }
    public void SinA (double a)
    {
        SetResult(Math.Sin(a));
    }
    public void CosB (double b)
    {
        SetResult(Math.Cos(b));
    }
}
public class UserInterface
{
    private static int GetChoice()
    {
        Console.WriteLine("Виберіть операцію:");
        Console.WriteLine("1. Додавання");
        Console.WriteLine("2. Віднімання");
        Console.WriteLine("3. Множення");
        Console.WriteLine("4. Ділення");
        Console.WriteLine("5. Залишок від ділення");
        Console.WriteLine("6. Піднесення до степеня");
        Console.WriteLine("7. Знаходження log10 ");
        Console.WriteLine("8. Знаходження синусу");
        Console.WriteLine("9. Знаходження косинусу");

        Console.Write("Ваш вибір: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice < 1 || choice > 9)
        {
            Console.WriteLine("Неправильний вибір операції.");
            Environment.Exit(0);
        }
        return choice;
    }

    private static double GetOperand(string operandName)
    {
        Console.Write($"Введіть {operandName} операнд: ");
        return Convert.ToDouble(Console.ReadLine());
    }
    public static void ShowResult(double result)
    {
        Console.WriteLine("Результат: " + result);
    }

    public static void PerformOperation(Calculator calculator)
    {
        int choice = GetChoice();
        double operand1, operand2, operand;
        switch (choice)
        {
            case 7:
                operand = GetOperand("");
                calculator.LogB(operand);
                ShowResult(calculator.GetResult());
                break;
            case 8:
                operand = GetOperand("");
                calculator.SinA(operand);
                ShowResult(calculator.GetResult());
                break;
            case 9:
                operand = GetOperand("");
                calculator.CosB(operand);
                ShowResult(calculator.GetResult());
                break;
            default:
                operand1 = GetOperand("перший");
                operand2 = GetOperand("другий");
                switch (choice)
                {
                    case 1:
                        calculator.Add(operand1, operand2);
                        break;
                    case 2:
                        calculator.Subtract(operand1, operand2);
                        break;
                    case 3:
                        calculator.Multiply(operand1, operand2);
                        break;
                    case 4:
                        calculator.Divide(operand1, operand2);
                        break;
                    case 5:
                        calculator.Modulus(operand1, operand2);
                        break;
                    case 6:
                        calculator.Power(operand1, operand2);
                        break;
                }
                ShowResult(calculator.GetResult());
                break;
        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            UserInterface.PerformOperation(myCalculator);
        }
    }
