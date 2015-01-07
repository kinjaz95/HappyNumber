using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HappyNumber;

namespace HappyNumberTest
{
    [TestClass]
    public class HappyNumberTest
    {
        private Test _happyNumber;

        public HappyNumberTest()
        {
            _happyNumber = new Test();
        }
        
        [TestMethod]
        public void SplitNumberTest_SplitNumberAndSquareAndSum_Number()
        {
            //Arrange: Given a number
            int number = 52;

            //Act: ... split number, square both numbers and sum them up ...
            _happyNumber.SplitNumber(number);

            //Assert: 
            Assert.AreEqual(29, number);
        }

        [TestMethod]
        public void ISNumberInListTest_ISNumberInList_Bool()
        {
            //Arrange:
            int number = 52;
            IList<int> DummyList = new List<int> { 20, 52, 13, 26, 15 };

            //Act 
            var isNumberInList = _happyNumber.IsNumberInList(number, DummyList);

            //Assert
            Assert.AreEqual(true, isNumberInList);
        }

        [TestMethod]

        public void IsCrossSumEqualsOneTest_CheckIFCrossSumEqualsOne_bool()
        {
            //Arrange:
            int number = 10;

            //Act
            var isCrossSumEqualsOne = _happyNumber.IsCrossSumEqualsOne(number);

            //Assert
            Assert.AreEqual(true, isCrossSumEqualsOne);
        }
    }


}
