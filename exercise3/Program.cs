// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int[,] matrix) // Функция создания и заполнения двумерного массива случайными числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 8);
        }
    }
    return matrix;
}

void SearchAvg(int[,] matrix) // Функция расчета и вывода ср. арифметического каждого столба в массиве
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        Console.Write(Math.Round(sum / matrix.GetLength(0), 1) + "\t");
    }
}

void PrintArray(int[,] matrix) // Функция печати массива
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}]\t");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[4, 10];
FillArray(matrix);
PrintArray(matrix);
SearchAvg(matrix);