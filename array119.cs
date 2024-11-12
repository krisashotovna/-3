public class Program
{
    public static void Main(string[] args)
    {
        // Пример массива
        int[] arr = { 1, 1, 2, 2, 2, 3, 3, 4, 5, 5, 5, 6, 6 };

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        PrintArray(arr);

        // Преобразование массива
        ExtendSeries(arr);

        // Вывод преобразованного массива
        Console.WriteLine("\nПреобразованный массив:");
        PrintArray(arr);
    }

    // Функция для расширения серий в массиве
    public static void ExtendSeries(int[] arr)
    {
        if (arr.Length == 0)
        {
            return;
        }

        int currentElement = arr[0];
        int seriesLength = 1;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == currentElement)
            {
                seriesLength++;
            }
            else
            {
                // Добавляем новый элемент в конец серии
                if (seriesLength > 1)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    for (int j = arr.Length - 1; j > i; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[i] = currentElement;
                    i++; // Переходим к следующему элементу
                }

                currentElement = arr[i];
                seriesLength = 1;
            }
        }

        // Добавляем новый элемент в конец последней серии
        if (seriesLength > 1)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = currentElement;
        }
    }

    // Функция для вывода массива на экран
    public static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
