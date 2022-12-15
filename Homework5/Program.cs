// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

Console.Write("Введите количество элементов массива: ");
int Length = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(Length);
ShowArray(myArray);
int result = NumberOfEvenNumbers(myArray);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {result}");