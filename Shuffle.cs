namespace Utilities;

public class Shuffle
{
    /// <summary>
    /// Shuffles array in place. 
    /// Complexity - O(n).
    /// </summary>
    public static void Fisher_Yates<T>(T[] array)
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