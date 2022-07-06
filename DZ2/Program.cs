//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("введите цифру дня недели");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 0 && x < 6)
{
    Console.Write("Нет");
}

if (x > 5 && x < 8)
{
    Console.Write("Да");
}

if (x < 1 || x > 7)
{
    Console.Write("Ввели не корректный день недели");
}
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 100)
{
    Console.Write("третьей цифры нет");
}
else
{
    while (x >= 1000)
    {
        x = x / 10;
    }

    if (x < 1000)
    {
        int three = x % 100;
        int tow = three % 10;
        Console.Write(tow);
    }
}
*/
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1000 && x > 99)
{
int two = x / 10;
int result = two % 10;
Console.Write(result);
}
else
Console.WriteLine("ввели не трехзначное число");
*/
// Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
Console.WriteLine("введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int quadro1 = Quadro(num1);
int quadro2 = Quadro(num2);

if (quadro1 == num2 || quadro2 == num1)
{
Console.Write("Да");
}
else 
{
  Console.Write("Нет");  
}

int Quadro (int a)
{
    return a * a;
}
*/