using SpaceMarine2Builder.API.DAOs;
using SpaceMarine2Builder.Shared.Models;

namespace SpaceMarine2Builder.API.Managers
{
	public class DataStorageManager : IDataStorageManager
	{
		private readonly IDataStorageAccess _dataStorageAccess;

		public DataStorageManager(IDataStorageAccess dataStorageAccess)
		{
			_dataStorageAccess = dataStorageAccess;
		}

		public List<SpaceMarine> GetAllSpaceMarines()
		{
			return _dataStorageAccess.GetAllSpaceMarines();
		}

		public List<Perk> GetPerksByClassId(int classId)
		{
			return _dataStorageAccess.GetPerksByClassId(classId);
		}

		public List<Perk> GetPrestigePerksByClassId(int classId)
		{
			return _dataStorageAccess.GetPrestigePerksByClassId(classId);
		}
	}
}
