using System;

namespace DragonBoatClubApp
{
	internal class ForeignKeyAttribute : Attribute
	{
		private string v;

		public ForeignKeyAttribute(string v)
		{
			this.v = v;
		}
	}
}