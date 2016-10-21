using System;
using IsItChristmasAlready.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsItChristmasAlready.Test
{
    [TestClass]

    public class ChristmasServiceTests
    {
        [TestMethod]
        public void NotOnChristmas_ReturnsFalse()
        {
            //arrange
            var dateToCheck = new DateTime(2015, 1, 1);
            var christmasService = new ChristmasService();

            //act
            var isItChristmasAlready = christmasService.IsItChristmasToday(dateToCheck);

            //assert
            Assert.IsFalse(isItChristmasAlready);
        }

        [TestMethod]
        public void OnChristmas_ReturnsTrue()
        {
            //arrange
            var dateToCheck = new DateTime(2015, 12, 25);
            var christmasService = new ChristmasService();

            //act
            var isItChristmasAlready = christmasService.IsItChristmasToday(dateToCheck);

            //assert
            Assert.IsTrue(isItChristmasAlready);
        }

        [TestMethod]
        public void ErrorTest()
        {
            Assert.IsTrue(false);
        }
    }
}
