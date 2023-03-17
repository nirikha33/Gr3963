// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Генерируем 3D массив
int[,,] Gen3DArray(int min, int max, int numX, int numY, int numZ)
{
    int t = 0;
    int[] randomNum = new int[numX * numY * numZ];
    int[,,] array = new int[numX, numY, numZ];
    // Метод возвращающего массив неповторяющихся двузначных чисел 
    randomNum = GenRandomArry(randomNum.GetLength(0));

    for (int i = 0; i < numX; i++)
    {
        for (int j = 0; j < numY; j++)
        {
            for (int k = 0; k < numZ; k++)
            {
                array[i, j, k] = randomNum[t];
                t++;
            }
        }
    }
    return array;
}

// Генерируем неповторяющиеся числа
int[] GenRandomArry(int len)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        int r = rnd.Next(10, 100);
        if (!(arr.Contains(r)))
        {
            arr[i] = r;
        }
        else
        {
            i++;
        }
    }
    return arr;
}

// Выводим массив на экран
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k})\t");
            }
        }
    }
}

// Задаем массив
int[,,] array1 = Gen3DArray(1, 10, 2, 2, 2);

// Выводим массив в терминал
Print3DArray(array1);
Console.WriteLine();