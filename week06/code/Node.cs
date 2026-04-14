using System;
using System.Collections.Generic;

public class Node
{
    public int Data { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }

    // Problem 1: Insert Unique Values Only
    public void Insert(int value)
    {
        if (value == Data)
        {
            // Prevent duplicates
            return;
        }
        else if (value < Data)
        {
            if (Left == null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else // value > Data
        {
            if (Right == null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    // Problem 2: Contains
    public bool Contains(int value)
    {
        if (value == Data)
            return true;

        if (value < Data)
            return Left != null && Left.Contains(value);
        else
            return Right != null && Right.Contains(value);
    }

    // Problem 3: Traverse Backwards
    public void TraverseBackward(List<int> values)
    {
        // Traverse the right subtree first (largest values)
        if (Right != null)
        {
            Right.TraverseBackward(values);
        }

        // Visit the current node
        values.Add(Data);

        // Traverse the left subtree
        if (Left != null)
        {
            Left.TraverseBackward(values);
        }
    }

    // Problem 4: Tree Height
    public int GetHeight()
    {
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}