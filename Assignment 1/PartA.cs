using System;
namespace Assignment_1;

public class PartA
{
	public void Run()
	{
		int[] prices = { 4, 6, 9, 3, 2, 5, 8, 1 };
		var max = FindMaxProfit(prices, 0, prices.Length - 1);
		Console.WriteLine(max);
	}

	public static int FindMaxProfit(int[] arr, int left, int right)
	{
		int maxProfit = 0;

		if (right - left <= 2)
		{
			return arr[right] - arr[left];
		}

		else
		{
			int mid = left + (right - left) / 2;
			int firstHalfProfit = FindMaxProfit(arr, left, mid);
			int secondHalfProfit = FindMaxProfit(arr, mid + 1, right);
			int acrossMidProfit = findHighest(arr, mid + 1, right) - findLowest(arr, left, mid);
			int[] results = {firstHalfProfit, secondHalfProfit, acrossMidProfit};

			maxProfit = findHighest(results, 0, results.Length - 1);

		}

		return maxProfit;
	}

	public static int findLowest(int[] arr, int left, int right)
	{
		int lowest = int.MaxValue;

		for (int i = left; i <= right; i++)
		{
			if (arr[i] < lowest)
			{
				lowest = arr[i];
			}
		}
		return lowest;
	}
    public static int findHighest(int[] arr, int left, int right)
    {
        int highest = 0;

        for (int i = left; i <= right; i++)
        {
            if (arr[i] > highest)
            {
                highest = arr[i];
            }
        }
        return highest;
    }
}

