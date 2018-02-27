using LeaveManagement.Entity;
using LeaveManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace LeaveManagement.Controllers
{
    using ViewModels;

    public class HomeController : Controller
    {
        private readonly ICompanyService _companyService;

        public HomeController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public ActionResult Index()
        {
            var companies = _companyService.GetAll();
            var model = new Company
            {
                Name = "Test 123456",
                Contact = "Tiendu g"
            };

            _companyService.Add(model);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}