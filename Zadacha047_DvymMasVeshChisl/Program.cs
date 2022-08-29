Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
double[,] array = new double [m, n];
FillArray(array);
PrintArray(array);
void FillArray(double[,] array)                                          
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
}

void PrintArray(double[,] array)
{
Console.WriteLine($"Полученный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}