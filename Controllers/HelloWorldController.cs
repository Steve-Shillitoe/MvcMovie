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
	public IActionResult Welcome(string name, int numTimes = 1)
	{
		ViewData["Message"] = "Hello " + name;
		ViewData["NumTimes"] = numTimes;
		return View();
	}
}