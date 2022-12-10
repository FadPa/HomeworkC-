// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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