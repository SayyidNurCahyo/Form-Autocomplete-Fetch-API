using ILCS_Final_Test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ILCS_Final_Test.Controllers
{
	public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

		private DataContext db = new DataContext();

		//[Produces("application/json")]
		//[HttpGet("search")]
		public IActionResult Search([FromQuery] string term)
		{
			try
			{
				var names = db.Products.Where(p => p.Name.Contains(term)).Select(p => new {id = p.Id, name = p.Name }).ToList();
				return Ok(names);
			}
			catch
			{
				return BadRequest();
			}
		}

	}
}
