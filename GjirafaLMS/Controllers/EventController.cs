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
    public class EventController : Controller
    {
        private readonly Queries _queries;

        public EventController(LMSContext context, UserManager<User> userManager)
        {
            _queries = new Queries(context, userManager);
        }

        [HttpGet("events")]
        public IActionResult Events(string overlapp = "")
        {
            List<Event> events = _queries.GetAllEvents();
            ViewBag.ErrorMessage = overlapp;
            return View(events);
        }

        [HttpGet("addevent")]
        public IActionResult CreateEvent()
        {
            List<User> users = _queries.GetAllUsers();
            ViewBag.AllUsers = users;
            return View();
        }

        [HttpPost("createEvent")]
        public IActionResult SaveEvent(Event eventModel, List<string> NotificationForUserIds)
        {
            if (ModelState.IsValid)
            {
                eventModel.EndTime = EventHelper.CalculateDate(eventModel.StartTime, eventModel.Duration, eventModel.DurationType);
                _queries.AddEvent(eventModel, NotificationForUserIds);
                return RedirectToAction("Events");
            }
            List<User> users = _queries.GetAllUsers();
            ViewBag.AllUsers = users;
            return View("CreateEvent");
        }

        [HttpGet]
        public IActionResult DeleteEvent(int eventId)
        {
            _queries.DeleteEvent(eventId);
            return RedirectToAction("Events");
        }

        [HttpGet]
        public IActionResult GoToNotif(int notifId)
        {
            _queries.DeleteNotification(notifId);
            return RedirectToAction("Events");
        }

        [HttpGet]
        public IActionResult LeaveEvent(string userId, int eventId)
        {
            _queries.LeaveEvent(userId, eventId);
            return RedirectToAction("Events");
        }

        [HttpGet]
        public IActionResult JoinEvent(string userId, int eventId)
        {
            var eventModel = _queries.GetEventById(eventId);
            
            foreach (var participation in _queries.GetJoinedEvents(userId))
            {
                if ((eventModel.StartTime >= participation.Event.StartTime && eventModel.StartTime <= participation.Event.EndTime) || (eventModel.StartTime <= participation.Event.StartTime && eventModel.EndTime >= participation.Event.StartTime))
                {
                    return RedirectToAction("Events", new {overlapp = "Event is operlapping with other joined events."});
                }
            }
            _queries.JoinEvent(userId, eventId);
            return RedirectToAction("Events");
        }
    }
}
