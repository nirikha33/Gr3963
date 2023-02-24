// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string LineBuilder(int end, int pow)
{
    string res = String.Empty;
    for (int i = 1; i <= end; i++)
    {
        res = res + Math.Pow(i, pow) + "\t";
    }
    return res;
}

int N = ReadInput("Введите число: ");
Console.WriteLine(LineBuilder(N, 1));
Console.WriteLine(LineBuilder(N, 3));