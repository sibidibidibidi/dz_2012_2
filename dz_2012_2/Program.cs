using System;

class Program
{
    static void Main(string[] args)
    {
        Action showtime = () => Console.WriteLine("Час: " + DateTime.Now.ToString("HH:mm:ss"));
        Action showdate = () => Console.WriteLine("Дата: " + DateTime.Now.ToShortDateString());
        Action showday = () => Console.WriteLine("День тижня: " + DateTime.Now.DayOfWeek);

        Func<double, double, double, double> trarea = (double a, double b, double c) =>
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        };

        Func<double, double, double> recarea = (double w, double h) => w * h;
        Predicate<double> ispositive = val => val > 0;
        showtime();
        showdate();
        showday();

        Console.WriteLine("\n--- Введення даних ---");

        Console.WriteLine("Введіть 3 сторони трикутника через пробіл:");
        string[] triinput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        double a = double.Parse(triinput[0]);
        double b = double.Parse(triinput[1]);
        double c = double.Parse(triinput[2]);

        if (ispositive(a) && ispositive(b) && ispositive(c))
        {
            double area = trarea(a, b, c);
            Console.WriteLine($"Площа трикутника: {area:F2}");
        }
        else
        {
            Console.WriteLine("Сторони трикутника мають бути додатні.");
        }
        Console.WriteLine("Введіть ширину і висоту прямокутника через пробіл:");
        string[] recinput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        double w = double.Parse(recinput[0]);
        double h = double.Parse(recinput[1]);

        if (ispositive(w) && ispositive(h))
        {
            double area = recarea(w, h);
            Console.WriteLine($"Площа прямокутника: {area:F2}");
        }
        else
        {
            Console.WriteLine("Значення недодатні, спробуйте ще раз.");
        }

        Console.ReadLine();
    }
}
