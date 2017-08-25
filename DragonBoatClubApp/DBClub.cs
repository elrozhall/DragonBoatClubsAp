using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBoatClubApp
{
	enum SkillLevels
	{
		Beginner,
		Medium,
		Advanced
	}

	enum CostTypes
	{
		FreeFirst3Times,
		SeeWebsite
	}

	/// <summary>
	/// This class describes a dragon boating club.
	/// </summary>
	class DBClub
	{

		#region Statics

		private static int lastClubId = 100;

		#endregion


		#region Properties

		/// <summary>
		/// 
		/// first property is to assign the Club a unique ID;
		/// </summary>


		public int ClubId { get; private set; }

		public DateTime DateAdded { get; private set; }

		public string ClubName { get; set; }
	
		public string ClubWebsite { get; set; }

		/// <summary>
		/// Address info for the Club
		/// </summary>
		public string AddressZip { get; set; }

		public string AddressCity { get; set; }

		public string AddressState { get; set; } 

		public string AddressCountry { get; set; }

		/// <summary>
		/// The following contact info will be combined into a METHOD so that up to 3 contacts can be added.
		/// </summary>
	
		public string ContactName { get; set; }

		public string ContactTitle { get; set; }

		public string ContactTelephone { get; set; }

		public string ContactEmailAddress { get; set; }

		/// <summary>
		/// Cost May be choices (enumerations)
		/// </summary>
		public CostTypes Cost { get; set; }

		/// <summary>
		/// The following lines are all about the Practices
		/// </summary>
		public DayOfWeek PracticeDays { get; set; }
	
		public TimeSpan PracticeTimes { get; set; }

		public SkillLevels SkillLevel { get; set; }

		/// <summary>
		/// These are events for this particular club.  
		/// They should include name of event, dates, day of week, times, and a link to website and facebook -m maybe other social media for that event.  The club will be able to add as many as they like.  May not add this, may just leave it for the club's websites for now.
		/// </summary>


		/// <summary>
		/// The next properties are part of the Bank example that I'm using to practice the new concepts, even though my program doesn't need a similar method.  After I compile to make sure it works, I'll comment it out...and of course eventually get rid of these lines of code completley
		/// 
		/// </summary>
		/// 
		public decimal Balance { get; private 
				set; }


		#endregion //Properties

		#region Constructors

		public DBClub()
		{
			//lastClubId = lastClubId + 1;
			ClubId = ++lastClubId;
			DateAdded = DateTime.Now;
		}

		//public DBClub(string clubName) : this()
		//{
		//	ClubName = clubName;
		//}

		//public DBClub(string clubName, string clubWebsite) : this(clubName)
		//{
		//	ClubWebsite = clubWebsite;
		//}


		#endregion



		#region Methods

		/// <summary>
		/// The following methods are part of the bank example, again using so I can learn these techniques even though they are not included in my app so far in any similar way
		/// </summary>


		///	<summary>
		///	Deposit money into your account
		/// </summary>
		/// <param name="amount"> Amount to deposit </param>
		public void Deposit (decimal amount)
		{
			Balance += amount;
		}

		/// <summary>
		/// Withdraw money from the bank
		/// </summary>
		/// <param name="amount">amount to withdraw</param>
		/// <returns>The new Balance</returns>
		public decimal Withdrawal (decimal amount)
		{
			Balance -= amount;
			return Balance;
		}






		#endregion //Methods



	}

}
