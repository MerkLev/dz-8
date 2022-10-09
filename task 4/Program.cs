Console.WriteLine("Введите размер массива X x Y x Z:");
int x= Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] Matrix3D = new int[x, y, z];
GetMatrix(Matrix3D);
PrintMatrix(Matrix3D);

void PrintMatrix (int[,,] Matrix3D)
{
  for (int i = 0; i < Matrix3D.GetLength(0); i++)
  {
    for (int j = 0; j < Matrix3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < Matrix3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={Matrix3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void GetMatrix(int[,,] Matrix3D)
{
  int[] temp = new int[Matrix3D.GetLength(0) * Matrix3D.GetLength(1) * Matrix3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < Matrix3D.GetLength(0); x++)
  {
    for (int y = 0; y < Matrix3D.GetLength(1); y++)
    {
      for (int z = 0; z < Matrix3D.GetLength(2); z++)
      {
        Matrix3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
