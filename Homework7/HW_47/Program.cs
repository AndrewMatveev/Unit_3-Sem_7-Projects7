// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] AutoFillArr()
{
    System.Console.Write("Введите количество строк массива (m): ");
    int str = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов массива (n): ");
    int col = Convert.ToInt32(Console.ReadLine());

    double[,] arr = new double[str, col];


    System.Console.Write("Введите начало диапазона генерации для автозаполнения: ");
    double first = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите конец диапазона генерации для автозаполнения: ");
    double last = Convert.ToInt32(Console.ReadLine());



    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {

            var random = new Random().NextDouble() * (last - first) + first; // рекомендуемый метод генерации чисел с плавающей точкой в выбранном диапазоне
            arr[m, n] = Math.Round(random, 3); // Округление
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