// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

// void SumDiaEl(int[,] arr) // вариант 1
// {
//     int sum = 0;
//     for (int m = 0; m < arr.GetLength(0); m++) // строки
//     {
//         for (int n = 0; n < arr.GetLength(1); n++) // столбцы
//         {
//             if (m == n) sum += arr[m, n];
//         }
//     }
//     System.Console.WriteLine(sum);;
// }

// void SumDiaEl(int[,] arr) // вариант 2
// {
//     int sum = 0;
//     int lenght;
//     if (arr.GetLength(0) > arr.GetLength(1)) lenght = arr.GetLength(1);
//     else if (arr.GetLength(0) < arr.GetLength(1)) lenght = arr.GetLength(0);
//     else lenght = arr.GetLength(1);
//     for (int i = 0; i < lenght; i++)
//     {
//         sum += arr[i, i];
//     }
//     System.Console.WriteLine(sum); ;
// }


void SumDiaEl(int[,] arr) // вариант 3
{
    int sum = 0;
    int lenght = (arr.GetLength(0) > arr.GetLength(1))? arr.GetLength(1): arr.GetLength(0); // тернарный оператор



    for (int i = 0; i < lenght; i++)
    {
        sum += arr[i, i];
    }
    System.Console.WriteLine(sum); ;
}

System.Console.Clear();
int[,] array = AutoFillArr(out int str, out int col);
PrintArray(array);
System.Console.WriteLine();
SumDiaEl(array);