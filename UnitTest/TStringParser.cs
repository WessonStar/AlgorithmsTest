using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsRiver.YString;
using System;

namespace UnitTest
{
    [TestClass]
    public class TStringParser
    {
        [TestMethod]
        public void test_parse_to_int()
        {
            Assert.AreEqual(StringParser.ToInt("-123"), -123);

            Assert.AreEqual(StringParser.ToInt("+123"), 123);

            Assert.AreEqual(StringParser.ToInt("0123"), 123);

            Assert.ThrowsException<FormatException>(() => StringParser.ToInt(null));

            Assert.ThrowsException<FormatException>(() => StringParser.ToInt(""));

            Assert.ThrowsException<FormatException>(() => StringParser.ToInt("1.1"));
        }

        public void test_parse_to_float()
        {
            Assert.AreEqual(StringParser.ToFloat("1.0"), 1.0f);

            Assert.AreEqual(StringParser.ToFloat("-1.0"), -1.0f);

            Assert.AreEqual(StringParser.ToFloat("1"), 1.0f);

            Assert.AreEqual(StringParser.ToFloat("0.10"), 0.1f);

            Assert.AreEqual(StringParser.ToFloat("1e0"), 1.0f);

            Assert.AreEqual(StringParser.ToFloat("1e-1"), 0.1f);

            Assert.AreEqual(StringParser.ToFloat("1e1"), 10.0f);

            Assert.AreEqual(StringParser.ToFloat("1.1e1"), 11.0f);

            Assert.ThrowsException<FormatException>(() => StringParser.ToFloat(null));

            Assert.ThrowsException<FormatException>(() => StringParser.ToFloat(""));

            Assert.ThrowsException<FormatException>(() => StringParser.ToFloat("1..0"));

            Assert.ThrowsException<FormatException>(() => StringParser.ToFloat("."));

            Assert.ThrowsException<FormatException>(() => StringParser.ToFloat("-"));

            Assert.ThrowsException<FormatException>(() => StringParser.ToFloat("e"));

            Assert.ThrowsException<FormatException>(() => StringParser.ToFloat("e1"));

            Assert.ThrowsException<FormatException>(() => StringParser.ToFloat("ee"));

            Assert.ThrowsException<FormatException>(() => StringParser.ToFloat("1e0.1"));
        }
    }
}
