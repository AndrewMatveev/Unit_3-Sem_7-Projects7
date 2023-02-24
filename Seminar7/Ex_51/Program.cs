// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


double[,] AutoFillArr()
{
    System.Console.WriteLine("Введите количество строк массива (m)");
    int str = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов массива (n)");
    int col = Convert.ToInt32(Console.ReadLine());

    double[,] arr = new double[str, col];


    System.Console.WriteLine("Введите начало диапазона генерации для автозаполнения");
    int first = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите конец диапазона генерации для автозаполнения");
    int last = Convert.ToInt32(Console.ReadLine());



    for (int m = 0; m < arr.GetLength(0); m++)
    {

        for (int n = 0; n < arr.GetLength(1); n++)
        {
            arr[m, n] = new Random().Next(first, last + 1);
        }
    }
    return arr;
}

double[,] PowEnumIndex(double[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            if (m % 2 == 0 && n % 2 == 0) arr[m, n] = Math.Pow(arr[m, n], 2);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
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


double[,] array = AutoFillArr();
PrintArray(array);
System.Console.WriteLine();

double[,] arrayPow = PowEnumIndex(array);
PrintArray(arrayPow);