// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Вводим данные
int k1;
int k2;
int b1;
int b2;
int x;
int y;

Console.Write("Введите координату k1: ");
k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату k2: ");
k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату b1: ");
b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату b2: ");
b2 = Convert.ToInt32(Console.ReadLine());

// Ищем координаты
x = (b2 - b1) / (k1 - k2);
y = k2 * x + b2;

// Выводим в консоль итог
Console.WriteLine($"Точка пересечения: ({x}; {y})");