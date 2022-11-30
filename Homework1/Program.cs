// Домашняя работа 1
// Зачача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Clear();
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else
{
    if(num1 == num2)
    {
        Console.WriteLine("Числа равны!");
    }
    else
    {
        Console.WriteLine($"Число {num2} больше числа {num1}");
    }
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Clear();
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine(max);