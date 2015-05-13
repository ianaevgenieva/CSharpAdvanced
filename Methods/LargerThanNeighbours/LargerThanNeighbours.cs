using System;
using System.Linq;

namespace LargerThanNeighbours
{
    internal class LargerThanNeighbours
    {
        private static int[] arr;

        private static bool CheckIfGreater(int idx)
        {
            bool isGreater;
            if (idx == 0)
            {
                isGreater = arr[idx] > arr[idx + 1];
            }
            else if (idx == arr.Length - 1)
            {
                isGreater = arr[idx] > arr[idx - 1];
            }
            else
            {
                isGreater = arr[idx] > arr[idx - 1] && arr[idx] > arr[idx + 1];
            }
            return isGreater;
        }

        private static void Main()
        {
            string inputArray = Console.ReadLine();
            arr = inputArray.Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(CheckIfGreater(i));
            }
        }
    }
}