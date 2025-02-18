﻿// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double f(int n)
{
    if (n == 1 || n == 2) return 1;
    else return f(n-1) + f(n-2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i}) = {f(i)}");   
}

