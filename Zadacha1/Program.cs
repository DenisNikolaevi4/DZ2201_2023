// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] CreateArray()
{
    Console.WriteLine("Введите количество элементтов массива: ");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] massive = new int[count];

    for (int i = 0; i < massive.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число: ");
        massive[i] = Convert.ToInt32(Console.ReadLine());
    }
    return massive;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

int CountPozitive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            count++;
    return count;
}

int[] array = CreateArray();
PrintArray(array);
Console.WriteLine($"Количество чисел больше нуля = {CountPozitive(array)}");





