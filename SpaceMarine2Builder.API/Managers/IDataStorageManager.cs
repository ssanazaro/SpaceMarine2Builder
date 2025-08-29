using SpaceMarine2Builder.Shared.Models;

namespace SpaceMarine2Builder.API.Managers
{
	public interface IDataStorageManager
	{
		List<SpaceMarine> GetAllSpaceMarines();
		List<Perk> GetPerksByClassId(int classId);
		List<Perk> GetPrestigePerksByClassId(int classId);

	}
}
