// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// *Сделать оценку времени алгоритма через числа и строки

// вводим переменную
int num;

// выводим сообщение в консоль
Console.WriteLine("Введите число: ");

// считываем данные из сообщения
num = Convert.ToInt32(Console.ReadLine());

// добавляем метод SumSimple
int SumSimple(int num)
{
    int sum = 0;
    while(num>=1)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int res = SumSimple(num);

// выводим результат в консоль
Console.WriteLine($"Сумма цифр в числе {num}: " + res);