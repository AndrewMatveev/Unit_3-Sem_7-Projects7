// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// rows = 3, cols = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// // 

int[,] AutoFillArr()
{
    System.Console.WriteLine("Введите количество строк массива (m)");
    int str = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов массива (n)");
    int col = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[str, col];


    for (int m = 0; m < arr.GetLength(0); m++)
    {

        for (int n = 0; n < arr.GetLength(1); n++)
        {
            arr[m,n] = m+n;
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