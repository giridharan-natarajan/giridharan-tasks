using Adodotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Adodotnet.DAL;
namespace Adodotnet.Controllers
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
            CustomerDAL custDAL = new CustomerDAL();
            List<Customer> CustomerList = new List<Customer>();
            CustomerList = custDAL.GetAllCustomers();
            return View(CustomerList);
        }
        [Route("Home/Insert")]
        public IActionResult Insert()
        {
          
            return View();
        }
        public IActionResult NewCustomer(Customer cust)
        {
            CustomerDAL mobj = new CustomerDAL();
            int result = mobj.NewCustomer(cust);
            if (result == 1)
                return RedirectToAction("Index");
            else
                return View("Insert");
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
