namespace MethodOverloading
{
    class Program
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isCheck)
        {
            var sum = a + b;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {
            var x = 29;
            var y = 55;

            var answer = Add(x, y);

            var a = 62.0;
            var b = 55.0;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
    }
}
