﻿// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет

// 12821 -> да

// 23432 -> да

int num;

Console.WriteLine("Введите пятизначное число ");

num = Convert.ToInt32(Console.ReadLine());

if ((num / 10000 == num % 10)&&(num / 1000 % 10 == num / 10 % 10))
{
    Console.WriteLine("Данное чило - палиндром ");
}
else
{
    Console.WriteLine("Данное число - не палиндром ");
}
