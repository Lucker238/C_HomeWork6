// Написать метод поворота массива [N,N]

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);   
        }   
    }
    return result;
}

void ShowArray(int[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
       for (int j = 0; j < input.GetLength(1); j++)
       {
        System.Console.Write($"{input[i, j]} ");
       } 
    System.Console.WriteLine();
    }
}

int[,] turnArray(int[,] input)
{
    int[,] result = new int[input.GetLength(1), input.GetLength(0)];
    for (int i = 0; i < input.GetLength(1); i++)
    {
        for (int j = 0; j < input.GetLength(0); j++)
        {
            result[i, j] = input[input.GetLength(0)-1-j ,i];
        }
    }
    return result;
}

System.Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] array = FillArray(m, n);
ShowArray(array);
System.Console.WriteLine();
ShowArray(turnArray(array));