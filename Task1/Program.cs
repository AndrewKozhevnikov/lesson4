// Создать двумерный массив с размерами 3 x 5, состоящий из целых чисел.
// Вывести его элементы на экран.

// Функция по созданию двумерного массива.
int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

// Функция по выводу двумерного массива.
void ShowMatrix(int[,] matrix)
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

// Запуск функций.
int[,] matrix = CreateMatrix(3, 5);
ShowMatrix(matrix);
