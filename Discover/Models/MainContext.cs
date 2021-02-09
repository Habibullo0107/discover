using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Discover.Models
{
    public class MainContext : DbContext
    {
        public MainContext() : base()
        {
            var created = Database.EnsureCreated();

            if (created)
            {
                CreateTestData();
            }

            ChangeTracker.LazyLoadingEnabled = false;
        }

        void CreateTestData()
        {
            Add(new User() { Guid = Guid.NewGuid(), FullName = "Test", Login = "test", Password = "123", Status = UserStatus.Active });


            var subject = new Subject() { Guid = Guid.NewGuid(), Nom = "Алгебра" };
            var mavzu = new Mavzu() { Guid = Guid.NewGuid(), Nom = "Касрхо", Subject = subject };

            var test = new Test() { Guid = Guid.NewGuid(), QuestionText = "Каср чист?", Mavzu = mavzu };

            var javobA = new Javob() { Guid = Guid.NewGuid(), Durust = false, Test = test, JavobText = "Каср ин A...", Variant = Variant.A };
            Add(javobA);

            var javobB = new Javob() { Guid = Guid.NewGuid(), Durust = false, Test = test, JavobText = "Каср ин B...", Variant = Variant.B };
            Add(javobB);

            var javobC = new Javob() { Guid = Guid.NewGuid(), Durust = false, Test = test, JavobText = "Каср ин C...", Variant = Variant.C };
            Add(javobC);

            var javobD = new Javob() { Guid = Guid.NewGuid(), Durust = true, Test = test, JavobText = "Каср ин D...", Variant = Variant.D };
            Add(javobD);

            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=TestDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var user = modelBuilder.Entity<User>();
            user.HasKey(s => new { s.Guid });

            var javob = modelBuilder.Entity<Javob>();
            javob.HasKey(s => new { s.Guid });
            javob.HasOne(s => s.Test).WithMany(s => s.Javobho).HasForeignKey(s => s.TestId);

            var mavzu = modelBuilder.Entity<Mavzu>();
            mavzu.HasKey(s => new { s.Guid });
            mavzu.HasOne(s => s.Subject).WithMany(s => s.Mavzuho).HasForeignKey(s => s.SubjectId);
            mavzu.HasMany(s => s.Testho).WithOne(s => s.Mavzu).HasForeignKey(s => s.MavzuId);


            var subject = modelBuilder.Entity<Subject>();
            subject.HasKey(s => new { s.Guid });
            subject.HasMany(s => s.Mavzuho).WithOne(s => s.Subject).HasForeignKey(s => s.SubjectId);

            var test = modelBuilder.Entity<Test>();
            test.HasKey(s => new { s.Guid });
            test.HasMany(s => s.Javobho).WithOne(s => s.Test).HasForeignKey(s => s.TestId);
            test.HasOne(s => s.Mavzu).WithMany(s => s.Testho).HasForeignKey(s => s.MavzuId);
        }

        public IQueryable<T> GetEntities<T>() where T : class
        {
            return Set<T>();
        }
    }
}
