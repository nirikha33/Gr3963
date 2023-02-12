// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int num1;
int numN;

Console.WriteLine("Введите число №1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2: ");
numN = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= numN; i = i + 2)
{
    Console.Write(i + " ");
}