// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result; // Возвращает результат
}

double[,] FillArray(int numLine, int numColumns) // Функция создания и заполнения двумерного массива случайными числами
{
    double[,] matrix = new double[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round (new Random().NextDouble() * new Random().Next(1, 8), 1);
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix) // Функция печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int numLine = Prompt("Введите количество строк массива ");
int numColumns = Prompt("Введите количество столбцов массива ");
double[,] matrix = FillArray(numLine, numColumns);
PrintArray(matrix);