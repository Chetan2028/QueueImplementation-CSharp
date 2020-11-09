using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueImplementation;

namespace QueueMSTest
{
    [TestClass]
    public class QueueUnitTest
    {
        /// <summary>
        /// Checks the element added to queue happy case.
        /// </summary>
        [TestMethod]
        public void CheckElementAddedToQueue_HappyCase()
        {
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(10);
            linkedListQueue.Enqueue(20);
            linkedListQueue.Enqueue(30);

            int expectedResult1 = 10;
            int expectedResult2 = 20;
            Assert.AreEqual(expectedResult1, linkedListQueue.front.data);
            Assert.AreEqual(expectedResult2, linkedListQueue.front.next.data);
        }
        /// <summary>
        /// Checks the element added to queue sad case.
        /// </summary>
        [TestMethod]
        public void CheckElementAddedToQueue_SadCase()
        {
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(10);
            linkedListQueue.Enqueue(20);
            linkedListQueue.Enqueue(30);

            int expectedResult1 = 30;
            int expectedResult2 = 10;
            Assert.AreNotEqual(expectedResult1, linkedListQueue.front.data);
            Assert.AreNotEqual(expectedResult2, linkedListQueue.front.next.data);
        } 
    }
}
