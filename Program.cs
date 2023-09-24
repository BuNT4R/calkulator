using System;


namespace calkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доступные операции: 1)Сложение; 2)Вычитание; 3)Умножение; 4)Деление");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое число");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double m = Convert.ToDouble(Console.ReadLine());
            double end;
            switch (f) 
            {
                case 1:
                    end = n+m;
                    Console.WriteLine(end);
                    break;
                case 2: 
                    end = n-m; 
                    Console.WriteLine(end); 
                    break;
                case 3:
                    end = n * m;
                    Console.WriteLine(end);
                    break;
                case 4:
                    if (m == 0) 
                    {
                        Console.WriteLine("Осуждаем деление на 0");

                    }
                    else 
                    {
                        end = n / m;
                        Console.WriteLine(end);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
