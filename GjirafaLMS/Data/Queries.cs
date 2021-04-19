using System;
using System.Collections.Generic;
using System.Linq;
using GjirafaLMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace GjirafaLMS.Data
{
    public class Queries
    {
        private readonly LMSContext _dbContext;
        private readonly UserManager<User> userManager;

        public Queries(LMSContext context, UserManager<User> userManager)
        {
            _dbContext = context;
            this.userManager = userManager;
        }

        public Event GetEventById(int eventId)
        {
            Event eventModel = _dbContext.Events.Include(a => a.EventCreator).Include(a => a.Participants).ThenInclude(a => a.User).FirstOrDefault(a => a.EventId == eventId);
            return eventModel;
        }

        public List<Participant> GetJoinedEvents(string userId)
        {
            List<Participant> participants = _dbContext.Participants.Include(x => x.Event).Where(x => x.UserId == userId).ToList();
            return participants;
        }

        public List<Event> GetAllEvents()
        {
            List<Event> events = _dbContext.Events.Include(a => a.EventCreator).Include(a => a.Participants).ThenInclude(a => a.User)
            .Where(a => a.StartTime >= DateTime.Now).OrderByDescending(a => a.CreatedAt).ToList();
            return events;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = _dbContext.Users.ToList();
            return users;
        }

        public void AddEvent(Event eventModel, List<string> notificationForUserIds)
        {
            if (eventModel == null)
            {
                throw new ArgumentNullException(nameof(eventModel));
            }

            _dbContext.Events.Add(eventModel);
            _dbContext.SaveChanges();

            AddNotification(notificationForUserIds);
        }

        public List<Course> GetProfileViewCourses()
        {
            List<Course> courses = _dbContext.Courses.Include(c => c.Progresses).Include(c => c.Lectures).OrderByDescending(c => c.CreatedAt).ToList();
            return courses;
        }

        public void AddNotification(List<string> notificationForUserIds)
        {
            List<Event> eventsNotify = _dbContext.Events.Include(e => e.EventCreator).ToList();
            Event eventModel = eventsNotify.Last();
            foreach (var notif in notificationForUserIds)
            {
                Notification notification = new Notification();
                notification.NotificationTitle = $"Event: {eventModel.EventTitle} has been created by {eventModel.EventCreator.FirstName} {eventModel.EventCreator.LastName}";
                notification.NotificationForUserId = notif;
                notification.PathToURL = "events";
                _dbContext.Notifications.Add(notification);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteNotification(int notifId)
        {
            Notification notif = _dbContext.Notifications.FirstOrDefault(d => d.NotificationId == notifId);

            _dbContext.Notifications.Remove(notif);
            _dbContext.SaveChanges();
        }

        public void DeleteEvent(int eventId)
        {
            Event eventModel = _dbContext.Events.FirstOrDefault(d => d.EventId == eventId);

            _dbContext.Events.Remove(eventModel);
            _dbContext.SaveChanges();
        }

        public void LeaveEvent(string userId, int eventId)
        {
            Participant participant = _dbContext.Participants.FirstOrDefault(p => p.EventId == eventId && p.UserId == userId);

            _dbContext.Participants.Remove(participant);
            _dbContext.SaveChanges();
        }

        public void JoinEvent(string userId, int eventId)
        {
            Participant participant = new Participant();
            participant.EventId = eventId;
            participant.UserId = userId;

            _dbContext.Participants.Add(participant);
            _dbContext.SaveChanges();
        }

        public List<Post> GetAllPosts(string userId)
        {
            List<Post> posts = _dbContext.Posts.Include(p => p.UserFrom).Include(p => p.UserTo).Include(p => p.Comments).ThenInclude(c => c.User).Where(p => p.UserIdTo == userId).OrderByDescending(d => d.CreatedAt).ToList();
            return posts;
        }

        public void AddPost(Post post, string forUserId)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }
            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == post.UserIdFrom);
            Notification notification = new Notification();
            notification.NotificationTitle = $"{user.FirstName} {user.LastName} left a message for you";
            notification.NotificationForUserId = forUserId;
            notification.PathToURL = "profile";
            _dbContext.Notifications.Add(notification);
            _dbContext.SaveChanges();
        }

        public void AddComment(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            _dbContext.Comments.Add(comment);
            _dbContext.SaveChanges();
        }

        public void DeletePost(int postId)
        {
            Post post = _dbContext.Posts.FirstOrDefault(d => d.PostId == postId);

            _dbContext.Posts.Remove(post);
            _dbContext.SaveChanges();
        }
    }
}