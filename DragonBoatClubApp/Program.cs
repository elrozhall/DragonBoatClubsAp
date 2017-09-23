

using System;

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
				Console.WriteLine("2. Add, edit or delete a practice for a club."); 
				Console.WriteLine("3. Edit an existing club's information");
				Console.WriteLine("4. Print all Dragon Boat Clubs");

				Console.Write("Please select an option (choose a number)");
				var option = Console.ReadLine();
				switch (option)

				{
					case "0":
						Console.WriteLine("Goodbye!");

						return;

					case "1":
						Console.WriteLine("Club Name: ");
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

						Console.WriteLine("Street Address: ");
						var addressStreet = Console.ReadLine();

						Console.WriteLine("City: ");
						var addressCity = Console.ReadLine();

						Console.WriteLine("State: ");
						var addressState = Console.ReadLine();

						Console.WriteLine("Country: ");
						var addressCountry = Console.ReadLine();

						Console.WriteLine("Zip: ");
						var addressZip = Console.ReadLine();

						Console.WriteLine("Contact Name: ");
						var contactName = Console.ReadLine();

						Console.WriteLine("Contact Title: ");
						var contactTitle = Console.ReadLine();

						Console.WriteLine("Contact Phone: ");
						var contactPhone = Console.ReadLine();

						Console.WriteLine("Contact Email: ");
						var contactEmail = Console.ReadLine();

						//Console.WriteLine("")


						var dbClub = ClubAdmin.AddClub(clubName, clubWebsite, clubCost, addressStreet, addressCity, addressState, addressCountry, addressZip, contactName, contactTitle, contactPhone, contactEmail, clubDescription);
						Console.WriteLine($"Asssigned Club ID: {dbClub.ClubId}");
						break;

					case "2":
						string[] practiceDay = Enum.GetNames(typeof(DayOfWeek));
						foreach (string s in practiceDay)
						{
							Console.WriteLine($"Do you have one or more practices on {s}s?");
							string numbPract = Console.ReadLine();
							while (numbPract =="y")
							{
								 int PracticesPerDay { get; set; };
								
								Console.WriteLine($"How many practices are on {s}?");
								Console.Read({ PracticePerDay});
								Console.WriteLine("What time does the first practice start?");
								Console.WriteLine($" {s} from whatever to whatever");
								Console.WriteLine($"Do you have another practice on {s}s?");
								numbPract = Console.ReadLine();

							}
						}

						break;

					case "3":
						//PrintAllPractices();
						//Console.Write("Please select a practice you would like to edit");
					
						break;

					case "4":
						PrintAllDbClubs();
						break;

					default:
						break;

				}

			}
		}

		private static void PrintAllDbClubs ()
		{
			Console.Write("Club Website: ");
			var clubWebsite = Console.ReadLine();
			var alldBClubs = ClubAdmin.GetAllAccountsByClubWebsite(clubWebsite);

			foreach (var dbClub in alldBClubs)
			{
				Console.WriteLine($" Club ID: {dbClub.ClubId}, Club Name: {dbClub.ClubName}, Club Website: {dbClub.ClubWebsite}, Date Created: {dbClub.DateAdded:f}");
			}
		}


	}
}
