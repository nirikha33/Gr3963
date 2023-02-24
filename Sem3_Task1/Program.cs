// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем Х не равно 0 и Y не равно 0 и выдает номер четверти плоскости, в которой находится эта точка.

// <тип> <имя метода>(<тип> <название переменной>)
// {
//     return <тип>
// }

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод определяет четверть по координатам точки
void PrintQuterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в первой четверти");
    if (x > 0 && y < 0) Console.WriteLine("Точка во второй четверти");
    if (x < 0 && y < 0) Console.WriteLine("Точка в третьей четверти");
    if (x < 0 && y > 0) Console.WriteLine("Точка в четвертой четверти");
}

int coordX = ReadData("Введите координату X: ");
int coordY = ReadData("Введите координату Y: ");
PrintQuterTest(coordX, coordY);