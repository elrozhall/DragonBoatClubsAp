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
			var myDBClub = new DBClub
			{
				ClubName = "Seattle Flying Dragon Boat Club",
				ClubWebsite = "www.seattleflyingdragons.org",
				//myDBClub.DateAdded = DateTime.Now;
				SkillLevel = SkillLevels.Advanced,
				Cost = CostTypes.FreeFirst3Times
			};

		//myDBClub.Deposit(500.01M);
		//myDBClub.Balance = 123456.54M;

			Console.WriteLine($"myDBClub: {myDBClub.ClubId}, DBClub Name: {myDBClub.ClubName}, Balance: {myDBClub.Balance:C}, Date Club Added: {myDBClub.DateAdded}");

			var myDBClub2 = new DBClub
			{
				ClubName = "Club 2 Placeholder",
				ClubWebsite = "www.seattleflyingdragons.org"

			};

		//myDBClub2.DateAdded = DateTime.Now;

		Console.WriteLine($"myDBClub: {myDBClub2.ClubId}, DBClub Name: {myDBClub2.ClubName}, Balance: {myDBClub2.Balance:C}, Date Club Added: {myDBClub2.DateAdded}");

		}

		
	}
}