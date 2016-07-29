using System;
using System.Linq;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.WriteLine(GetMax(numbers));
        }
        
        public static int GetMax(int[] nums)
        {
            int max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            return max;
        }
    }
}
