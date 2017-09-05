using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBoatClubApp
{
	public enum SkillLevels
	{
		Beginner,
		Medium,
		Advanced
	}

	public enum CostTypes
	{
		FreeFirst3Times,
		SeeWebsite
	}

	/// <summary>
	/// This class describes a dragon boating club.
	/// </summary>
	public class DBClub
	{

		#region Statics

		private static int lastClubId = 100;

		#endregion


		#region Properties

		/// <summary>
		/// 
		/// first property is to assign the Club a unique ID;
		/// </summary>

		[Key]
		public int ClubId { get; private set; }

		public DateTime DateAdded { get; private set; }

		public string ClubName { get; set; }

		[Required]
		[StringLength(50, ErrorMessage ="Website Address should be 50 characters or less")]

		public string ClubWebsite { get; set; }

		public string ClubDescription { get; set; }

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

		[Phone]
		public string ContactPhone { get; set; }

		[StringLength(50, ErrorMessage = "Email Address should be 50 characters or less")]
		[EmailAddress]
		public string ContactEmail { get; set; }

		/// <summary>
		/// Cost May be choices (enumerations)
		/// </summary>
		public CostTypes ClubCost { get; set; }

		/// <summary>
		/// The following lines are all about the Practices
		/// </summary>
		public DayOfWeek PracticeDays { get; set; }
	
		public TimeSpan PracticeTimes { get; set; }

		public SkillLevels SkillLevel { get; set; }

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


		#endregion



		#region Methods


		#endregion //Methods



	}

}
