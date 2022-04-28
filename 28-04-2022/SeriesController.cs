using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity1.Models;
namespace Entity1.Controllers
{
    public class SeriesController : Controller
    {
        [Route("Series/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Series/Create")]
        public IActionResult Create(Series s)
        {

            if (ModelState.IsValid)
            {
                SeriesDBContext dBContext = new SeriesDBContext();
                dBContext.Add(s);
                dBContext.SaveChanges();
                return Content("Saved");
            }
            else
            {
                return View("Index");
            }
        }
    }
}

