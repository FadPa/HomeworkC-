// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome (int num)
{
int temp = num;
int rev = 0;
while(num > 0)
{
    int dig = num % 10;
    rev = rev * 10 + dig;
    num /= 10;
}

if(temp == rev)
    Console.WriteLine("Это палиндром!");
else
    Console.WriteLine("Это не палиндром!");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);