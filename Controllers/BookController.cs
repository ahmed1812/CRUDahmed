﻿using Microsoft.AspNetCore.Mvc;

namespace CRUDahm.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}