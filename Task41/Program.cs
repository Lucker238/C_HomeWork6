// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] strToArr(string input)
{
    input = input.Replace(" ", string.Empty);
    string[] s = input.Split(",");
    int[] array = new int[s.Length];
    for (int i = 0; i <s.Length; i++)
    {
        array[i] = Convert.ToInt32(s[i]);   
    }
    return array;
}

int countPossitive(int[] input)
{
    int result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] > 0) result++;   
    }
    return result;
}

System.Console.Write("Введите числа: ");
System.Console.WriteLine($"Количество чисел больше 0 равно: {countPossitive(strToArr(Console.ReadLine()))}");