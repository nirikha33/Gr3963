// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int row = ReadInt("Введите индекс строки: ");
int col = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[4, 4];
FillArray2D(numbers);
PrintArray2D(numbers);

if (row < numbers.GetLength(0) && col < numbers.GetLength(1))
{
    Console.WriteLine(numbers[row, col]);
}
else 
{
    Console.WriteLine($"{row}{col} -> такого числа в массиве нет");
}


// Генерация массива
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//  Вывод массива в терминал
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция ввода 
int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}