using Microsoft.EntityFrameworkCore;

namespace CourseWork.Models
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
            setRelationShips(modelBuilder);
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

        void setRelationShips(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collection>()
                .HasOne(p => p.User)
                .WithMany(b => b.Collections)
                .HasForeignKey(p => p.UserId)
                .IsRequired();
            modelBuilder.Entity<Collection>()
                .HasOne(p => p.Topic)
                .WithMany(b => b.Collections)
                .HasForeignKey(p => p.TopicId)
                .IsRequired();
            //modelBuilder.Entity<Field>()
            //    .HasOne(p => p.Collection)
            //    .WithMany(b => b.Fields)
            //    .HasForeignKey(p => p.CollectionId)
            //    .IsRequired();

            //modelBuilder.Entity<Collection>()
            //    .HasMany(p => p.Fields)
            //    .WithMany(p => p.Collections)
            //    .UsingEntity<CollectionFields>(
            //        j => j
            //            .HasOne(pt => pt.Field)
            //            .WithMany(p => p.CollectionFieldses)
            //            .HasForeignKey(pt => pt.FieldId),
            //        j => j
            //            .HasOne(pt => pt.Collection)
            //            .WithMany(t => t.CollectionFieldses)
            //            .HasForeignKey(pt => pt.CollectionId),
            //        j =>
            //        {
            //            //j.Property(pt => pt.PublicationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            //            j.HasKey(t => new { t.CollectionId, t.FieldId });
            //        });
        }
    }
}
