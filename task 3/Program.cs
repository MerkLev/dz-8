Console.WriteLine("Задайте размер массива");
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix= new int [m,n];
int[,] secondMatrix = new int [n,p];
int[,] resultMatrix = new int[m,p];


void GetMatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(10);
    }
  }
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

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

GetMatrix(firstMatrix);
Console.WriteLine($" Первая матрица:");
PrintMatrix(firstMatrix);

GetMatrix(secondMatrix);
Console.WriteLine($" Вторая матрица:");
PrintMatrix(secondMatrix);

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($" Результат умножения:");
PrintMatrix(resultMatrix);