// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//Принимаем из консоли число
int ReadInputInt(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

// Выводим сообщения в консоль
int num1 = ReadInputInt("Введите число M: ");
int num2 = ReadInputInt("Введите число N: ");

Console.WriteLine($"A({num1},{num2}) = {Akkerman(num1, num2)}");
