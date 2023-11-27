using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practical1.Practical4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractical
{
    [TestClass]
    public class CustomIntArrayTests
    {
        [TestMethod]
        public void MoveSecondNonZeroElementToFront_ShouldMoveSecondNonZeroElement()
        {
            CustomIntArray array = new CustomIntArray(new List<int> { 1, 0, 4, 0, 5, 6, 7, 0, 9 });
            CustomIntArray expectedArray = new CustomIntArray(new List<int> { 4, 1, 0, 0, 5, 6, 7, 0, 9 });

            array.MoveSecondNonZeroElementToFront();
            CollectionAssert.AreEqual(expectedArray.ToList(), array.ToList());
        }

        [TestMethod]
        public void MoveSecondNonZeroElementToFront_ShouldBeSame()
        {
            CustomIntArray array = new CustomIntArray(new List<int> { 0,0 });
            CustomIntArray expectedArray = new CustomIntArray(new List<int> { 0,0 });


            array.MoveSecondNonZeroElementToFront();
            CollectionAssert.AreEqual(expectedArray.ToList(), array.ToList());
        }

        [TestMethod]
        public void MoveSecondNonZeroElementToFront_ShouldNotMoveFirstElem()
        {
            CustomIntArray array = new CustomIntArray(new List<int> { 0,1 });
            CustomIntArray expectedArray = new CustomIntArray(new List<int> { 0,1});


            array.MoveSecondNonZeroElementToFront();
            CollectionAssert.AreEqual(expectedArray.ToList(), array.ToList());
        }

        [TestMethod]
        public void MoveSecondNonZeroElementToFront_NegativeElements()
        {
            CustomIntArray array = new CustomIntArray(new List<int> { 1, 0, -4, 0, -5, 6, 7, 0, -9 });
            CustomIntArray expectedArray = new CustomIntArray(new List<int> { -4, 1, 0, 0, -5, 6, 7, 0, -9 });


            array.MoveSecondNonZeroElementToFront();
            CollectionAssert.AreEqual(expectedArray.ToList(), array.ToList());
        }
    }
}
