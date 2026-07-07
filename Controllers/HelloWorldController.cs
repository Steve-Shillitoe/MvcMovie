using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
	//Every public method in a controller is callable as an HTTP endpoint.
	//Below, both methods return a string. 
	//
	// GET: /HelloWorld/
	public IActionResult Index()
	{
		return View();
	}
	// 
	// GET: /HelloWorld/Welcome/ 
	// Requires using System.Text.Encodings.Web;
	public string Welcome(string name, int ID = 1)
	{
		return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
	}
}