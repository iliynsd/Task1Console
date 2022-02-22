using ConsoleApp1.Utils;
using NUnit.Framework;

namespace TestProject1
{
    public class NumeralsUtilTest
    {
        [Test]
        public void TestCountNumerals()
        {
            string num = "345";
            int result = 12;
            Assert.AreEqual(result, NumeralsUtil.CountNumerals(num), "Sum of numerals is incorrect");
        }

        [Test]
        public void TestFindMaxNumeral()
        {
            string num = "345";
            int maxNumeral = 5;
            Assert.AreEqual(maxNumeral, NumeralsUtil.FindMaxNumeral(num), "Incorrect max numeral");
        }
    }
}