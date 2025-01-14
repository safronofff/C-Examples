//индексы эл. 0   1   2   3  4  5   6  7   8
int[]array = {12, 25, 2, 5, 1, 33, 73, 99, 42};

array[0] = 4;  // присваевание иного значение одному эл-ту массива
Console.WriteLine(array[0]);

int Max (int arg1, int arg2, int arg3)  // метод (функция)
{
    int result = arg1;
    if (arg2 > arg1) result = arg2;
    if (arg3 > arg1) result = arg3;
    return result;
}

int max = Max( 
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    );
Console.WriteLine(max);