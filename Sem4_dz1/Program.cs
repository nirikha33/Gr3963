// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// *Написать калькулятор с операциями +, -, /, * и возведение в степень

int numA;
int numB;

// выводим сообщение в консоль и считываем данные
Console.WriteLine("Введите число: ");
numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
numB = Convert.ToInt32(Console.ReadLine());

// применяем метод Math.Pow
Math.Pow(numA, numB);

// выводим сообщение в консоль
Console.WriteLine($"Число {numA} в степени {numB} равно: " +Math.Pow(numA, numB));