using ConsoleApp1.Utils;
using NUnit.Framework;

namespace TestProject1
{
    public class StringNumsUtilTest
    {
        [Test]
        public void TestCountNumerals()
        {
            int num = 345;
            int result = 12;
            Assert.AreEqual(result, StringNumsUtil.CountNumerals(num), "Sum of numerals is incorrect");
        }

        [Test] 
        public void TestFindNumWithMaxSumNumerals()
        {
            string num = "345;67;43;98;";
            string maxNumeral = "98";
            Assert.AreEqual(maxNumeral, StringNumsUtil.FindNumWithMaxSumNumerals(num), "Incorrect max numeral");
        }
    }
}