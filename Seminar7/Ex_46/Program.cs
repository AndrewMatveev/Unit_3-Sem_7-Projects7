// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] AutoFillArr()
{
    System.Console.WriteLine("Введите количество строк массива (m)");
    int str = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов массива (n)");
    int col = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[str, col];

    System.Console.WriteLine("Введите начало диапазона генерации для автозаполнения");
    int first = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите конец диапазона генерации для автозаполнения");
    int last = Convert.ToInt32(Console.ReadLine());


    for (int m = 0; m < arr.GetLength(0); m++)
    {

        for (int n = 0; n < arr.GetLength(1); n++)
        {
            arr[m,n] = new Random().Next(first, last + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++) // строки
    {
        for (int n = 0; n < arr.GetLength(1); n++) // столбцы
        {
            System.Console.Write($"{arr[m, n]} ");
        }
        System.Console.WriteLine();
    }
}


int[,] array = AutoFillArr();
PrintArray(array);