using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        private static String TUT_BY_URL = "https://www.tut.by/";
        private static String USERNAME = "TestTr";
        private static String PASSWORD = "tr_001";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}