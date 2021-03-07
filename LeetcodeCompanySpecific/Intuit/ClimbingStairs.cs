using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeCompanySpecific.Intuit
{
	class ClimbingStairs
	{
		Dictionary<int, int> dp = new Dictionary<int, int>();

		public int ClimbStairsFibonacci(int n)
		{
			if(n==1)
			{
				return 1;
			}
			int first = 1;
			int second = 2;
			
			for(int i = 3; i<=n; i++)
			{
				int third = first + second;
				first = second;
				second = third;
			}
			return second;
		}
		public int ClimbStairsDP(int n)
		{
			//dp.Add(0, 0);
			dp.Add(1, 1);
			dp.Add(2, 2);
			for(int i = 3; i<=n; i++)
			{
				dp[i] = dp[i-1] + dp[i-2];
			}
			return dp[n];
		}
		public int ClimbStairsMemoization(int n)
		{
			
			if (n < 0)
				return 0;
			if (n == 0)
				return 1;

			if(dp.ContainsKey(n))
			{
				return dp[n];
			}
			
			return dp[n] = ClimbStairsMemoization(n - 1) + ClimbStairsMemoization(n - 2);
		}
		public int ClimbStairsRecursive(int n)
		{

			if (n < 0)
				return 0;
			if (n == 0)
				return 1;

			if (dp.ContainsKey(n))
			{
				return dp[n];
			}

			return dp[n] = ClimbStairsRecursive(n - 1) + ClimbStairsRecursive(n - 2);
		}
	}
}
