using LeetcodeCompanySpecific.Intuit;
using System;
using System.Collections.Generic;

namespace LeetcodeCompanySpecific
{
	class Program
	{
		static void Main(string[] args)
		{
			////-------------------  ******  Sub Domian Visit Count Starts  ******  -------------------
			//string[] cpdomains = { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
			//IList<string> res = new List<string>();
			//SubdomainVisitCount svc = new SubdomainVisitCount();
			//res = svc.SubdomainVisits(cpdomains);

			//foreach (string s in res)
			//	Console.WriteLine(s);
			//Console.ReadLine();
			////-------------------  ******  Sub Domian Visit Count Ends  ******  -------------------



			////-------------------  ******  Test Justification Starts  ******  -------------------
			//string[] words = { "Here", "is", "an", "example", "of", "text", "justification." };
			//TextJustification tj = new TextJustification();
			//IList<string> res1 = new List<string>();
			//res1 = tj.FullJustifyOptimized(words,16);
			//foreach (string s in res1)
			//	Console.WriteLine(s);
			//Console.ReadLine();
			////-------------------  ******  Test Justification Ends  ******  -------------------


			//-------------------  ******  Climbing Stairs Starts  ******  -------------------
			ClimbingStairs cs = new ClimbingStairs();
			Console.WriteLine(cs.ClimbStairsDP(4));
			Console.ReadLine();
			//-------------------  ******  Climbing Stairs Ends  ******  -------------------
		}
	}
}
