using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GjirafaLMS.Models;
using Microsoft.AspNetCore.Http;
using GjirafaLMS.Data;
using GjirafaLMS.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Controllers
{
    public class MessageController : Controller
    {
        private readonly Queries _queries;
        private readonly UserManager<User> userManager;

        public MessageController(LMSContext context, UserManager<User> userManager)
        {
            _queries = new Queries(context, userManager);
            this.userManager = userManager;
        }

        [HttpPost("createPost")]
        public IActionResult LeaveMessage(ProfileViewModel profileView)
        {
            _queries.AddPost(profileView.Post, profileView.Post.UserIdTo);
            return RedirectToAction("Profile", "Account", new { userId = profileView.Post.UserIdTo });

        }

        [HttpPost("comment")]
        public IActionResult PostComment(ProfileViewModel profileView)
        {
            _queries.AddComment(profileView.Comment);
            return RedirectToAction("Profile", "Account", new { userId = profileView.Comment.ProfileOf });
        }

        [HttpGet("deletepost")]
        public IActionResult DeletePost(int postId, string userProfileId)
        {
            _queries.DeletePost(postId);
            return RedirectToAction("Profile", "Account", new { userId = userProfileId });
        }
    }
}
