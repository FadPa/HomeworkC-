// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] array =new int[size];

    for(int i = 0; i < size;  i++)
    {
        array[i] = new Random().Next(100, 999 + 1); //maxValue +1 включает верхнюю велечину
    }
    return array;
}

void ShowArray(int[] array) //Выводит массив
{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
        // Console.WriteLine($"{i+1} element is {array[i]}");
    }
}

int NumberOfEvenNumbers (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 ==0) sum++;
    }
    return sum;
}
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int Length = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(Length);
ShowArray(myArray);
int result = NumberOfEvenNumbers(myArray);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {result}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array =new int[size];

    for(int i = 0; i < size;  i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1); //maxValue +1 включает верхнюю велечину
    }
    return array;
}

void ShowArray(int[] array) //Выводит массив
{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
        // Console.WriteLine($"{i+1} element is {array[i]}");
    }
}

int SumOfOddElements(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i +=2)
    {
        sum += array[i]; 
    }
    return sum;
}

Console.Clear();
Console.Write("Input a number of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);

int result = SumOfOddElements(myArray);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");
*/

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array =new double[size];

    for(int i = 0; i < size;  i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1) + Math.Round(new Random().NextDouble(), 2); //maxValue +1 включает верхнюю велечину
    }
    return array;
}

void ShowArray(double[] array) //Выводит массив
{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
        // Console.WriteLine($"{i+1} element is {array[i]}");
    }
}

double Difference(double[] array)
{
    double Min = array[0];
    double Max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > Max) Max = array[i];
        if(array[i] < Min) Min = array[i];
    }
        
    double dif = Max - Min;
    return Math.Round(dif,2);
}
Console.Clear();
Console.Write("Input a number of elements: ");
int Length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);
double result = Difference(myArray);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом: {result}");
