// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Считываем данные с консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Генерируем рандомную матрицу
int[,] GenMatr(int min, int max, int row, int column)
{
    int[,] matr = new int[row, column];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matr[i, j] = numSintezator.Next(min, max);
        }
    }
    return matr;
}

// Метод умножения двух матриц
int[,] arrArr(int[,] arr1, int[,] arr2)
{
    int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (var i = 0; i < arr1.GetLength(0); i++)
    {
        for (var j = 0; j < arr2.GetLength(0); j++)
        {
            arr3[i, j] = 0;
            for (var k = 0; k < arr1.GetLength(1); k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return arr3;
}

void Print2DArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Запрашиваем у пользователя данные
int row = ReadData("Введите количество строк и столбцов: ");
int column = row;

// Генерируем матрицы
int[,] matr1 = GenMatr(1, 10, row, column);
int[,] matr2 = GenMatr(1, 10, row, column);

// Выводим данные в консоль
Console.WriteLine();
Console.WriteLine("Матрица 1:");
Console.WriteLine();
Print2DArr(matr1);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
Console.WriteLine();
Print2DArr(matr2);
Console.WriteLine();

int[,] arrMatr = arrArr(matr1, matr2);
Console.WriteLine("Результирующая матрица будет:");
Console.WriteLine();

Print2DArr(arrMatr);