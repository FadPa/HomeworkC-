// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int NamberInPower(int num1, int num2)
{
    int res = num1;
    if(num2 == 0)
    {
        res = 1;
    }
    else
    {
        for(int power = 1; power < num2; power++)
        {
            res = res * num1;
        }
    }
    return res;
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите степень числа: ");
int deg = Convert.ToInt32(Console.ReadLine());

int numpow = NamberInPower(num, deg);

if(deg < 0)
{
    Console.WriteLine($"Стевень должна быть положительной");
}
else
{
    Console.WriteLine($"Число {num} в степени {deg} равняется {numpow}");
}
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumber(int num)
{
    int sum = 0;
    if(num < 0) num = num * (-1);
    for(int count = num; count > 0; count /=10)
    {
        sum=sum + count % 10;
    }
    return sum;
}

Console.Clear();
Console.Write ("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = SumNumber(a);
Console.WriteLine(result);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array =new int[size];

    for(int i = 0; i < size;  i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] =Convert.ToInt32(Console.ReadLine()); 
    }
    return array;
}

void ShowArray(int[] array) 
{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
        // Console.WriteLine($"{i+1} элемент {array[i]}");
    }
}

Console.Write("Ведите количество элементов массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
if (Length > 0)
{
    int[] myArray = CreateRandomArray(Length);
    ShowArray(myArray);
}
else
{
    Console.WriteLine("Количество элементов массива не может быть отрицательным.");
}