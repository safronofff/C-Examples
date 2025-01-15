// Виды методов

// Вид 1 - методы, которые не принимают и не возвращают аргументов

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }

// Method1(); // Вызов метода

//-------------------------------------------------------------------

// Вид 2 - методы, которые принемают и не возвращают аргументов

// void Method2(string arg)
// {
//     Console.WriteLine(arg);
// }

// Method2("Текст с ообщения");

//---

// void Method2_1(string arg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(arg);
//         i++; // инкремент
//     }
// }

// //Method2_1("Текст с ообщения", 4); // Вариант выхова метода - 1

// Method2_1(count: 5, arg: "Text mesege"); // Вариант вызова метода - 2. Аргументы можно вводить не по порядку.

//-------------------------------------------------------------------

// Вид 3 - методы, которые не принимают, но возвращают аргументы.

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine("Now is: " +year);

//-------------------------------------------------------------------

// Вид 4 - методы, которые принимают и  возвращают аргументы.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // Пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(5, "QWERTY");
Console.WriteLine(res);