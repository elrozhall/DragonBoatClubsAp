﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBoatClubApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Dragon Boat Club Site.  We're looking forward to you joining us!");

			while (true)
			{
				Console.WriteLine("0. Exit");
				Console.WriteLine("1. Add a new club.");
				Console.WriteLine("2. Edit an existing club");
				Console.Write("Please select an option (choose a number)");
				var option = Console.ReadLine();
				switch (option)

				{
					case "0":
						Console.WriteLine("Goodbye!");

						return;

					case "1":
						Console.WriteLine("Club Name:  ");
						var clubName = Console.ReadLine();

						Console.WriteLine("Club Website Address: ");
						var clubWebsite = Console.ReadLine();

						Console.WriteLine("Club Description: ");
						var clubDescription = Console.ReadLine();

						var costTypes = Enum.GetNames(typeof(CostTypes));
						for (int i = 0; i < costTypes.Length; i++)
						{
							Console.WriteLine($"{i + 1}: {costTypes[i]}");
						}
						Console.WriteLine("Please select the cost for this club:");
						var costType = Convert.ToInt32(Console.ReadLine());
						var clubCost = (CostTypes)Enum.Parse(typeof(CostTypes),
							costTypes[costType - 1]);

						var dbClub = ClubAdmin.AddClub(clubName, clubWebsite, clubCost, clubDescription);
						Console.WriteLine($"Asssigned Club ID: {dbClub.ClubId}");
						break;

					case "2":

						break;
					default:
						break;


				}

			}
		}

		
	}
}