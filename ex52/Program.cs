/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
 элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void print2DArray(int[,] arrayToPrint)
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
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы задали двумерный массив размером {m}*{n}.");
int[,] array = new int[m, n];
CreateArray(array);
print2DArray(array);
Console.WriteLine();
Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  double Average = 0;
  for (int j = 0; j < m; j++)
  {
    Average += array[j, i];
  }
  Average = Math.Round(Average / m, 2);
  Console.WriteLine($"{i+1}-го столбца:  {Average}");
}