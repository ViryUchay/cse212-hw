using System.Collections.Generic;

public static class Trees
{
    /// <summary>
    /// Given a sorted array, create a balanced Binary Search Tree.
    /// </summary>
    public static BinarySearchTree CreateTreeFromSortedList(int[] sortedNumbers)
    {
        BinarySearchTree bst = new BinarySearchTree();

        if (sortedNumbers == null || sortedNumbers.Length == 0)
            return bst;

        InsertMiddle(sortedNumbers, 0, sortedNumbers.Length - 1, bst);
        return bst;
    }

    /// <summary>
    /// Inserts the middle element of the array (or subarray) into the BST
    /// recursively to ensure the tree remains balanced.
    /// </summary>
    private static void InsertMiddle(int[] sortedNumbers, int first, int last, BinarySearchTree bst)
    {
        if (first > last)
            return;

        int middle = (first + last) / 2;

        // Insert the middle value
        bst.Insert(sortedNumbers[middle]);

        // Recursively insert from the left half
        InsertMiddle(sortedNumbers, first, middle - 1, bst);

        // Recursively insert from the right half
        InsertMiddle(sortedNumbers, middle + 1, last, bst);
    }
}