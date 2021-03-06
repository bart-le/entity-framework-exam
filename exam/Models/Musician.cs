using System.Collections.Generic;

namespace exam.Models
{
	public class Musician
	{
		public int IdMusician { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string? Nickname { get; set; }

		public virtual ICollection<MusicianTrack> MusicTracks { get; set; }
	}
}
