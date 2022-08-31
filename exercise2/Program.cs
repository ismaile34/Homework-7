// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result; // Возвращает результат
}

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

void SearchElement(int[,] matrix, int LinePosition, int ColumnPosition) // Функция поиска и вывода элемента в массиве
{

    if (LinePosition < matrix.GetLength(0) && ColumnPosition < matrix.GetLength(1))
    {
        System.Console.WriteLine($"Значение элемента по заданной позиции = {matrix[LinePosition, ColumnPosition]}");
    }
    else
    {
        System.Console.WriteLine("Такого элемента нет");
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
int[,] matrix = new int[3, 4];
int LinePosition = Prompt("Введите номер строки массива > ");
int ColumnPosition = Prompt("Введите столбца массива > ");
FillArray(matrix);
PrintArray(matrix);
SearchElement(matrix, LinePosition, ColumnPosition);