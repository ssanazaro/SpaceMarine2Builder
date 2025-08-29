using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceMarine2Builder.Shared.Models
{
	public class Perk
	{
		public int PerkId { get; set; }
		public int ClassId { get; set; }
		public string Type { get; set; } = string.Empty;
		public int Level { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
	}
}
