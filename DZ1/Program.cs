//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("введите число 1");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

Console.WriteLine("введите число 2");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);

if (number1 > number2)
{
Console.WriteLine("Число " + number1 + " больше");
}

if (number1 < number2)
{
Console.WriteLine("Число " + number2 + " больше");
}

if (number1 == number2) 
{
Console.WriteLine("Вы ввели одинаковые числа");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("введите число 1");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

Console.WriteLine("введите число 2");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);

Console.WriteLine("введите число 3");
string input3 = Console.ReadLine();
int number3 = Convert.ToInt32(input3);
int max = 0;

if (number1 > number2)
{
max = number1;
}

else
{
max = number2;
}

if (number3 > max)
{
max = number3;
}

Console.WriteLine("Максимальное - " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("введите число");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

if ((number1 % 2) ==0 )
{
Console.WriteLine("ДА - число чётное");
}

else
{
Console.WriteLine("НЕТ - число не чётное");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("введите число");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);
int count = 2;

Console.Write("Все чётные числа до вашего числа: ");

while (count <= number1)
{
Console.Write(count + " ");
count = count + 2;
}
*/
