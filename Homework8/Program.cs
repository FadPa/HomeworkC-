// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j= 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int x = 0; x < array.GetLength(1) - 1; x++)
      {
        if (array[i, x] < array[i, x + 1])
        {
          int temp = array[i, x + 1];
          array[i, x + 1] = array[i, x];
          array[i, x] = temp;
        }
      }
    }
  }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
OrderArrayLines(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j= 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinString(int[,] array)
{
    int min  = 0;
    int sum = SumString(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = SumString(array, i);
        if (sum > temp)
        {
            sum = temp;
            min = i+1;
        }
    }
    Console.WriteLine($"Строка {min} с минимальной суммой элементов равной {sum}");
}

int SumString(int[,] array, int i)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    } 
    return sum;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
MinString(myArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray1()
{
    Console.Write("Input a number of rows fist array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns fist array: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value fist array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value fist array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j= 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

int[,] CreateRandom2dArray2()
{
    Console.Write("Input a number of rows second array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns second array: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value second array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value second array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j= 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProductOfArrays (int[,] array, int[,] array2)
{
    if(array.GetLength(1) != array2.GetLength(0))
        {
            Console.Write("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }
 
        int[,] matrix = new int[array.GetLength(0), array2.GetLength(1)];
 
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array2.GetLength(1); j++)
            {
                matrix[i, j] = 0;
 
                for (var k = 0; k < array.GetLength(1); k++)
                {
                    matrix[i, j] += array[i, k] * array2[k, j];
                }
            }
        }
 
        return matrix;
}

Console.WriteLine("Введите данные первого массива:");
int[,] myArray = CreateRandom2dArray1();
Show2dArray(myArray);
Console.WriteLine("Введите данные второго массива:");
int[,] mySecondArray = CreateRandom2dArray2();
Show2dArray(mySecondArray);
int[,] res =ProductOfArrays(myArray, mySecondArray);
Show2dArray(res);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3DArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];

    for(int i = 0; i < x; i++)
    {
        for(int j= 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write( $"Z({k})={array[i,j,k]}; ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите расзмерность трехмерного массива:");
Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] my3DArray = CreateRandom3DArray(x, y, z);
Show3dArray(my3DArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] CreateRandom2dArray(int s)
{

    int[,] array = new int[s, s];
    int temp = 1;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            while (temp <= array.GetLength(0) * array.GetLength(1))
            { 
                array[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;

                else if (i < j && i + j >= array.GetLength(0) - 1) i++;

                else if (i >= j && i + j > array.GetLength(1) - 1) j--;

                else i--;
            }       
        
        
        }    
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите размерность матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(size);
Show2dArray(myArray);