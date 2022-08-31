/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();
Console.WriteLine("ввести количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввести количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
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




/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)
int[,] array = ArrayGenerator.GetArray(4,5,10);
*/

Write("Номер строки: ");
int row = int.Parse(ReadLine());
Write("Номер столбца: ");
int column = int.Parse(ReadLine());

ArrayWriter.Write(array);
if(row < 0 || row >= array.GetLength(0)) {
    WriteLine($"{row}, {column} -> такой позиции в массиве нет");
    return;
}
if(column < 0 || column >= array.GetLength(1)) {
    WriteLine($"{row}, {column} -> такой позиции в массиве нет");
    return;
}

WriteLine($"{row}, {column} -> {array[row,column]}");



/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] randomArray = GetFillArray(3, 4);
PrintArray(randomArray);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");
FindAverage(randomArray);

int[,] GetFillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindAverage(int[,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        average = Math.Round(average / array.GetLength(0), 1, MidpointRounding.ToZero);
        Console.Write($"{average}; ");
        average = 0;
    }
}
