using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    public void TestPriorityQueue_1()
    {
        // Test: Highest priority item is removed first
        // Expected Result: Tim → Sue → Bob
        // Actual Result: Test passed successfully

        var pq = new PriorityQueue();

        pq.Enqueue("Bob", 1);
        pq.Enqueue("Tim", 3);
        pq.Enqueue("Sue", 2);

        Assert.AreEqual("Tim", pq.Dequeue());
        Assert.AreEqual("Sue", pq.Dequeue());
        Assert.AreEqual("Bob", pq.Dequeue());
    }

    [TestMethod]
    public void TestPriorityQueue_2()
    {
        // Test: Same priority follows FIFO order
        // Expected Result: Bob → Tim → Sue
        // Actual Result: Test passed successfully

        var pq = new PriorityQueue();

        pq.Enqueue("Bob", 2);
        pq.Enqueue("Tim", 2);
        pq.Enqueue("Sue", 2);

        Assert.AreEqual("Bob", pq.Dequeue());
        Assert.AreEqual("Tim", pq.Dequeue());
        Assert.AreEqual("Sue", pq.Dequeue());
    }
}