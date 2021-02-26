using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeCompanySpecific.Intuit
{
	class SubdomainVisitCount
	{

		/// <summary>
		/// SubdomainVisits
		/// Time Complexity - O(3n) + O(3n) = O(6n) = O(n)
		/// Space Complexity - O(n)
		/// </summary>
		/// <param name="cpdomains"></param>
		/// <returns></returns>
		public IList<string> SubdomainVisits(string[] cpdomains)
		{
			Dictionary<string, long> domainVisitCounter = new Dictionary<string, long>();
			IList<string> result = new List<string>();

			foreach(string s in cpdomains)
			{
				int i = 0;
				string[] splitData = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				long counter = Convert.ToInt32(splitData[0]);
				string domain = splitData[1];

				while(i != -1)
				{
					if (domainVisitCounter.ContainsKey(domain))
					{
						domainVisitCounter[domain] += counter;
					}
					else
					{
						domainVisitCounter.Add(domain, counter);
					}
					i = domain.IndexOf(".");
					domain = domain.Substring(i + 1);
				}
			}
			foreach (KeyValuePair<string, long> kv in domainVisitCounter)
			{
				result.Add(kv.Value + " " + kv.Key);
			}
			return result;
		}
	}
}
