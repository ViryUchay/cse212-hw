using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number'
    /// followed by multiples of 'number'.
    /// Example: MultiplesOf(7, 5) => {7, 14, 21, 28, 35}
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.
    /// Example: {1,2,3,4,5,6,7,8,9} rotated by 3 becomes {7,8,9,1,2,3,4,5,6}
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        int splitIndex = data.Count - amount;

        List<int> endPart = data.GetRange(splitIndex, amount);
        List<int> startPart = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(endPart);
        data.AddRange(startPart);
    }
}