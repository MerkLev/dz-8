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
int[] SumColumns= new int [Matrix.GetLength(0)];
void SumNumbers(int[,]Matrix)
{
  int sum=0;
  for (int i = 0; i < Matrix.GetLength(0); i++)
  {
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
      sum=sum+Matrix[i,j];
    }
    SumColumns[i]=sum;
    sum=0;
  }
  Console.WriteLine("Суммы элементов каждой строки: ");
  Console.WriteLine(string.Join(", ", SumColumns));
}

void MinSumNumbers(int []Summer)
{
  int MinSum=Summer[0];
  int Index=0;
    for (int i = 1; i < Matrix.GetLength(0); i++)
    {
      if(MinSum>Summer[i])
      {
          MinSum=Summer[i];
          Index=i;
      }
    }
    Console.Write("Строка с минимальной суммой элементов:   ");
    Console.WriteLine(Index);
    Console.Write("Минимальная сумма элементов строки:   ");
    Console.WriteLine(MinSum);
    
}
Console.WriteLine("Матрица: ");

GetMatrix(rows,columns);
PrintMatrix(Matrix);
Console.WriteLine();
SumNumbers(Matrix);
MinSumNumbers(SumColumns);