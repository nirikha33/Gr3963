// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int num1;
int num2;

Console.WriteLine("Введите трехзначное число ");

num1 = Convert.ToInt32(Console.ReadLine());
num2 = (num1/10)%10;
Console.WriteLine(num2);
