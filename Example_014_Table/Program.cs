﻿// Таблица умножения через цикл for

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}"); // Вывод через интерполяцию строк
    }
    Console.WriteLine(); //cw
}