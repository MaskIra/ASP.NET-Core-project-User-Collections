using Microsoft.EntityFrameworkCore;

namespace CourseWork.Models.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Collection> Collections { get; set; }

        public DbSet<Field> Fields { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            setAdmin(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        void setAdmin(ModelBuilder modelBuilder)
        {
            User adminUser = new User { Id = 1, Email = "admin", Password = "admin", Role = "admin" };
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });

            Topic t = new Topic { Id = 1, Name = "Books" };
            Topic tt = new Topic { Id = 2, Name = "All" };
            modelBuilder.Entity<Topic>().HasData(new Topic[] { t, tt });
        }
    }
}
