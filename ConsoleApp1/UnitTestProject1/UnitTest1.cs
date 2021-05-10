using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
		[TestMethod]
		/// <summary>
		/// 백준 브루트포스 2798 블랙잭
		/// </summary>
		public void BlackJack()
		{
			//10 500 => 497 
			//93 181 245 214 315 36 185 138 216 295
			//int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			//int[] number = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] arr = new int[] { 10, 500 };
			int[] number = new int[] { 93, 181, 245, 214, 315, 36, 185, 138, 216, 295 };
			int answer = 0;
			for (int i = 0; i < arr[0]; i++)
			{
				for (int j = i + 1; j < arr[0]; j++)
				{
					for (int k = j + 1; k < arr[0]; k++)
					{
						int sum = number[i] + number[j] + number[k] > arr[1] ? 0 : number[i] + number[j] + number[k];
						if (sum == arr[1])
						{
							Console.WriteLine(arr[1]);
							return;
						}
						answer = Math.Max(answer, sum);
					}
				}
			}
			//Console.WriteLine(answer);
			return;
		}
	}
}
