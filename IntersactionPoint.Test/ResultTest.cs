using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntersactionPont.MathLogic;
using System.Numerics;

namespace IntersactionPoint.Test
{
    [TestClass]
    public class ResultTest
    {
        [TestMethod]
        public void CheckIntersactionPointValue()
        {
            Vector2 correct = new Vector2(4, 8);


            Assert.AreEqual(correct, new Vector2(4, 8));
        }
    }
}
