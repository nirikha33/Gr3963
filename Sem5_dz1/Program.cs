// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Вводим данные
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];
RandomArray(Array);
PrintArray(Array);
int count = 0;

// Ищем четные
for (int i = 0; i < Array.Length; i++)
if (Array[i] % 2 == 0)
count++;

// Выводим в консоль кол-во четных чисел
Console.WriteLine($"В массиве четных числе: {count}");

// Метод рандома
void RandomArray(int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(100,999);
    }
}
// Выводим в консоль массив
void PrintArray(int[] Array)
{
    Console.Write("[");
    for(int i = 0; i < Array.Length - 1; i++)
    {
        Console.Write(Array[i] + ", ");
    }
    Console.WriteLine(Array[Array.Length - 1] + "]");
}