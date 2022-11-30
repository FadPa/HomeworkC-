// Домашняя работа 1
// Зачача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else
{
    if(a == b)
    {
        Console.WriteLine("Числа равны!");
    }
    else
    {
        Console.WriteLine($"Число {b} больше числа {a}");
    }
}