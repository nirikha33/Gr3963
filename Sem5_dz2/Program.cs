// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Вводим данные
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];
RandomArray(Array);
PrintArray(Array);
int sum = 0;

// Метод рандома
void RandomArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-10, 10);
    }
}

// Ищем сумму
for (int i = 0; i < Array.Length; i=i+2)
    sum = sum + Array[i+1];

Console.WriteLine($"Cумма элементов cтоящих на нечётных позициях: {sum}");

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