namespace PraktichnaMax;

public static class ArrayHelper
{
    public static void PrintArray<T>(T[] array)
    {
        Console.WriteLine("Масив: " + string.Join(" ", array));
    }

    public static int IndexOf<T>(T[] array, T value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != null && array[i]!.Equals(value))
            {
                return i;
            }
        }
        return -1;
    }

    public static T Min<T>(T[] array) where T : IComparable<T>
    {
        T min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(min) < 0)
            {
                min = array[i];
            }
        }
        return min;
    }

    public static T Max<T>(T[] array) where T : IComparable<T>
    {
        T max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(max) > 0)
            {
                max = array[i];
            }
        }
        return max;
    }

    public static T[] Reverse<T>(T[] array)
    {
        T[] res = (T[])array.Clone();
        int left = 0;
        int right = res.Length - 1;
        while (left < right)
        {
            T tmp = res[left];
            res[left] = res[right];
            res[right] = tmp;
            left++;
            right--;
        }
        return res;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--- Тест з int ---");
        int[] nums = { 15, 3, 89, 4, 12, 0 };
        ArrayHelper.PrintArray(nums);
        Console.WriteLine($"Індекс 89: {ArrayHelper.IndexOf(nums, 89)}");
        Console.WriteLine($"Мінімум: {ArrayHelper.Min(nums)}");
        Console.WriteLine($"Максимум: {ArrayHelper.Max(nums)}");
        Console.WriteLine($"Перевернутий: {string.Join(" ", ArrayHelper.Reverse(nums))}");

        Console.WriteLine();

        Console.WriteLine("--- Тест з string ---");
        string[] names = { "Олег", "Андрій", "Юля", "Богдан" };
        ArrayHelper.PrintArray(names);
        Console.WriteLine($"Індекс Юля: {ArrayHelper.IndexOf(names, "Юля")}");
        Console.WriteLine($"Перше за алфавітом: {ArrayHelper.Min(names)}");
        Console.WriteLine($"Останнє за алфавітом: {ArrayHelper.Max(names)}");
        Console.WriteLine($"Перевернутий: {string.Join(" ", ArrayHelper.Reverse(names))}");

        Console.WriteLine();
        Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
    }
}
