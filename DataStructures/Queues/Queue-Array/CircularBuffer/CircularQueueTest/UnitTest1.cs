using BufferCircular;
using NUnit.Framework;

namespace CircularQueueTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestQueueUnQueue()
        {
            CircularQueue Q = new CircularQueue(2);
            Q.Queue(10);
            Q.Queue(20);

            if (Q.DeQueue() != 10)
            {
                Assert.Fail();
            }
            if (Q.DeQueue() != 20)
            {
                Assert.Fail();
            }

            Q.Queue(30);
            Q.Queue(40);
            if (Q.QtdElem() == 2)
                Assert.Pass();
            else
                Assert.Fail(); 
        }

        [Test]
        public void TestQueueIsEmpty()
        {
            CircularQueue Q = new CircularQueue(2);
            Q.Queue(10);
            Q.Queue(20);
            Q.DeQueue();
            Q.DeQueue();

            if (Q.QtdElem() == 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}