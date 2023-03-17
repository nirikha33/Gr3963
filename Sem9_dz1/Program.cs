// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.

// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

//Принимаем из консоли число
int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Выводит в консоль сообщение
void PrintData(string line)
{
    Console.WriteLine(line);
}

// Выставляем числа от 1 до N
string LineGenRec(int N, int num)
{
    string res = String.Empty;
    if (num <= N)
    {
        res += num + " " + LineGenRec(N, num + 1);
        return res;
    }
    else
    {
        return res;
    }
}

int num = ReadData("Введите число N: ");
Console.WriteLine();
Console.Write($"N = {num} -> ");
PrintData($"{LineGenRec(num, 1)}");

