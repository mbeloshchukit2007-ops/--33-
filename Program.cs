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
}
