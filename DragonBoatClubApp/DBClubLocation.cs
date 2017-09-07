using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBoatClubApp
{
	public class DBClubLocation
	{
		[Key]
		public int ClubLocationId { get; set; }

		public enum SkillLevels
		{
			Beginner,
			Intermediate,
			Advanced
		}

		/// <summary>
		/// Address info for the Club
		/// </summary>
		public string AddressZip { get; set; }

		public string AddressCity { get; set; }

		public string AddressState { get; set; }

		public string AddressCountry { get; set; }

		/// <summary>
		/// The following c


		public string ContactName { get; set; }

		public string ContactTitle { get; set; }

		[Phone]
		public string ContactPhone { get; set; }

		[StringLength(50, ErrorMessage = "Email Address should be 50 characters or less")]
		[EmailAddress]
		public string ContactEmail { get; set; }

		/// <summary>
		/// The following lines are all about the Practices
		/// </summary>
		public DayOfWeek PracticeDays { get; set; }

		public TimeSpan PracticeTimes { get; set; }

		public SkillLevels SkillLevel { get; set; }

		[ForeignKey("DBClub")]
		public int ClubId { get; set; }

		public virtual DBClub DBLocClub { get; set; }

	}
}
