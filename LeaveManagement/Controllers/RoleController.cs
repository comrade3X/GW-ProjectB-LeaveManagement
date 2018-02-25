using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeaveManagement.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        ApplicationDbContext context;

        #region Ctor

        public RoleController()
        {
            context = new ApplicationDbContext();
        }

        #endregion

        #region Action Methods

        /// <summary>
        /// Get All Roles
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //	if (!IsAdminUser())
            //	{
            //		return RedirectToAction("Index", "Home");
            //	}
            //}
            //else
            //{
            //	return RedirectToAction("Index", "Home");
            //}

            var model = context.Roles.ToList();
            return View(model);
        }

        public ActionResult Create()
        {

            var Role = new IdentityRole();
            return View(Role);
        }

        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion

        #region Private Methods

        private Boolean IsAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        #endregion
    }
}