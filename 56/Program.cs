// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число: ");
int minRandom = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());


int[,] matrix = GetMatrix(rows, columns, minRandom, maxRandom);
PrintMatrix(matrix);

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


int minSumRow = 0;
int SumRow = SumRowElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = SumRowElements(matrix, i);
  if (SumRow > temp)
  {
    SumRow = temp;
    minSumRow = i;
  }
}

Console.WriteLine($"Строка с минимальной суммой элементом: {minSumRow + 1} элементов (сумма: {SumRow}) ");


int SumRowElements(int[,] matrix, int i)
{
  int SumRow = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    SumRow += matrix[i,j];
  }
  return SumRow;
}
