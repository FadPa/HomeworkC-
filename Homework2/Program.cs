// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int FindNumber (int num)
{
    int result = num / 10 % 10;
    return result;
}

Console.Clear();

Console.Write("Ведите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int secondnum = FindNumber(num);

Console.WriteLine (secondnum);