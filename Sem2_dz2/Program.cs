//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//* Сделать вариант для числа длиной до 10 цифр не используя char или string

// int num;
// int numToCharArray;

// Console.WriteLine("Введите число ");
// num = Convert.ToInt32(Console.ReadLine());
// char[]array = numToCharArray();

// Console.WriteLine(array[2]);

int num1;
int num2;

Console.WriteLine("Введите число ");

num1 = Convert.ToInt32(Console.ReadLine());
if(num1>=100 && num1<=999)
{
    num2 = num1%10;
    Console.WriteLine(num2);
}

if(num1<=99)
{
    Console.WriteLine("Третьей цифры нет ");
}



