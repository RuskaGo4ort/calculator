using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Кодировка консоли: " + Console.OutputEncoding.WebName);

            


            Console.WriteLine("Привет, вы в калькуляторе! Пишите на Английском языке, пожалуйста.");
            Console.WriteLine("Пожалуйста, введите ваше имя:");
            string? name = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Имя не может быть пустым!");
                return;
            }

            Console.WriteLine($"Привет, {name}! Хотите ли вы начать вычисления? (yes/no)");
            string? answer = Console.ReadLine()?.ToLower().Trim();

            if (answer == "да")
            {
                Console.WriteLine("Введите первое число:");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Неверный ввод числа!");
                    return;
                }

                Console.WriteLine("Введите второе число:");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Неверный ввод числа!");
                    return;
                }

                Console.WriteLine("Введите операцию (+, -, *, /):");
                string? operation = Console.ReadLine();

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            return;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверную операцию!");
                        return;
                }

                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("До свидания!");
            }
        }
    }
}
