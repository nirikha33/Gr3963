// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//Принимаем из консоли число
int ReadInputInt(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Нахождение суммы
int SumNum(int m, int n)
{
    int res = 0;

    if (m > n) return res;
    else
    {
        res += m + SumNum(m + 1, n);
        return res;
    }
}

// Выводим сообщения в консоль
int num1 = ReadInputInt("Введите число М: ");
int num2 = ReadInputInt("Введите число N: ");
if (num1 > num2) (num1, num2) = (num2, num1);
Console.WriteLine();
Console.WriteLine($"M = {num1}; N = {num2} -> {SumNum(num1, num2)}");