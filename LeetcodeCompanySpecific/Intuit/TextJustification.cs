using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetcodeCompanySpecific.Intuit
{
	class TextJustification
	{
		/// <summary>
		/// FullJustify
		/// Time Complexity - 
		/// Space Complexity - 
		/// </summary>
		/// <param name="words"></param>
		/// <param name="maxWidth"></param>
		/// <returns></returns>
		public IList<string> FullJustify(string[] words, int maxWidth)
		{
			int lengthOfSentence = 0;
			int totalSpaces = 0;
			List<string> wordsOnEachLine = new List<string>();

			StringBuilder result = new StringBuilder();
			IList<string> res = new List<string>();
			

			for (int i = 0; i < words.Length; i++)
			{
				if (lengthOfSentence + words[i].Length > maxWidth)
				{
					totalSpaces = maxWidth - (lengthOfSentence - 1);
					for (int j = 0; j < wordsOnEachLine.Count; j++)
					{
						string word = wordsOnEachLine[j];
						if (j != wordsOnEachLine.Count - 1)
						{
							result.Append(word + " ");
							string spaces = new String(' ', totalSpaces / (wordsOnEachLine.Count - 1));
							result.Append(spaces);
							if (j + 1 <= (totalSpaces % (wordsOnEachLine.Count - 1)))
							{
								result.Append(" ");
							}
						}
						else
						{
							result.Append(word);
							if(wordsOnEachLine.Count == 1)
							{
								string spaces = new String(' ', totalSpaces);
								result.Append(spaces);
							}
						}
					}
					res.Add(result.ToString());
					result.Clear();
					wordsOnEachLine.Clear();
					lengthOfSentence = words[i].Length + 1;
					wordsOnEachLine.Add(words[i]);
				}
				else if (lengthOfSentence + words[i].Length == maxWidth)
				{
					wordsOnEachLine.Add(words[i]);
					for (int j = 0; j < wordsOnEachLine.Count; j++)
					{
						string word = wordsOnEachLine[j];
						if(j != wordsOnEachLine.Count - 1)
						{
							result.Append(word + " ");
						}
						else
						{
							result.Append(word);
						}
					}
					res.Add(result.ToString());
					result.Clear();
					lengthOfSentence = 0;
					wordsOnEachLine.Clear();
					if(i == words.Length - 1)
					{
						break;
					}
				}
				else
				{
					lengthOfSentence += words[i].Length + 1;
					wordsOnEachLine.Add(words[i]);
				}

				if (i == words.Length - 1)
				{
					int totalCountOfLetters = 0;
					for (int j = 0; j < wordsOnEachLine.Count; j++)
					{
						string word = wordsOnEachLine[j];
						result.Append(word);
						totalCountOfLetters += word.Length;
						if(totalCountOfLetters < maxWidth)
						{
							result.Append(" ");
							totalCountOfLetters += 1;
						}
					}
					string spaces = new String(' ', maxWidth - totalCountOfLetters);
					result.Append(spaces);
					res.Add(result.ToString());
				}
			}
			return res;
		}


		public IList<string> FullJustifyOptimized(string[] words, int maxWidth)
		{
			int num_of_characters = 0;
			List<string> curr = new List<string>();
			IList<string> res = new List<string>();

			foreach(string word in words)
			{
				if(num_of_characters + word.Length + curr.Count > maxWidth)
				{
					for(int i = 0; i < maxWidth - num_of_characters; i++)
					{
						curr[i%((curr.Count - 1) > 0 ? (curr.Count - 1) : 1)] += " ";
					}
					res.Add(String.Join(String.Empty,curr));
					curr.Clear();
					num_of_characters = 0;
				}
				curr.Add(word);
				num_of_characters += word.Length;
			}
			res.Add(String.Join(" ", curr).PadRight(maxWidth));
			return res;

		}
	}
}
