using ConsoleApp1.Utils;
using NUnit.Framework;

namespace TestProject1
{
    public class RowUtilTest
    {
        [Test]
        public void TestSumOfRow()
        {
            int num1 = 5;
            int num2 = 12;
            int sumOfRow = 68;
            Assert.AreEqual(sumOfRow, RowUtil.SumOfRow(num1, num2), "Sum of row is incorrect");
        }

        [Test]
        public void TestSumOfRowWithAmountOfNums()
        {
            int num1 = 6;
            int num2 = 46;
            int sumOfRow = 240;
            int amountOfNum = 11;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(sumOfRow, RowUtil.SumOfRow(num1, num2, out int amount), "Sum of row is incorrect");
                Assert.AreEqual(amountOfNum, amount, "Amount of numbers is incorrect");
            });
        }
    }
}