// void Rec()
// {
//     Rec();
// }

// Rec();

int i = 0;
void Rec()
{
    Console.WriteLine(i++);
    Rec();
}

Rec();