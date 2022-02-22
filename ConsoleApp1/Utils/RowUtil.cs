namespace ConsoleApp1.Utils
{
    public static class RowUtil
    {
        public static int SumOfRow(int num1, int num2, int step = 1)
        {
            int sum = 0;
            for (int i = num1; i <= num2; i+=step)
            {
                sum += i;
            }

            return sum;
        }
        
        public static int SumOfRow(int num1, int num2, out int amount)
        {
            int sum = 0;
            amount = 1;
            for (int i = num1; i < num2; i+=4, amount++)
            {
                sum += i;
            }

            return sum;
        }

        public static int SumTenNum(int startNum)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += startNum;
                startNum += 4;
            }

            return sum;
        }

        public static int SumElevenNum(int startNum)
        {
            int sum = 0;
            for (int i = 0; i < 11; i++)
            {
                sum += startNum;
                startNum *= 2;
            }

            return sum;
        }

        public static int SumUpAndStopAfterHundred(int startNum, out int amount)
        {
            int sum = 0;
            int i = 0;
            for (; sum < 100 ; i++)
            {
                sum += startNum;
                startNum += 4;
            }

            amount = i;
            return sum;
        }

        public static int SumUpAndStopBeforeHundred(int startNum, out int amount)
        {
            int sum = 0;
            int i = 0;
            for (; sum + startNum < 100 ; i++)
            {
                sum += startNum;
                startNum += 4;
            }

            amount = i;
            return sum;
        }
        
        public static int GetFibonacciNum(int n)
        {
            if (n < 3)
            {
                return 1;
            }

            return GetFibonacciNum(n - 1) + GetFibonacciNum(n - 2);
        }

        public static int SumFibonacciNums(int n)
        {
            int sum = 0;
            for (int i = 1; i < n+1 ; i++)
            {
                sum += GetFibonacciNum(i);
            }

            return sum;
        }
    }
}