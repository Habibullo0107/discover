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
            var user = new User()
            {
                Guid = Guid.NewGuid(),
                FullName = "Test",
                Login = "test",
                Password = "123",
                Status = UserStatus.Active
            };
            Add(user);


            var subject = new Subject() { Guid = Guid.NewGuid(), Name = "Алгебра" };
            var Topic = new Topic() { Guid = Guid.NewGuid(), Name = "Касрхо", Subject = subject };

            var question = new Question() { Guid = Guid.NewGuid(), QuestionText = "Каср чист?", Topic = Topic };

            var variantA = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question, VariantText = "Каср ин A..." };
            Add(variantA);

            var variantB = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question, VariantText = "Каср ин B..." };
            Add(variantB);

            var variantC = new Variant() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question, VariantText = "Каср ин C..." };
            Add(variantC);

            var variantD = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question, VariantText = "Каср ин D..." };
            Add(variantD);


            var javobB = new Answer() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question, Variant = variantC, User = user };
            Add(javobB);

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

            var answer = modelBuilder.Entity<Answer>();
            answer.HasKey(s => new { s.Guid });
            answer.HasOne(s => s.Question).WithMany(s => s.UserAnswers).HasForeignKey(s => s.QuestionId);
            answer.HasOne(s => s.User).WithMany(s => s.Answers).HasForeignKey(s => s.UserId);

            var topic = modelBuilder.Entity<Topic>();
            topic.HasKey(s => new { s.Guid });
            topic.HasOne(s => s.Subject).WithMany(s => s.Topics).HasForeignKey(s => s.SubjectId);
            topic.HasMany(s => s.Questions).WithOne(s => s.Topic).HasForeignKey(s => s.TopicId);

            var subject = modelBuilder.Entity<Subject>();
            subject.HasKey(s => new { s.Guid });
            subject.HasMany(s => s.Topics).WithOne(s => s.Subject).HasForeignKey(s => s.SubjectId);

            var question = modelBuilder.Entity<Question>();
            question.HasKey(s => new { s.Guid });
            question.HasMany(s => s.UserAnswers).WithOne(s => s.Question).HasForeignKey(s => s.QuestionId);
            question.HasOne(s => s.Topic).WithMany(s => s.Questions).HasForeignKey(s => s.TopicId);

            var variant = modelBuilder.Entity<Variant>();
            variant.HasKey(s => new { s.Guid });
            variant.HasOne(s => s.Question).WithMany(s => s.Variants).HasForeignKey(s => s.QuestionId);
        }

        public IQueryable<T> GetEntities<T>() where T : class
        {
            return Set<T>();
        }
    }
}
