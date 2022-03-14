using System;
using NUnit.Framework;
using OOAD_LR3;

namespace TestQueue
{
    public class Tests
    {
        [Test]
        public void TestReturnQueue()
        {
            int[] a = { 4, 3, 2, 1, 0 };
            Queue<int> queue = new Queue<int>(a);
            string expected = "\n־קונוהü: 4 3 2 1 0 ";
            string actual = queue.ReturnQueue();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestAddItem()
        {
            int[] a = { 4, 3, 2, 1, 0 };
            Queue<int> queue = new Queue<int>(a);
            queue.AddItem(5);
            string expected = "\n־קונוהü: 5 4 3 2 1 0 ";
            string actual = queue.ReturnQueue();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestRemoveItem()
        {
            int[] a = { 5, 4, 3, 2, 1, 0 };
            Queue<int> queue = new Queue<int>(a);
            queue.RemoveItem();
            string expected = "\n־קונוהü: 5 4 3 2 1 ";
            string actual = queue.ReturnQueue();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestRemoveItemError()
        {
            int[] a = { };
            Queue<int> queue = new Queue<int>(a);
            int expected = queue.RemoveItem();
            int actual = default(int); 
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestAddAndRemove()
        {
            int[] a = { 4, 3, 2, 1, 0 };
            Queue<int> queue = new Queue<int>(a);
            queue.AddItem(5);
            queue.RemoveItem();
            string expected = "\n־קונוהü: 5 4 3 2 1 ";
            string actual = queue.ReturnQueue();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestReturnQueueString()
        {
            string[] a = { "A", "B", "C", "D", "E" };
            Queue<string> queue = new Queue<string>(a);
            string expected = "\n־קונוהü: A B C D E ";
            string actual = queue.ReturnQueue();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestAddString()
        {
            string[] a = { "A", "B", "C", "D", "E" };
            Queue<string> queue = new Queue<string>(a);
            queue.AddItem("a");
            string expected = "\n־קונוהü: a A B C D E ";
            string actual = queue.ReturnQueue();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestRemoveString()
        {
            string[] a = { "A", "B", "C", "D", "E" };
            Queue<string> queue = new Queue<string>(a);
            queue.RemoveItem();
            string expected = "\n־קונוהü: A B C D ";
            string actual = queue.ReturnQueue();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestRemoveStringError()
        {
            string[] a = {  };
            Queue<string> queue = new Queue<string>(a);
            string expected = default(string);
            string actual = queue.RemoveItem(); ;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestAddAndRemoveString()
        {
            string[] a = { "A", "B", "C", "D", "E" };
            Queue<string> queue = new Queue<string>(a);
            queue.AddItem("a");
            queue.RemoveItem();
            string expected = "\n־קונוהü: a A B C D ";
            string actual = queue.ReturnQueue();
            Assert.AreEqual(expected, actual);
        }
    }
}