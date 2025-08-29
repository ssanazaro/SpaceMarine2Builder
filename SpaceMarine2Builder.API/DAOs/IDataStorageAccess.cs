using SpaceMarine2Builder.Shared.Models;

namespace SpaceMarine2Builder.API.DAOs
{
	public interface IDataStorageAccess
	{
		List<SpaceMarine> GetAllSpaceMarines();
		List<Perk> GetPerksByClassId(int classId);
		List<Perk> GetPrestigePerksByClassId(int classId);
	}
}
