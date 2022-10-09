Console.WriteLine("Задайте размер массива");
Console.WriteLine("Введите количество строк");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns=Convert.ToInt32(Console.ReadLine());
int  [,] Matrix= new int [rows,columns];

int [,] GetMatrix(int rows, int columns)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int k = 0; k < Matrix.GetLength(1); k++)
        {
            Matrix[i,k]= new Random().Next(10);
        }
    }
    return Matrix;
}
void PrintMatrix(int[,]Matrix)
{
     for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int M = 0; M < Matrix.GetLength(1); M++)
        {
            Console.Write(Matrix[i,M] + "\t");
        }
        Console.WriteLine();
    }
}
  void SortedMatrix(int[,] Matrix)
{
  for (int i = 0; i < Matrix.GetLength(0); i++)
  {
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
      for (int k = 0; k < Matrix.GetLength(1) - 1; k++)
      {
        if (Matrix[i, k] < Matrix[i, k + 1])
        {
          int temp = Matrix[i, k + 1];
          Matrix[i, k + 1] = Matrix[i, k];
          Matrix[i, k] = temp;
        }
      }
    }
  }
}

Console.WriteLine("Полученная матрица: ");
GetMatrix(rows,columns);
PrintMatrix(Matrix);
Console.WriteLine();
Console.WriteLine("Отсортированная матрица: ");
SortedMatrix(Matrix);
PrintMatrix(Matrix);

