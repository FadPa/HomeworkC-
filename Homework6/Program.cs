// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void CountNumber (int numM)
{
    int count = 0;
    for (int i = 0; i < numM; i++)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) count++;
        Console.WriteLine($"Количество введённых чисел больше 0 равняется {count}");
    }
    
}

Console.Clear();
Console.Write("Введите количество вводимых чисел: ");
int num = Convert.ToInt32(Console.ReadLine());

CountNumber(num);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionOfStraightLines (double  b1, double  k1, double  b2, double  k2)
{
    if(k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают!");
    else
    {
        if (k1 == k2)
            Console.WriteLine("Прямые параллельны!");
        else
        {
            double  x = (b2 - b1) / (k1 - k2);
            double  y = (k1*(b2 - b1))/(k1 - k2)+ b1;
            Console.WriteLine($"{x};{y}");
        }
    }
}

Console.Clear();
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionOfStraightLines(b1,  k1,  b2,  k2);