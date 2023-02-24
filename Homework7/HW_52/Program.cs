// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] AutoFillArr(out int str, out int col)
{
    System.Console.Write("Введите количество строк массива (m): ");
    str = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов массива (n); ");
    col = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[str, col];

    System.Console.Write("Введите начало диапазона генерации для автозаполнения; ");
    int first = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите конец диапазона генерации для автозаполнения; ");
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

void ArithmeticMeanCol(int[,] arr)
{
    for (int n = 0; n < arr.GetLength(1); n++) // когда сначала задаём n то он фиксирует столбец 
    {
        double sum = 0;
        for (int m = 0; m < arr.GetLength(0); m++) // а тут перемещается по строкам т.е. идет вниз вдоль столбца
        {
            sum = sum + arr[m, n];
        }
        Console.Write($"Среднее арифметическое {n} столбца равно {sum / arr.GetLength(0)} ");
        System.Console.WriteLine();
    }
}



int[,] array = AutoFillArr(out int str, out int col);
PrintArray(array);

System.Console.WriteLine();
ArithmeticMeanCol(array);