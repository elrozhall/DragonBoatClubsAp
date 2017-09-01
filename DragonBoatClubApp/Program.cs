

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
			var myDBClub = ClubAdmin.AddClub("Seattle Flying Dragon Boat Club", "www.seattleflyingdragons.org", CostTypes.FreeFirst3Times, "Dragon Boat Club open to all for recreation and competing");



			Console.WriteLine($"myDBClub: {myDBClub.ClubId}, DBClub Name: {myDBClub.ClubName}, Balance: {myDBClub.Balance:C}, Date Club Added: {myDBClub.DateAdded}");

			var myDBClub2 = ClubAdmin.AddClub("Club 2 Placeholder", "www.seattleflyingdragons.org", CostTypes.SeeWebsite,"Club2 Description Placeholder");
				

		Console.WriteLine($"myDBClub: {myDBClub2.ClubId}, DBClub Name: {myDBClub2.ClubName}, Balance: {myDBClub2.Balance:C}, Date Club Added: {myDBClub2.DateAdded}");

		}

		
	}
}