using System;

namespace DeligateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<double> Operation = new Calculator<double>();
            while (true)
            {
                Console.Write("Аргумент_1: "); double arg_1 = double.Parse(Console.ReadLine());
                Console.Write("Аргумент_2: "); double arg_2 = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Выберите действия(+ , - , * , /);");
                switch (Console.ReadLine())
                {
                    case "+":
                        {
                            Console.WriteLine(Operation.OpPlus(arg_1, arg_2));
                        }
                        break;
                    case "-":
                        {
                            Console.WriteLine(Operation.OpMinus(arg_1, arg_2));
                        }
                        break;
                    case "*":
                        {
                            Console.WriteLine(Operation.OpMultiply(arg_1, arg_2));
                        }
                        break;
                    case "/":
                        {
                            Console.WriteLine(Operation.OpDivide(arg_1, arg_2));
                        }
                        break;
                    default:
                        {
                            return;
                        }
                }
            }
        }
    }
    class Calculator<T>
    {
        public delegate T DelCalculator(T a, T b);
        public DelCalculator OpPlus = Plus;
        public DelCalculator OpMinus = Minus;
        public DelCalculator OpMultiply = Multiply;
        public DelCalculator OpDivide = Divide;
        private static T Plus(T a, T b)         //Вызов методов происходит только по средством делегата. по этому private
        {
            System.Console.Write($"{a} + {b} = ");
            return (dynamic)a + (dynamic)b;
        }
        private static T Minus(T a, T b)
        {
            System.Console.Write($"{a} - {b} = ");
            return (dynamic)a - (dynamic)b;
        }
        private static T Multiply(T a, T b)
        {
            System.Console.Write($"{a} * {b} = ");
            return (dynamic)a * (dynamic)b;
        }
        private static T Divide(T a, T b)
        {
            if ((dynamic)b == 0)
            {
                System.Console.Write($"Ошибка: Деление на нол!!!\t{a} / ");
                return (dynamic)b;
            }
            else
            {
                System.Console.Write($"{a} / {b} = ");
                return (dynamic)a / (dynamic)b;
            }
        }
    }
}
