using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GjirafaLMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using GjirafaLMS.Data;
using Microsoft.EntityFrameworkCore;

namespace GjirafaLMS.Controllers
{
    public class DashboardController : Controller
    {
        private readonly LMSContext context;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public DashboardController(LMSContext context, UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [HttpGet("dashboard")]
        [Authorize]
        public async Task<IActionResult> Dashboard()
        {
            DashboardViewModel dashboard = new DashboardViewModel();
            dashboard.Courses = context.Courses.Include(c => c.Progresses).Include(c => c.Lectures).OrderByDescending(c => c.CreatedAt).ToList();
            var role = context.Roles.FirstOrDefault(r => r.Name == "Basic");
            if (role == null)
            {
                IdentityRole identityRole = new IdentityRole { Name = "Basic" };
                IdentityResult roleres = await roleManager.CreateAsync(identityRole);
                var startRole = context.Roles.FirstOrDefault(r => r.Name == "Basic");
                dashboard.AllUsers = context.UserRoles.Where(r => r.RoleId == startRole.Id).Count();
                List<Completed> progress2 = context.CompletedLectures.Include(c => c.Course).Include(c => c.CompletedLecture).Include(c => c.CompletedByUser).Where(c => c.CompletedByUserId == userManager.GetUserAsync(User).Result.Id).ToList();
                dashboard.Progress = progress2;
                return View(dashboard);
            }
            dashboard.AllUsers = context.UserRoles.Where(r => r.RoleId == role.Id).Count();
            List<Completed> progress = context.CompletedLectures.Include(c => c.Course).Include(c => c.CompletedLecture).Include(c => c.CompletedByUser).Where(c => c.CompletedByUserId == userManager.GetUserAsync(User).Result.Id).ToList();
            List<Participant> events = context.Participants.Include(p => p.Event).Where(p => p.UserId == userManager.GetUserAsync(User).Result.Id).ToList();
            dashboard.Progress = progress;
            dashboard.JoinedEvents = events;
            return View(dashboard);
        }

        [HttpGet("allnotifications")]
        public IActionResult AllNotifications()
        {
            return View();
        }

    }
}
