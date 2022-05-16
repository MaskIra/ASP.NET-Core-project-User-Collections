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
            SetAdmin(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        void SetAdmin(ModelBuilder modelBuilder)
        {
            User adminUser = new User { Id = 1, Email = "admin", Password = "admin", Role = "admin" };
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });

            Topic topic1 = new Topic { Id = 1, Name = "All" };
            Topic topic2 = new Topic { Id = 2, Name = "Books" };
            Topic topic3 = new Topic { Id = 3, Name = "Alcohol" };
            Topic topic4 = new Topic { Id = 4, Name = "Nature" };
            Topic topic5 = new Topic { Id = 5, Name = "Animals" };
            modelBuilder.Entity<Topic>().HasData(new Topic[] { topic1, topic2, topic3, topic4, topic5 });
        }
    }
}
