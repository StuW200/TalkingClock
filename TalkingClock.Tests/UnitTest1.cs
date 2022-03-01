using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TalkingClock;


namespace TalkingClock.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {            
            var result = TalkingClock.Program.HumanFriendlyTime(new DateTime(2022, 3, 1, 15, 01, 00));

            var expected = "Three O'Clock";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = TalkingClock.Program.HumanFriendlyTime(new DateTime(2022, 3, 1, 00, 59, 00));

            var expected = "One O'Clock";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = TalkingClock.Program.HumanFriendlyTime(new DateTime(2022, 3, 1, 2, 39, 00));

            var expected = "Twenty to Three";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = TalkingClock.Program.HumanFriendlyTime(new DateTime(2022, 3, 1, 6, 7, 00));

            var expected = "Five Past Six";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = TalkingClock.Program.HumanFriendlyTime(new DateTime(2022, 3, 1, 21, 28, 00));

            var expected = "Half Past Nine";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = TalkingClock.Program.HumanFriendlyTime(new DateTime(2022, 3, 1, 00, 48, 00));

            var expected = "Ten to One";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var result = TalkingClock.Program.HumanFriendlyTime(new DateTime(2022, 3, 1, 00, 57, 00));

            var expected = "Five to One";

            Assert.AreEqual(expected, result);
        }
    }
}
