// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int num1;
int num2;

Console.WriteLine("Введите число №1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Максимальное число: "+num1);
    Console.WriteLine("Минимальное число: "+num2);
}

else
{
    Console.WriteLine("Максимальное число: "+num2);
    Console.WriteLine("Минимальное число: "+num1);
}