/* Задача 50: Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение
 этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9 */
void CreateArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void print2DArray(double[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    const int startIndex = 49;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{((char)i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + (i + 1) + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(Math.Round(arrayToPrint[i, j], 1) + "\t");
        }
        Console.WriteLine();
    }
}
int[] ParserString(string input)
{
    int countNumbers = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            countNumbers++;
    }

    int[] numbers = new int[countNumbers];

    int numberIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string subString = String.Empty;

        while (input[i] != ',')
        {
            subString += input[i].ToString();
            if (i >= input.Length - 1)
                break;
            i++;
        }
        numbers[numberIndex] = Convert.ToInt32(subString);
        numberIndex++;
    }

    return numbers;
}

string RemovingSpaces(string input)
{
    string output = String.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ')
        {
            output += input[i];
        }
    }
    return output;
}

Console.Clear();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы задали двумерный массив размером {m}*{n}.");
double[,] array = new double[m, n];
CreateArray(array);
print2DArray(array);
Console.WriteLine();
Console.WriteLine("Введите координаты сначала строки, затем столбца, разделяя запятой. ");
Console.Write("Координаты указаны в квадратных скобках: ");
string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if (position[0] <= m && position[1] <= n && position[0] >= 0 && position[1] >= 0)
{
    double result = array[position[0] - 1, position[1] - 1];
    Console.Write($"Значение элемента: {result}");
}
else
    Console.Write($"такого элемента в массиве нет.");
