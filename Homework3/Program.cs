// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Clear();
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
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.Clear();
double FindDistance (double xA, double yA, double xB, double yB, double zA, double zB)
{
    double cathet1 = Math.Pow(xB - xA, 2);
    double cathet2 = Math.Pow(yB - yA, 2);
    double cathet3 = Math.Pow(zB - zA, 2);
    double result = Math.Round(Math.Sqrt(cathet1 + cathet2 +cathet3), 2);
    return result;
}

Console.Write("Input the first coordinate: x = ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second coordinate: y = ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the third coordinate: z = ");
double Za = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the first coordinate: x = ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second coordinate: y = ");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the third coordinate: z = ");
double Zb = Convert.ToDouble(Console.ReadLine());

double res = FindDistance (Xa, Ya, Xb, Yb, Za, Zb);

Console.WriteLine (res);
*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
void CubeOfTheNumber (int num)
{
    int count = 1;
    while (count <= num)
    {
        double cube = Math.Pow(count, 3);
        Console.Write(cube + " ");
        count++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

CubeOfTheNumber (number);