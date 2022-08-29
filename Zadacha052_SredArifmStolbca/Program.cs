Console.Clear();
void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    Console.WriteLine("Имеем массив: ");
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
string ArithmeticMean(int[,] array)
{
    Console.WriteLine("Среднее арифметическое для каждого столбца: ");
    string result = string.Empty;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        double sum = 0;
        double count = 0;
        double mean = 0;
        for (int m = 0; m < array.GetLength(0); m++)
        {
            sum += array[m, n];
            count++;
        }
        mean = sum / count;
        result += mean.ToString() + "; ";
    }
    return result;
}
int m = 4;
int n = 4;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(array));