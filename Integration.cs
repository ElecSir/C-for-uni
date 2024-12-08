using System;

namespace TrapezoidalIntegration
{
    // Класс для интеграции методом трапеций
    public class TrapezoidalIntegrator
    {
        public double Integrate(Func<double, double> func, double a, double b, int n)
        {
            if (n <= 0)
                throw new ArgumentException("Количество разбиений должно быть больше нуля.");

            double h = (b - a) / n; // Ширина разбиений
            double sum = (func(a) + func(b)) / 2.0; // Начальные значения для суммы

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h; // Точка, в которой оцениваем функцию
                sum += func(x); // Прибавляем значение функции в точке x
            }

            return sum * h; // Умножаем на ширину разбиений
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ввод пределов интегрирования и количества разбиений
            Console.Write("Введите нижний предел интегрирования (a, для пи введите 'pi'): ");
            double a = ParseInput(Console.ReadLine());

            Console.Write("Введите верхний предел интегрирования (b, для пи введите 'pi'): ");
            double b = ParseInput(Console.ReadLine());

            Console.Write("Введите количество разбиений (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Создаем объект интегратора
            TrapezoidalIntegrator integrator = new TrapezoidalIntegrator();

            // Определяем функцию для интегрирования
            Func<double, double> function = x => 5 * Math.Sin(5.0 / 6.0 * x);

            // Рассчитываем интеграл
            double result = integrator.Integrate(function, a, b, n);
            Console.WriteLine($"Результат численного интегрирования: {result}");

            // Аналитическое решение
            double analyticalResult = AnalyticalSolution(a, b);
            Console.WriteLine($"Аналитическое решение: {analyticalResult}");

            // Сравнение результатов
            Console.WriteLine($"Ошибка: {Math.Abs(result - analyticalResult)}");
        }

        static double ParseInput(string input)
        {
            // Проверка на специальное значение "pi"
            if (input.Trim().ToLower() == "pi")
            {
                return Math.PI; 
            }
            // Если не "pi", пробуем преобразовать в число
            return Convert.ToDouble(input);
        }

        static double AnalyticalSolution(double a, double b)
        {
            // Формула Ньютона-Лейбница для данной функции
            return -6 * 5 * (Math.Cos(5.0 / 6.0 * b) - Math.Cos(5.0 / 6.0 * a));
        }
    }
}
