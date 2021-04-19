using GjirafaLMS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GjirafaLMS.Data
{
    public class LMSContext : IdentityDbContext<User>
    {
        public LMSContext(DbContextOptions<LMSContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Completed>(x => x.HasOne<Lecture>(y => y.CompletedLecture).WithMany(y => y.CompletedLectures).HasForeignKey(y => y.CompletedLectureId).OnDelete(DeleteBehavior.Cascade));
            modelBuilder.Entity<Completed>(x => x.HasOne<Course>(y => y.Course).WithMany(y => y.Progresses).HasForeignKey(y => y.CourseId).OnDelete(DeleteBehavior.Cascade));
            modelBuilder.Entity<Completed>(x => x.HasOne<User>(y => y.CompletedByUser).WithMany(y => y.CompletedLectures).HasForeignKey(y => y.CompletedByUserId).OnDelete(DeleteBehavior.Cascade));
            modelBuilder.Entity<Lecture>(x => x.HasOne<Course>(y => y.Course).WithMany(y => y.Lectures).HasForeignKey(y => y.CourseId).OnDelete(DeleteBehavior.Cascade));
            modelBuilder.Entity<Course>(x => x.HasOne<User>(y => y.CourseInstructor).WithMany(y => y.CourseInstructors).HasForeignKey(y => y.CourseInstructorId).OnDelete(DeleteBehavior.Cascade));
            modelBuilder.Entity<Notification>(x => x.HasOne<User>(y => y.NotificationForUser).WithMany(y => y.Notifications).HasForeignKey(y => y.NotificationForUserId).OnDelete(DeleteBehavior.Cascade));
            modelBuilder.Entity<Comment>(x => x.HasOne<User>(y => y.User).WithMany(y => y.Comments).HasForeignKey(y => y.UserId).OnDelete(DeleteBehavior.Cascade));
            modelBuilder.Entity<Comment>(x => x.HasOne<Post>(y => y.Post).WithMany(y => y.Comments).HasForeignKey(y => y.PostId).OnDelete(DeleteBehavior.Cascade));
            modelBuilder.Entity<Post>(x => x.HasOne<User>(y => y.UserTo).WithMany(y => y.PostsTo).HasForeignKey(y => y.UserIdTo).OnDelete(DeleteBehavior.Cascade));
            modelBuilder.Entity<Post>(x => x.HasOne<User>(y => y.UserFrom).WithMany(y => y.PostsFrom).HasForeignKey(y => y.UserIdFrom).OnDelete(DeleteBehavior.Cascade));
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Completed> CompletedLectures { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}