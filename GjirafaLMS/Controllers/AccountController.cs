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
    public class AccountController : Controller
    {
        private readonly Queries _queries;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<User> signInManager;
        private readonly LMSContext context;

        public AccountController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager, LMSContext context)
        {
            _queries = new Queries(context, userManager);
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                if (!userManager.Users.Any())
                {
                    var user = new User { FirstName = registerViewModel.FirstName, LastName = registerViewModel.LastName, ProfileImgUrl = registerViewModel.ProfileImgUrl, UserName = registerViewModel.Email, Email = registerViewModel.Email, Address = registerViewModel.Address, City = registerViewModel.City, Country = registerViewModel.Country };
                    var result = await userManager.CreateAsync(user, registerViewModel.Password);
                    if (result.Succeeded)
                    {
                        IdentityRole identityRole = new IdentityRole { Name = "Admin" };
                        IdentityResult roleres = await roleManager.CreateAsync(identityRole);
                        var assignrole = await userManager.AddToRoleAsync(user, "Admin");
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Dashboard", "Dashboard");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                else
                {
                    var user = new User { FirstName = registerViewModel.FirstName, LastName = registerViewModel.LastName, ProfileImgUrl = registerViewModel.ProfileImgUrl, UserName = registerViewModel.Email, Email = registerViewModel.Email, Address = registerViewModel.Address, City = registerViewModel.City, Country = registerViewModel.Country };
                    var result = await userManager.CreateAsync(user, registerViewModel.Password);
                    if (result.Succeeded)
                    {
                        var assignrole = await userManager.AddToRoleAsync(user, "Basic");
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Dashboard", "Dashboard");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }


            }

            return View(registerViewModel);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, loginViewModel.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Dashboard", "Dashboard");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt");
            }

            return View(loginViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Dashboard", "Dashboard");
        }

        [HttpGet("profile/{userId}")]
        public async Task<IActionResult> Profile(string userId)
        {
            ProfileViewModel profileView = new ProfileViewModel();
            profileView.courses = context.Courses.Include(c => c.Progresses).Include(c => c.Lectures).OrderByDescending(c => c.CreatedAt).ToList();
            profileView.user = await userManager.FindByIdAsync(userId);
            var role = context.UserRoles.FirstOrDefault(u => u.UserId == profileView.user.Id);
            profileView.userRole = await roleManager.GetRoleNameAsync(context.Roles.FirstOrDefault(r => r.Id == role.RoleId));
            profileView.Posts = _queries.GetAllPosts(userId);
            return View(profileView);
        }

        [HttpGet("edit")]
        public IActionResult EditProfile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditLocation(EditLocationModel editLocation)
        {
            User user = await userManager.FindByIdAsync(editLocation.LocUserId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with UserId {editLocation.LocUserId} was not found!";
                return View("NotFound");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    user.Address = editLocation.LocAddress;
                    user.City = editLocation.LocCity;
                    user.Country = editLocation.LocCountry;

                    var result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Profile", new {userId = user.Id});
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View("EditProfile");
                }

                return View("EditProfile");
            }

        }

        [HttpPost]
        public async Task<IActionResult> EditInfo(EditInfoModel editInfo)
        {
            User user = await userManager.FindByIdAsync(editInfo.InfoUserId);
            var userEmail = await userManager.FindByEmailAsync(editInfo.InfoEmail);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with UserId {editInfo.InfoUserId} was not found!";
                return View("NotFound");
            }
            else if ((userManager.GetUserAsync(User).Result.Email != editInfo.InfoEmail) && (userEmail != null))
            {
                ModelState.AddModelError("InfoEmail", "Email already in use!");
                return View("EditProfile");
            }
            else if (ModelState.IsValid)
            {
                user.FirstName = editInfo.InfoFirstName;
                user.LastName = editInfo.InfoLastName;
                user.Email = editInfo.InfoEmail;
                user.ProfileImgUrl = editInfo.InfoProfileImgUrl;

                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Profile", new {userId = user.Id});
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View("EditProfile");
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel changePassword)
        {
            User user = await userManager.FindByIdAsync(changePassword.UserId);
            if (ModelState.IsValid)
            {
                var result = await userManager.ChangePasswordAsync(user, changePassword.CurrentPassword, changePassword.NewPassword);
                if (result.Succeeded)
                {
                    return RedirectToAction("Profile", new {userId = user.Id});
                }
            }
            return View("EditProfile");
        }

        [HttpGet("users")]
        [AllowAnonymous]
        public IActionResult AllUsers()
        {
            List<User> users = context.Users.ToList();
            
            return View(users);
        }

        [HttpGet("adduser")]
        [AllowAnonymous]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GoToMessage(int notifId, string userId)
        {
            _queries.DeleteNotification(notifId);
            return RedirectToAction("Profile", new {userId = userId});
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
