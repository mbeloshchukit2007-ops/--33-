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
