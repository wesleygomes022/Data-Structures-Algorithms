using NUnit.Framework;
using CircularBuffer;
using System;

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

            Assert.AreEqual(Q.DeQueue(), 10);
            Assert.AreEqual(Q.DeQueue(), 20);

            Q.Queue(30);
            Q.Queue(40);
            Assert.AreEqual(Q.QtdElem(), 2);
        }

        [Test]
        public void TestQueueIsEmpty()
        {
            CBuffer Q = new CBuffer(2);
            Q.Queue(10);
            Q.Queue(20);
            Q.DeQueue();
            Q.DeQueue();

            Assert.AreEqual(Q.QtdElem(), 0);
        }

        [Test]
        public void BorderTest()
        {
            CBuffer Q = new CBuffer(2);
            Q.Queue(10);
            Q.Queue(20);
            Q.DeQueue();
            Q.Queue(30);

            Assert.AreEqual(Q.QtdElem(), 2);
            Assert.AreEqual(Q.FirsEle(), 20);            
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
            Q.Queue(120);

            Assert.AreEqual(Q.QtdElem(), 8);
            Assert.AreEqual(Q.DeQueue(), 50);           
        }

        [Test]
        public void FullQueue()
        {
            CBuffer q = new CBuffer(3);
            q.Queue(10);
            q.Queue(20);
            q.Queue(30);
            
            Assert.Throws<InvalidOperationException>(()=> q.Queue(40));
        }

        [Test]
        public void EmptyQueue()
        {
            CBuffer q = new CBuffer(10);

            Assert.Throws<InvalidOperationException>(() => q.DeQueue());        }
    }
}