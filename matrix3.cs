public class MatrixGenerator
{
    public static void Main(string[] args)
    {
        // Ввод данных
        Console.Write("Введите число M (количество чисел): ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите число N (количество столбцов): ");
        int N = int.Parse(Console.ReadLine());

        int[] numbers = new int[M];
        Console.WriteLine("Введите {0} чисел:", M);
        for (int i = 0; i < M; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Создание и заполнение матрицы
        int[,] matrix = new int[M, N];
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = numbers[i];
            }
        }

        // Вывод матрицы
        Console.WriteLine("Сформированная матрица:");
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