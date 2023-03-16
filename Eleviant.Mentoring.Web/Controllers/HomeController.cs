﻿using Eleviant.Mentoring.Service;
using Eleviant.Mentoring.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eleviant.Mentoring.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IUserService userService;

		public HomeController(ILogger<HomeController> logger, IUserService userService)
		{
			_logger = logger;
			this.userService = userService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}