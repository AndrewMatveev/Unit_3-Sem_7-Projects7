// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            arr[m, n] = Math.Round(random, 1); // Округление
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
            System.Console.Write($"{arr[m, n]}\t");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
}


void ReturnPosValue(double[,] arr)
{
    System.Console.Write("Введите позицию элемента в массиве по шаблону [строка, столбец] \nВвод: ");
    int[] Pos = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            if (Pos[0] >= arr.GetLength(0) ||Pos[0] >= arr.GetLength(1)) Console.WriteLine("Такого элемента не существует");
            else Console.WriteLine($"Значение элемента массива равно {arr[Pos[0], Pos[1]]}");
            return;
        }
    }
}

double[,] array = AutoFillArr();
PrintArray(array);

ReturnPosValue(array);