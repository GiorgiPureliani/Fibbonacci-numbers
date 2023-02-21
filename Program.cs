namespace Project2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter upper bound number: ");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers up to {upperBound} are:");
            int[] numbers = GetNumbers(upperBound);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < upperBound)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }

        static int[] GetNumbers(int upperBound)
        {
            if (upperBound <= 0)
            {
                return new int[0];
            }
            if (upperBound == 1)
            {
                return new int[] { 0 };
            }
            if (upperBound == 2)
            {
                return new int[] { 0, 1, 1 };
            }

            int count = GetNumbersCount(upperBound);
            int[] numbers = new int[count];
            numbers[0] = 0;
            numbers[1] = 1;
            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
            }

            return numbers;
        }

        static int GetNumbersCount(int upperBound)
        {
            int x = 0;
            int y = 1;
            int count = 2;
            for (int i = 2; i < upperBound + 3; i++)
            {
                (x, y) = (y, x);
                y = x + y;

                if (y > upperBound)
                {
                    break;
                }
                count++;
            }

            return count;
        }
    }
}