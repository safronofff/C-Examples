/*
string[,] table = new string[2, 5];
// String.Empty
// table[0,0] table[0,1] table[0,2] ... table[0,4]
// table[1,0] table[1,1] table[1,2] ... table[1,4]

table[1,2] = "text";

for (int rows = 0; rows < 2; rows++)
{
    for (int coloms = 0; coloms < 5; coloms++)
    {
        Console.WriteLine($"+{table[rows, coloms]}+");
    }
}
*/

/*
int[,] matrix = new int[3,4];

for (int rows = 0; rows < 3; rows++)
{
    for (int coloms = 0; coloms < 4; coloms++)
    {
        Console.Write($"{matrix[rows, coloms]} ");
    }
    Console.WriteLine();
}
*/

/*
int[,] matrix = new int[4,5];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
*/

void PrintArray(int[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[4,5];

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);