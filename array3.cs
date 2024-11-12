public class ArithmeticProgression
{
    public static void Main(string[] args)
    {
        // Ввод данных
        Console.WriteLine("Введите N (количество членов прогрессии):");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите первый член A:");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите разность D:");
        int D = int.Parse(Console.ReadLine());

        // Проверка N
        if (N <= 1)
        {
            Console.WriteLine("N должно быть больше 1.");
            return;
        }

        // Создание и заполнение массива
        int[] progression = new int[N];
        for (int i = 0; i < N; i++)
        {
            progression[i] = A + i  D;
        }

        // Вывод массива
        Console.WriteLine("Арифметическая прогрессия:");
        foreach (int element in progression)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
