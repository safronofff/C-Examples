// метод для заполнения массива рангдомными числами
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// метод, который будет печатать массив
void PrintArray(int[] col)
{
    int count = col. Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// метод, который будет искать элемент в массиве
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если искомыл эл-т отсутствует, то будет выводится не 0, а -1
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;  // останаовливаем цикл, как искомый эл-т обнаружер
        }
        index++;
    }
    return position;
}

// конструкция по созданию массива на 10 эл-тов, которая по умолчанию заполнена 0-ми.
int[] array = new int[10]; 

FillArray(array);
array[4] = 4;  //создаем искусственно эл-ты в массиве
array[6] = 4;  //создаем искусственно эл-ты в массиве
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);