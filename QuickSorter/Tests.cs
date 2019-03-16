using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        public readonly Random rnd = new Random();

        [TestMethod]
        public void TestSortArray3Elements()
        {
            bool firstСondition = false;
            bool secondCondition = false;
            var array = new int[3];
            for (int i = 0; i < 3; i++)
            {
                array[i] = rnd.Next(0, 5);
            }
            Program.QuickSort(array);
            if (array[1] >= array[0])
                firstСondition = true;
            if (array[2] >= array[1])
                secondCondition = true;
            Assert.AreEqual(true, firstСondition);
            Assert.AreEqual(true, secondCondition);
        }

        [TestMethod]
        public void TestSortArray100Elements()
        {
            var array = new int[100];
            for (int i = 0; i < 100; i++)
            {
                array[i] = rnd.Next(0, 5);
            }
            Program.QuickSort(array);
            var counter = 0;
            for (int i = 0; i < 20; i++)
            {
                var check = rnd.Next(1, 99);
                if (array[check - 1] <= array[check])
                    counter++;
            }
            Assert.AreEqual(20, counter);
        }

        [TestMethod]
        public void TestSortArray1000Elements()
        {
            var array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = rnd.Next(0, 5);
            }
            Program.QuickSort(array);
            var counter = 0;
            for (int i = 0; i < 10; i++)
            {
                var check = rnd.Next(1, 999);
                if (array[check - 1] <= array[check])
                    counter++;
            }
            Assert.AreEqual(10, counter);
        }

        [TestMethod]
        public void TestSortEmptyArray()
        {
            List<int> array = new List<int>();
            var currentArray = array.ToArray();
            Program.QuickSort(currentArray);
            Assert.IsTrue(currentArray.Length == 0);
        }

        [TestMethod]
        public void TestSortArray1500000000Elements()
        {
            var array = new int[150000000];
            for (int i = 0; i < 150000000; i++)
            {
                array[i] = rnd.Next(0, 5);
            }
            Program.QuickSort(array);
            var counter = 0;
            for (int i = 0; i < 3; i++)
            {
                var check = rnd.Next(1, 149999999);
                if (array[check - 1] <= array[check])
                    counter++;
            }
            Assert.AreEqual(3, counter);
        }
    }
}