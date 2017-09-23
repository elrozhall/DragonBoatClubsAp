using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBoatClubApp
{
	public static class ClubAdmin
	{
		private static DBClubNetworkModel datbas = new DBClubNetworkModel();

		public static DBClub AddClub(string clubName, string clubWebsite, CostTypes clubCost, string addressStreet, string addressCity, string addressState, string addressCountry, string addressZip, string contactName, string contactTitle, string contactPhone, string contactEmail, string clubDescription = "Dragon Boat Club that is open for all")
		{
			var dbClub = new DBClub
			{
				ClubName = clubName,
				ClubWebsite = clubWebsite,
				ClubCost = clubCost,
				AddressStreet = addressStreet,
				AddressCity = addressCity,
				AddressCountry = addressCountry,
				AddressState = addressState,
				AddressZip = addressZip,
				ContactName = contactName,
				ContactTitle = contactTitle,
				ContactPhone = contactPhone,
				ContactEmail = contactEmail,
				ClubDescription = clubDescription
			};

			datbas.DBClubs.Add(dbClub);
			datbas.SaveChanges(); 
			return dbClub;
		}


		public static DBClub[] GetAllAccountsByClubWebsite(string clubWebsite)
		{
			return datbas.DBClubs.
			Where(a => a.ClubWebsite == clubWebsite).ToArray();
		}

		/* DayOfWeek PracticeDays, TimeSpan practiceTimes, SkillLevels skillLevel will be added later when I figure out the best way to deal with them - possibly List...maybe Array, but probably list...may have to take out contact name and do the same in case they want to add more than one....even locations for the clubs could be more than one...actually it will be a method where they add the day and the time, and then the skill level for that particular practice*/

		/* add a club description - string - Have example/default text? - have a length 
		 * 
		 * limit */

		/*string addressZip, string addressCity, string addressState, string addressCountry (also more than one)
		string contactName, string contactTitle, string ContactPhone, string ContactEmail (also more than one)*/





	}









}

