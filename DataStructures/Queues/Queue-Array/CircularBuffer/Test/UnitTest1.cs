using NUnit.Framework;
using CircularBuffer;

namespace Test
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
            CBuffer Q = new CBuffer(2);
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
            CBuffer Q = new CBuffer(2);
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

        [Test]
        public void BorderTest()
        {
            CBuffer Q = new CBuffer(2);
            Q.Queue(10);
            Q.Queue(20);
            Q.DeQueue();
            Q.Queue(30);

            if (Q.QtdElem() != 2)
            {
                Assert.Fail();
            }
            else if (Q.FirsEle() != 20)
            {
                Assert.Fail();
            }
            else { Assert.Pass(); }
        }

        [Test]
        public void BorderTestII()
        {
            CBuffer Q = new CBuffer(10);
            Q.Queue(10);
            Q.Queue(20);
            Q.Queue(30);
            Q.Queue(40);
            Q.Queue(50);
            Q.Queue(60);
            Q.Queue(70);
            Q.Queue(80);
            Q.Queue(90);
            Q.Queue(100);
            Q.DeQueue();
            Q.DeQueue();
            Q.DeQueue();
            Q.DeQueue();
            Q.Queue(110);

            if (Q.DeQueue() != 50)
            {
                Assert.Fail();
            }
            else { Assert.Pass(); }
        }
    }
}