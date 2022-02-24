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
        
        [Test]
        public void TestGetOddNums()
        {
            string numbers = "21;12;13;16;23;456;789;553;9;8;3;";
            string oddNums = "21;13;23;789;553;9;3;";
            Assert.AreEqual(oddNums, StringNumsUtil.GetOddNums(numbers), "Get not odd numbers");
        }

        [Test]
        public void TestGetFirstThreeNums()
        {
            string numbers = "21;12;13;16;23;456;789;553;9;8;3;";
            string firstThreeNums = "21;12;13;";
            Assert.AreEqual(firstThreeNums, StringNumsUtil.GetFirstThreeNums(numbers), "Get not first three numbers");
        }

        [Test]
        public void TestGetLastThreeNums()
        {
            string numbers = "21;12;13;16;23;456;789;553;9;8;3;";
            string lastThreeNums = "9;8;3;";
            Assert.AreEqual(lastThreeNums, StringNumsUtil.GetLastThreeNums(numbers), "Get not last three numbers");
        }

        [Test]
        public void TestSumStringNums()
        {
            string numbers = "21;12;4;";
            int sumOfStringNums = 37;
            Assert.AreEqual(sumOfStringNums, StringNumsUtil.SumStringNums(numbers), "Sum of numbers is incorrect");
        }
    }
}