// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
    
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);