using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional4Tasks.Tests
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void Task1_ReturnsCorrectValue()
        {
            int[,] array1 = new int[,] { { 6, 0, 54 },
                                        { 10, 6, 340 },
                                        { -10, 50 ,1 } };
            int[,] array2 = new int[,] { { 5, 7, 50 },
                                        { 10, 30, 305 },
                                        { -10, 50 ,60 } };
            int[,] array3 = new int[,] { { 10, 40, 254 },
                                        { 21, 5, 236 },
                                        { -215, 354 ,25 } };

            int expected1 = 36;
            int expected2 = 9000;
            int expected3 = 1250;

            var actual1 = Tasks.Task1(array1);
            var actual2 = Tasks.Task1(array2);
            var actual3 = Tasks.Task1(array3);

            Assert.AreEqual(expected1, actual1, "Task1 returns incorrect value.");
            Assert.AreEqual(expected2, actual2, "Task1 returns incorrect value.");
            Assert.AreEqual(expected3, actual3, "Task1 returns incorrect value.");
        }

        [Test]
        public void Task2_ReturnsCorrectValue()
        {
            int[,] array1 = new int[,] { { 1, 0, 5 },
                                        { 1, 5, 3 },
                                        { 1, 5 ,6 } };
            int[,] array2 = new int[,] { { 1, 0, 3 },
                                        { 3, 4, 2 },
                                        { 2, 2 ,2 } };
            int[,] array3 = new int[,] { { 2, 4, 4 },
                                        { 1, 0, 3 },
                                        { 2, 5 ,3 } };

            double expected1 = 4;
            double expected2 = 3;
            double expected3 = 3.33;

            var actual1 = Tasks.Task2(array1);
            var actual2 = Tasks.Task2(array2);
            var actual3 = Tasks.Task2(array3);

            Assert.AreEqual(expected1, actual1, 0.01, "Task2 returns incorrect value.");
            Assert.AreEqual(expected2, actual2, 0.01, "Task2 returns incorrect value.");
            Assert.AreEqual(expected3, actual3, 0.01, "Task2 returns incorrect value.");
        }

        [Test]
        public void Task3_ReturnsCorrectValue()
        {
            int[,] array1 = new int[,] { { 51, 20, 5 },
                                        { 1, 33, 3 },
                                        { 61, 5 ,36 } };
            int[,] array2 = new int[,] { { 0, 90, 90 },
                                        { 7, 3, 3 },
                                        { 72, 5 ,56 } };
            int[,] array3 = new int[,] { { 0, 0, 0 },
                                        { 1, 340, 32 },
                                        { 30, 0 ,60 } };

            int[] expected1 = { 113, 58, 44 };
            int[] expected2 = { 79, 98, 149 };
            int[] expected3 = { 31, 340, 92 };

            var actual1 = Tasks.Task3(array1);
            var actual2 = Tasks.Task3(array2);
            var actual3 = Tasks.Task3(array3);

            Assert.AreEqual(expected1, actual1, "Task3 returns incorrect value.");
            Assert.AreEqual(expected2, actual2, "Task3 returns incorrect value.");
            Assert.AreEqual(expected3, actual3, "Task3 returns incorrect value.");
        }
    }
}
