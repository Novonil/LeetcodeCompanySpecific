using LeetcodeCompanySpecific.Intuit;
using System;
using System.Collections.Generic;

namespace LeetcodeCompanySpecific
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] cpdomains = { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
			IList<string> res = new List<string>();
			SubdomainVisitCount svc = new SubdomainVisitCount();
			res = svc.SubdomainVisits(cpdomains);

			foreach (string s in res)
				Console.WriteLine(s);
			Console.ReadLine();
		}
	}
}
