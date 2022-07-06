//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int dig1 = number / 10000;
int dig2 = (number / 1000) % 10;
int dig4 = (number / 10) % 10;
int dig5 = number % 10;

if (number < 9999 || number > 99999)
{
    Console.Write("Число не пятизначное");
}
else
{
    if (dig1 == dig5 && dig2 == dig4)
    {
        Console.Write("Да, число - полиндром");
    }
    else
    {
        Console.Write("Нет, число - не полиндром");
    }
}
*/

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.Write("введите координату точки A по x: ");
double aX = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки A по y: ");
double aY = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки A по z: ");
double aZ = Convert.ToInt32(Console.ReadLine());

Console.Write("введите координату точки B по x: ");
double bX = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки B по y: ");
double bY = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки B по z: ");
double bZ = Convert.ToInt32(Console.ReadLine());

double quadroX = Coord(bX, aX);
double quadroY = Coord(bY, aY);
double quadroZ = Coord(bZ, aZ);
double result = Math.Sqrt(quadroX + quadroY + quadroZ);

double Coord(double a, double b)
{
    return Math.Pow((b - a), 2);
}

Console.WriteLine($"расстояние между точками = {result}");
*/
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.WriteLine("Введите число N");
double num = Convert.ToInt32(Console.ReadLine());
double numCube = Math.Pow(num, 3);
double count = 1;
double Cube = 0;

while (count < num)
{
    Cube = Math.Pow(count, 3);
    Console.Write(Cube + ",");
    count++;
}
Console.Write(numCube);
*/