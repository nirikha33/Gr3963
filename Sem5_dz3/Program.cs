// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Вводим данные
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];
RandomArray(Array);
PrintArray(Array);

// Метод рандома
void RandomArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-100, 100);
    }
}

// Поиск max и min 
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > max)
    {
        max = Array[i];
    }
    if (Array[i] < min)
    {
        min = Array[i];
    }
}

// Выводим в консоль разницу
Console.WriteLine($"Разница: {max - min}");

// Выводим в консоль массив
void PrintArray(int[] Array)
{
    Console.Write("[");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        Console.Write(Array[i] + ", ");
    }
    Console.WriteLine(Array[Array.Length - 1] + "]");
}