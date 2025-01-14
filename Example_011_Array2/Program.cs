//index array  0  1  2   3  4   5  6   7   8  9
int[] array = {1, 5, 56, 8, 13, 5, 21, 17, 9, 10};

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // останавливает поиск, когда эл-т найден (например если одинаковых эл-тов 2)
    }
    index ++; //index += 1; index = index + 1;
}