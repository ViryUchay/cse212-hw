using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]   // ✅ class wrapper
public class PriorityQueueTests
{
    [TestMethod]
    public void TestPriorityQueue_1()
    {
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
        var pq = new PriorityQueue();

        pq.Enqueue("Bob", 2);
        pq.Enqueue("Tim", 2);
        pq.Enqueue("Sue", 2);

        Assert.AreEqual("Bob", pq.Dequeue());
        Assert.AreEqual("Tim", pq.Dequeue());
        Assert.AreEqual("Sue", pq.Dequeue());
    }
}