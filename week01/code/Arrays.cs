public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return []; public static class Arrays
    {
        /// <summary>
        /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
        /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
        /// </summary>
        public static double[] MultiplesOf(double number, int length)
        {
            // Step 1: Create a new array of type double with a size equal to length.
            // This array will store the multiples of the given number.

            double[] result = new double[length];

            // Step 2: Use a loop that runs from index 0 up to length - 1.

            for (int i = 0; i < length; i++)
            {
                // Step 3: For each position in the array, calculate the multiple.
                // Since the first multiple should be number * 1,
                // we multiply number by (i + 1).

                result[i] = number * (i + 1);
            }

            // Step 4: Return the completed array containing the multiples.

            return result;
        }

        /// <summary>
        /// Rotate the 'data' to the right by the 'amount'.
        /// Example: {1,2,3,4,5,6,7,8,9} rotated by 3 becomes {7,8,9,1,2,3,4,5,6}
        /// </summary>
        public static void RotateListRight(List<int> data, int amount)
        {
            // Step 1: Determine where the list should be split.
            // This will be the total number of elements minus the rotation amount.

            int splitIndex = data.Count - amount;

            // Step 2: Get the last "amount" elements that will move to the front.

            List<int> endPart = data.GetRange(splitIndex, amount);

            // Step 3: Get the remaining elements from the start of the list.

            List<int> startPart = data.GetRange(0, splitIndex);

            // Step 4: Clear the original list so we can rebuild it.

            data.Clear();

            // Step 5: Add the elements that moved to the front.

            data.AddRange(endPart);

            // Step 6: Add the remaining elements after them.

            data.AddRange(startPart);
        }
    }
}

/// <summary>
/// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
/// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
/// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
///
/// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
/// </summary>
/// 

{public static void RotateListRight(List<int> data, int amount)
{
    // TODO Problem 2 Start
    // Remember: Using comments in your program, write down your process for solving this problem
    // step by step before you write the code. The plan should be clear enough that it could
    // be implemented by another person.
}
}
public static void RotateListRight(List<int> data, int amount)
{
    // Step 1: Determine the index where the list should be split.
    // This is calculated by subtracting the rotation amount from the total number of elements.
    int splitIndex = data.Count - amount;

    // Step 2: Get the portion of the list from the split index to the end.
    // These are the elements that will move to the front after rotation.
    List<int> endPart = data.GetRange(splitIndex, amount);

    // Step 3: Get the portion of the list from the start up to the split index.
    // These elements will move to the end of the list after rotation.
    List<int> startPart = data.GetRange(0, splitIndex);

    // Step 4: Clear the original list so we can rebuild it in the new rotated order.
    data.Clear();

    // Step 5: Add the elements that moved to the front.
    data.AddRange(endPart);

    // Step 6: Add the remaining elements after them.
    data.AddRange(startPart);
}