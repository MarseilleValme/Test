string[] array = { "1234", "167", "-2", "computer science" };
int array3size = 0, count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
        array3size++;
string[] array3 = new string[array3size];
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
    {
        array3[count] = array[i]; count++;
    }
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}] → Новый массив: [{string.Join(", ", array3)}]");