using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication1.Controllers
{
    public class StudentsController : Controller
    {
        // GET
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}