using System;
namespace Assignment_1;

public class PartA
{
	public void Run()
	{

        //reading in the random numbers from the 6 files and finding the max profit for each (because we arent using java)
        for (int i = 1; i <= 6; i++)
        {
            string filePath = ("../../../stock_nums" + i +".txt");

            maxInFile(filePath);
        }

    }

    //this is the reccursion method
	public static int FindMaxProfit(int[] arr, int left, int right)
	{
		int maxProfit;

		if (right - left <= 2)
		{
			return arr[right] - arr[left];
		}

		else
		{
            //this devides the work in half and searches each half
			int mid = left + (right - left) / 2;
			int firstHalfProfit = FindMaxProfit(arr, left, mid);
			int secondHalfProfit = FindMaxProfit(arr, mid + 1, right);
			int acrossMidProfit = findHighest(arr, mid + 1, right) - findLowest(arr, left, mid);
			int[] results = {firstHalfProfit, secondHalfProfit, acrossMidProfit};

            //this gets the max profit
			maxProfit = findHighest(results, 0, results.Length - 1);

		}

        //returns max
		return maxProfit;
	}

    //this finds the lowest value
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

    //this finds the highest value
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

    //this runs the program 
	private void maxInFile(string filePath)
	{
        try
        {

            List<string> listOfAnswers;
            List<int> listOfNumbers = new();

            //read in the numbers
            listOfAnswers = File.ReadAllLines(filePath).ToList();

            //converting the string to ints
            foreach (string line in listOfAnswers)
            {
                if (int.TryParse(line, out int number))
                {
                    // Parse the line as an integer and add it to the list
                    listOfNumbers.Add(number);
                }
                else
                {
                    // Handle invalid input if necessary
                    Console.WriteLine($"Invalid input: {line}");
                }
            }

            //putting it into an array
            int[] nums = listOfNumbers.ToArray();
            int max = FindMaxProfit(nums, 0, nums.Length - 1);

            //printing out the max amount of money able to get
            Console.WriteLine("Maximum profit: " + max);


        }
        //catching errors
        catch (IOException e)
        {
            Console.WriteLine("An error occured while reading the file: " + e);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occured: " + ex);
        }
    }
}

