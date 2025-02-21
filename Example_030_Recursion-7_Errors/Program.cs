decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
fRec++;
return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
fIte++;
decimal result = 1;
decimal f0 = 1;
decimal f1 = 1;
for (int i = 2; i <= n; i++)
{
result = f0 + f1;
f0 = f1;
f1 = result;
fIte++;
}
return result;
}
Console.ReadLine();
DateTime dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
Console.WriteLine($"FibonaccIteration{n})={FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
fIte = 0;
}

System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();

dt=DateTime.Now;

for (int n = 10; n < 40; n++)
{
Console.WriteLine($"FibonaccIteration{n})={FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

int[,] pic = new int[1000, 1000];
for (int i = 0; i < 1000; i++)
{
pic[0, i] = 1;
pic[i, 0] = 1;
pic[i, 999] = 1;
pic[999, i] = 1;
}

//PrintImage(pic);

FillImage(1,1);
Console.WriteLine();
//PrintImage(pic);

void PrintImage(int[,] image)
{
for (int i = 0; i < image.GetLength(0); i++)
{
for (int j = 0; j < image.GetLength(1); j++)
{
//Console.Write($"{image[i, j]} ");
if (image[i, j] == 0) Console.Write($" ");
else Console.Write($"+");

    }
    Console.WriteLine();
}
}

void FillImage(int row, int col)
{
if(pic[row,col]==0)
{
pic[row,col]=1;
FillImage(row-1, col); //вверх
FillImage(row, col-1); //влево
FillImage(row+1, col); //вниз
FillImage(row, col+1); //вправо
}
}