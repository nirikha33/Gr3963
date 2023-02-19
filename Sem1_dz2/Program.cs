// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int num1;
int num2;
int num3;

Console.WriteLine("Введите число №1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №3: ");
num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 && num1 > num3)
{
    Console.WriteLine("Максимальное число: "+num1);
}

if(num2 > num1 && num2 > num3)
{
    Console.WriteLine("Максимальное число: "+num2);
}

if(num3 > num2 && num3 > num1)
{
    Console.WriteLine("Максимальное число: "+num3);
}
