﻿using Microsoft.AspNetCore.Mvc;

namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
