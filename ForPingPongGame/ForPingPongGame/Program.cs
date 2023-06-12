using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<string>[] totalTeams = new List<string>[8];

		for (int i = 0; i < totalTeams.Length; i++)
		{
			totalTeams[i] = new List<string>();
		}

		Console.WriteLine("Enter 32 names:");

		var filledTeam = new List<int>();
		Random random = new Random();

		for (int i = 0; i < 32; i++)
		{
			int randomIndex = random.Next(0, 8);
			if (!filledTeam.Contains(randomIndex))
			{
				if (totalTeams[randomIndex].Count < 4)
				{
					Console.Write($"Enter name {i + 1}: ");
					string name = Console.ReadLine();
					totalTeams[randomIndex].Add(name);
				}
				else
				{
					filledTeam.Add(randomIndex);
					i--; 
				}
			}
			else
			{
				i--;
			}
		}

		Console.WriteLine("Teams:");

		for (int i = 0; i < totalTeams.Length; i++)
		{
			Console.WriteLine($"Teams {i + 1}: {string.Join(", ", totalTeams[i])}");
		}
	}
}
