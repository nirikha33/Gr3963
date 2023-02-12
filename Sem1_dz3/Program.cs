// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int num1;

Console.WriteLine("Введите число: ");

num1 = Convert.ToInt32(Console.ReadLine());

if ((num1 % 2) == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}