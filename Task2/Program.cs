// Создать двухмерный массив, состоящий из целых чисел.
// Вывести на экран "интересные" элементы массива.
// "Интересные" элементы - числа, сумма цифр которых четная.

int[,] CreateMatrix(int rowCount, int columsCount) // Функция создания массива
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix) // Функция вывода массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 5); // Точка входа в программу, создание массива
ShowMatrix(matrix); // Вывод массива на экран

foreach (int e in matrix) // Проход по массиву
{
    if (IsInteresting(e) == true) // Если элемент массива "интересный"
    {
        Console.WriteLine(e); // вывод его на экран
    }
}

bool IsInteresting(int value) // Функция определения "интересного" элементв
{
    int SumOfDigits = GetSumOfDigits(value);
    if (SumOfDigits % 2 == 0) // если сумма цифр числа четная
    {
        return true;
    }
    else
    {
        return false;
    }
}

int GetSumOfDigits (int value) // Функция вычисления суммы цифр числа
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}
