using System;
using NUnit.Framework;
using OOAD_LR2;


namespace Тест_OOAD_LR2
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[] test = { 3, 2, 1, 4, 6, 5 };
            InsertionSort sort = new InsertionSort(test);
            sort.Sort();
            int[] extend = { 1, 2, 3, 4, 5, 6 };
            Assert.AreEqual(extend, sort.ShowArray());
        }
        [Test]
        public void TestNull()
        {
            int[] test = null;
            InsertionSort sort = new InsertionSort(test);
            Assert.Throws<ArgumentException>(() => { test = sort.Sort(); });

        }
        [Test]
        public void TestSubZero()
        {
            int[] test = { -3, -2, -1, -4, -6, -5 };
            InsertionSort sort = new InsertionSort(test);
            sort.Sort();
            int[] extend = { -6, -5, -4, -3, -2, -1 };
            Assert.AreEqual(extend, sort.ShowArray());
        }
        [Test]
        public void TestPlusMinus()
        {
            int[] test = { -1, -3, -2, 3, 1, 2 };
            InsertionSort sort = new InsertionSort(test);
            sort.Sort();
            int[] extend = { -3, -2, -1, 1, 2, 3 };
            Assert.AreEqual(extend, sort.ShowArray());
        }
        [Test]
        public void TestOnlyZero()
        {
            int[] test = { 0, 0, 0, 0, 0, 0 };
            InsertionSort sort = new InsertionSort(test);
            sort.Sort();
            int[] extend = { 0, 0, 0, 0, 0, 0 };
            Assert.AreEqual(extend, sort.ShowArray());
        }
    }
}