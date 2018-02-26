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
        private readonly ICompanyService companyService;

        public HomeController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        public ActionResult Index()
        {
            var companies = companyService.GetAllCompanies();
            var companiesViewModel = Mapper.Map<IEnumerable<Company>, IEnumerable<CompanyViewModel>>(companies);
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