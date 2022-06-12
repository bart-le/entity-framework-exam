﻿using System.Collections.Generic;

namespace exam.Models
{
	public class MusicLabel
	{
		public int IdMusicLabel { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Album> Albums { get; set; }
	}
}
