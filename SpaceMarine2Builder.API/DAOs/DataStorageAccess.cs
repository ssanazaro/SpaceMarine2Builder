using SpaceMarine2Builder.API.DAOs;
using SpaceMarine2Builder.Shared.Models;
using System.Text.Json;

namespace SpaceMarine2Builder.API.DTOs
{
	public class DataStorageAccess : IDataStorageAccess
	{
		private readonly string _spaceMarinefilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "SpaceMarines.json");
		private readonly string _perksfilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Perks.json");
		private readonly string _prestigePerksfilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "PrestigePerks.json");


		public List<SpaceMarine> GetAllSpaceMarines()
		{
			if (!File.Exists(_spaceMarinefilePath))
			{
				return new List<SpaceMarine>(); // Return an empty list if the file doesn't exist
			}

			var jsonData = File.ReadAllText(_spaceMarinefilePath);
			return JsonSerializer.Deserialize<List<SpaceMarine>>(jsonData);
		}

		public List<Perk> GetPerksByClassId(int classId)
		{
			if (!File.Exists(_perksfilePath))
			{
				return new List<Perk>(); // Return an empty list if the file doesn't exist
			}

			var jsonData = File.ReadAllText(_perksfilePath);
			var allPerks = JsonSerializer.Deserialize<List<Perk>>(jsonData);

			// Filter by ClassId
			return allPerks?.Where(p => p.ClassId == classId).ToList() ?? new List<Perk>();
		}

		public List<Perk> GetPrestigePerksByClassId(int classId)
		{
			if (!File.Exists(_prestigePerksfilePath))
			{
				return new List<Perk>(); // Return an empty list if the file doesn't exist
			}

			var jsonData = File.ReadAllText(_prestigePerksfilePath);
			var allPerks = JsonSerializer.Deserialize<List<Perk>>(jsonData);

			// Filter by ClassId
			return allPerks?.Where(p => p.ClassId == classId).ToList() ?? new List<Perk>();
		}
	}
}
