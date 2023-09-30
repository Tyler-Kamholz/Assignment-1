using System;
using System.IO;
using System.Collections;

namespace Assignment_1;

public class PartB
{
	public void Run()
	{
		string filePath = "../../../input4.txt";

		try
		{

			List<string> listOfAnswers;

			//read in the inputFile4.txt
			listOfAnswers = File.ReadAllLines(filePath).ToList();

			string answer = Reccursion(listOfAnswers, 0, listOfAnswers.Count - 1);

			Console.WriteLine(answer);


        }
        catch (IOException e)
		{
			Console.WriteLine("An error occured while reading the file: " + e);
		}
		catch (Exception ex)
		{
			Console.WriteLine("An error occured: " + ex);
		}

	}

	private string Reccursion(List<string> list, int left, int right)
	{

		string noTree = "No favorite tree :(";

        int mid = (left + (right - left) / 2);

		//base case

		//return the only tree
		if (right - left < 1)
		{
			return list[left];
		}

		string leftSide = Reccursion(list, left, mid);
		string rightSide = Reccursion(list, mid + 1, right);

        //checking if they are the same
        if (leftSide == rightSide)
        {
            return leftSide;
        }

        //then we check the opposite sides to see what one returns more.
        int leftCount = 0; //this is the count of 'rightSide' tree on left side
		int rightCount = 0; //this is the count of 'leftSide' tree on right side

		//checking the left side for the rightSide tree
		for (int i = left; i <= mid; i++)
		{
			if (list[i] == rightSide)
			{
				leftCount++;
			}
		}

		for (int j = mid + 1; j <= right; j++)
		{
			if (list[j] == leftSide)
			{
				rightCount++;
			}
		}

		//returning the tree that has the most
		if (leftCount > rightCount && rightSide != noTree)
		{
			return rightSide;
		}
		else if (rightCount > leftCount && leftSide != noTree)
		{
			return leftSide;
		}
		else
		{
			return noTree;
		}

	}

}

