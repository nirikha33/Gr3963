// Напишите программу, которая принимает число, 
// а на выходе показывает количество цифр в данном числе.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

int NumberOfDigits(int num)
{
    return (int)(Math.Floor(Math.Log10(num))) + 1;
}

void PrintAnswer(string explain, int num)
{
    Console.WriteLine(explain + num);
}

int num = ReadData("Введите число: ");
PrintAnswer("Количество цифр в данном числе: ", NumberOfDigits(num));