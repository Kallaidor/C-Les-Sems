/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Задача 62: Заполните спирально массив 4 на 4.
*/

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int linesVol = Input("Введите количество строк: ");
int columnsVol = Input("Введите количество столбцов: ");

int[,] array = new int[linesVol, columnsVol];
FillArrayRandomNumbers(array);
Console.WriteLine("наш Массив");
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array[i, k] < array[i, k + 1])
            {
                int temp = 0;
                temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine("Упорядоченный массив");
PrintArray(array);


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
            numbers[i, j] = new Random().Next(0, 100);
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }

}
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("введите размер прямоугольного массива");
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[massVol, massVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;
int minsum = int.MaxValue;
int indexMinLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    sum =0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexMinLine = i+1;
    }
    Console.WriteLine($"сумма {i+1}-ой строки равна {sum}");
}

Console.WriteLine($"строка с наименьшей суммой элементов под номером -  {indexMinLine}");
*/

//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 


void Fill3DArrayRandomNumbers(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(0, 100);
                for (int x = 0; x < i; x++)
                {
                    for (int y = 0; y < j; y++)
                    {
                        for (int z = 0; z < k; z++)
                        {
                            while (array[i, j, k] == array[x, y, z])
                               Fill3DArrayRandomNumbers(array);
                        }
                    }
                }
            }
        }
    }
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("[ ");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
}

int[,,] numbers = new int[2, 3, 4];
Fill3DArrayRandomNumbers(numbers);
PrintArray(numbers);

/*
int[] mass = new int[5];
FillArrayRandomNumbers(mass);
PrintArray(mass);

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        for (int j = 0; j < i; j++)
        {
            while (array[i] == array [j])
            FillArrayRandomNumbers(array);
        }
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine("");
}
*/