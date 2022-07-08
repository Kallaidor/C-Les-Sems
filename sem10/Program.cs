/*
Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

/*
int Input(string output)
{
Console.Write(output);
return Convert.ToInt32(Console.ReadLine());
}

int x = Input("введите Х: ");
int y = Input("введите y: ");
int n = Input("введите количество чисел: ");

for (int i = 1; i <= n; i++)
{
Console.Write($"{NaturalNumber(x, y, i)} ");

}


int NaturalNumber(int x, int y, int n)
{
if (n == 1)
return x;
if (n == 2)
return y;
else
{
return NaturalNumber(x, y, n - 1) + NaturalNumber(x, y, n - 2);
}
}
*/
/*
int first = 3;
int second = 4;
int countNum = 5;
Console.WriteLine(Fib(first,second,countNum));

string Fib(int first, int second, int countNum)
{
if(countNum == 0)
{
return string.Empty;
}
else
{
return first + " " + Fib (second, first + second, —countNum);
}
}
*/

/*
Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
ав, ва, ви, ив, св, вс
*/
/*
string charsWords = "аисв";
int countCharsInWords = 3;
PrintAllWords(charsWords,countCharsInWords,"");

void PrintAllWords(string alphabet, int length, string prefix)
{
if (length == 0)
{
Console.Write(prefix + " ");
}
else
{
for (int i = 0; i < alphabet.Length; i++)
{
PrintAllWords(alphabet,length-1,prefix + alphabet[i]);
}
}
}
*/
/*
string alphabet = "аисв";
int n = 2;

void FindWords(string alph, char[] word, int length = 0)
{
if (length == word.Length)
{
Console.Write(new String(word)+ " ");
}
else
{
for (int i = 0; i < alph.Length; i++)
{
word[length] = alph[i];
FindWords(alph, word, length + 1);
}
}
}

FindWords(alphabet, new char[n]);
*/
/*
Задача 72: Заданы 2 массива: info и data.
В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1
*/

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int dec = 0;
int index = 0;
PrintArray(data);
Console.WriteLine();
PrintArray(info);
Console.WriteLine();

for (int i = 0; i < info.Length; i++)
{
    dec = 0;
    for (int j = 0; j < info[i]; j++)
    {
        dec += Convert.ToInt32(Math.Pow(2, j)) * data[index + info[i] - j - 1];
    }
    index = index + info[i];
    Console.Write($"{dec} ");
}


/*
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int[] decimalNumbers = GetNumbersFromDataInfo(data, info);

Console.Write("data = ");
PrintArray(data);

Console.Write("info = ");
PrintArray(info);

Console.Write("result = ");
PrintArray(decimalNumbers);


int GetDecimal(int[] bits, int minIdx, int maxIdx)
{
int number = 0;
for (int i = minIdx; i < maxIdx + 1; i++)
{
number += bits[i] * (int)Math.Pow(2, maxIdx - i);
}
return number;
}

int[] GetNumbersFromDataInfo(int[] bits, int[] sizes)
{
int[] numbers = new int[sizes.Length];

int startIdx = 0;
int endIdx = -1;
for (int i = 0; i < numbers.Length; i++)
{
startIdx = endIdx + 1;
endIdx = endIdx + sizes[i];
int number = GetDecimal(bits, startIdx, endIdx);
numbers[i] = number;
}

return numbers;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

*/
