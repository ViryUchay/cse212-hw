using System;
using System.Collections.Generic;

public class TakingTurnsQueue
{
    private Queue<Person> queue = new Queue<Person>();

    public int Length => queue.Count;

    public void AddPerson(string name, int turns)
    {
        queue.Enqueue(new Person(name, turns));
    }

    public Person GetNextPerson()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("No one in the queue.");
        }

        // Get next person
        Person current = queue.Dequeue();

        // If infinite turns (<= 0), re-add without changing turns
        if (current.Turns <= 0)
        {
            queue.Enqueue(current);
        }
        else
        {
            // Decrement turns
            current.Turns--;

            // Re-add only if turns remain
            if (current.Turns > 0)
            {
                queue.Enqueue(current);
            }
        }

        return current;
    }
}