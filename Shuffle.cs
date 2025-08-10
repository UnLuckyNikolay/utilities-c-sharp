namespace Utilities;

public class ShuffleUtilities
{
    /// <summary>
    /// Shuffles array in place. Uses Fisher–Yates algorithm.
    /// Complexity - O(n).
    /// </summary>
    public static void Shuffle<T>(T[] array)
    {
        Random rng = new();
        int n = array.Length;
        while (n > 1)
        {
            int k = rng.Next(n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }
}