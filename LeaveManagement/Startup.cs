using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using LeaveManagement.Models;
using Owin;
using System.Security.Claims;

[assembly: OwinStartupAttribute(typeof(LeaveManagement.Startup))]
namespace LeaveManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
		}


		/// <summary>
        /// Create default role "Admin", "Manager", "User" and admin account 
        /// </summary>
		private void CreateRolesandUsers()
		{
			ApplicationDbContext context = new ApplicationDbContext();

			var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
			var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


			// creating first Admin Role and creating a default Admin User 
			if (!roleManager.RoleExists("Admin"))
			{

                // Create admin role
                var role = new IdentityRole
                {
                    Name = "Admin"
                };
                roleManager.Create(role);

                // Admin is a super user who will maintain the website				

                var user = new ApplicationUser
                {
                    UserName = "TienDung",
                    Email = "tiendung@gmail.com"
                };

                var userPw = "Dung@123";

				var chkUser = UserManager.Create(user, userPw);

				//Add default User to Role Admin
				if (chkUser.Succeeded)
				{
					var result = UserManager.AddToRole(user.Id, "Admin");
				}
			}

			// creating Creating Manager role 
			if (!roleManager.RoleExists("Manager"))
			{
                var role = new IdentityRole
                {
                    Name = "Manager"
                };
                roleManager.Create(role);

			}

			// creating Creating Employee role 
			if (!roleManager.RoleExists("Employee"))
			{
                var role = new IdentityRole
                {
                    Name = "Employee"
                };
                roleManager.Create(role);

			}
		}
	}
}
