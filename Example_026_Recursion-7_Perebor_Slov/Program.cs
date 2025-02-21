// Перебор слов

char[] s = { 'а', 'и', 'с','в'};

int count = s.Length;

/*
// Итеративный метод

// Слова состоящие из 1 буквы
int n = 1;
for (int i = 0; i < count; i++)
{
 Console.WriteLine($"{n++,-5}{s[i]}");
}

// Слова состоящие из 2 букв
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
    }
}

// Слова состоящие из 3 слов
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
        Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}");
        }
    }
}

// Слова состоящие из 4 слов
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
            }
        }
    }
}

// Слова состоящие из 5 слов
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
                }
            }
        }
    }
}
*/

// Рекурсивный метод

int n=1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);
// FindWords("аисв", new char[3]);
// FindWords("аисв", new char[4]);
// FindWords("аисв", new char[5]);