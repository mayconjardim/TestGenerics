using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Dynamic;

namespace TestGenerics.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductController : ControllerBase
	{

		private static dynamic products;

		static ProductController()
		{
			string jsonFilePath = "products.json";
			products = new JsonFileReader<List<ExpandoObject>>().ReadJson(jsonFilePath);
		}


		[HttpGet]
		public IActionResult GetAllProducts()
		{
			return products;
		}
	}
}
