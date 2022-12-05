// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
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
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int SearchThirdNumber (int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    int result = num % 10;
    return result;
}

Console.Clear();
Console.Write("Ведите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100)
{
    int thirdnumber = SearchThirdNumber(num);
    Console.WriteLine(thirdnumber);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}
