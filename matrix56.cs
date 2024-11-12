public class SwapMatrixHalves
{
    public static void Main(string[] args)
    {
        // Ввод размерности матрицы
        Console.Write("Введите количество строк (M): ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов (N, четное число): ");
        int N = int.Parse(Console.ReadLine());

        // Проверка на четность столбцов
        if (N % 2 != 0)
        {
            Console.WriteLine("Количество столбцов должно быть четным!");
            return;
        }

        // Создание матрицы
        int[,] matrix = new int[M, N];

        // Заполнение матрицы
        Console.WriteLine("Введите элементы матрицы:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Обмен левой и правой половины матрицы
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N / 2; j++)
            {
                // Временная переменная для хранения значения
                int temp = matrix[i, j];
                // Обмен значений
                matrix[i, j] = matrix[i, j + N / 2];
                matrix[i, j + N / 2] = temp;
            }
        }

        // Вывод измененной матрицы
        Console.WriteLine("Измененная матрица:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
