using Microsoft.AspNetCore.Mvc;
using SpaceMarine2Builder.API.Managers;

namespace SpaceMarine2Builder.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SpaceMarineController : ControllerBase
	{
		private readonly IDataStorageManager _dataStorageManager;

		public SpaceMarineController(IDataStorageManager dataStorageManager)
		{
			_dataStorageManager = dataStorageManager;
		}

		[HttpGet("GetAllSpaceMarines")]
		public IActionResult GetAllSpaceMarines()
		{
			var response = _dataStorageManager.GetAllSpaceMarines();
			return Ok(response);
		}

		[HttpGet("GetPerksByClassId/{classId}")]
		public IActionResult GetPerksByClassId(int classId)
		{
			var response = _dataStorageManager.GetPerksByClassId(classId);
			return Ok(response);
		}

		[HttpGet("GetPrestigePerksByClassId/{classId}")]
		public IActionResult GetPrestigePerksByClassId(int classId)
		{
			var response = _dataStorageManager.GetPrestigePerksByClassId(classId);
			return Ok(response);
		}
	}
}
