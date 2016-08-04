using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircularBufferRealization;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace TestTaskUnitTests
{
    [TestClass]
    public class QueueTests
    {
        //Testing the circular queue
        [TestMethod]
        public void AddToTheQueue10ElementsTest()
        {
            ThreadSafeCircularQueue ManagedQueue = new ThreadSafeCircularQueue(20);
            for (int i = 0; i < 10; i++)
            {
                ManagedQueue.Add(i);
            }
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(i, ManagedQueue.Pick());
            }
        }

        [TestMethod]
        public void AddToTheQueue20ElementsTest()
        {
            ThreadSafeCircularQueue ManagedQueue = new ThreadSafeCircularQueue(20);
            for (int i = 0; i < 20; i++)
            {
                ManagedQueue.Add(i);
            }
            for (int i = 0; i < 20; i++)
            {
                Assert.AreEqual(i, ManagedQueue.Pick());
            }
        }

        [TestMethod]
        public void AddToTheQueue21ElementsTest()
        {
            ThreadSafeCircularQueue ManagedQueue = new ThreadSafeCircularQueue(20);
            for (int i = 0; i < 21; i++)
            {
                ManagedQueue.Add(i);
            }
            for (int i = 1; i < 21; i++)
            {
                Assert.AreEqual(i, ManagedQueue.Pick());
            }
        }

        [TestMethod]
        public void PickElementFromTheEmptyQueueTest()
        {
            ThreadSafeCircularQueue ManagedQueue = new ThreadSafeCircularQueue(20);
            Assert.AreEqual(null, ManagedQueue.Pick());
        }

        //Testing UI

    }
}
