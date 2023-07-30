// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:


// Не получается вывести произведение

Console.WriteLine("Введите количество строк 1 матрицы: ");
int firstMatrixRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 1 матрицы: ");
int firstMatrixColumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число 1 матрицы: ");
int minRandomFirstMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число 1 матрицы: ");
int maxRandomFirstMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк 2 матрицы: ");
int secondMatrixRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 2 матрицы: ");
int secondMatrixColumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число 2 матрицы: ");
int minRandomSecondMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число 2 матрицы: ");
int maxRandomSecondMatrix = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = GetMatrix(firstMatrixRows, firstMatrixColumns, minRandomFirstMatrix, maxRandomFirstMatrix);
int[,] secondMatrix = GetMatrix(secondMatrixRows, secondMatrixColumns, minRandomSecondMatrix, maxRandomSecondMatrix);

if (firstMatrixColumns != secondMatrixRows)
{
    Console.WriteLine("Error");
    return;
}

PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();



int[,] firstMartrix = new int[firstMatrixRows, firstMatrixColumns];
int[,] secondMartrix = new int[secondMatrixRows, secondMatrixColumns];

int[,] resultMatrix = new int[firstMatrixRows, secondMatrixColumns];


int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i, k] * secondMartrix[k, j];
      }
      resultMatrix[i, j] = sum;
    }
  }
  return resultMatrix;
}


Console.WriteLine("Произведение первой и второй матриц: ");

PrintMatrix(MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix));







