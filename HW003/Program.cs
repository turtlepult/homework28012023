// Написать программу копирования массива
int r = new Random().Next(2,6);
int l = new Random().Next(2,6);
int[,] matrix = new int[r,l];

for (int i = 0; i < matrix.GetLength(0); i++) //заполняем матрицу
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }
}
for (int i = 0; i < matrix.GetLength(0); i++) // печатаем матрицу
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j]+ "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] copymatrix =new int[matrix.GetLength(0), matrix.GetLength(1)];
for (int i = 0; i < copymatrix.GetLength(0); i++)
{
    for (int j = 0; j < copymatrix.GetLength(1); j++)
    {
        copymatrix[i,j] = matrix[i,j];
    }
}

for (int i = 0; i < copymatrix.GetLength(0); i++) 
{
    for (int j = 0; j < copymatrix.GetLength(1); j++)
    {
        Console.Write(copymatrix[i,j]+ "\t");
    }
    Console.WriteLine();
}
