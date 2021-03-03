using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
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

            ChangeTracker.LazyLoadingEnabled = true;
        }

        void CreateTestData()
        {
            #region User

            var user = new User()
            {
                Guid = Guid.NewGuid(),
                FullName = "Test",
                Login = "test",
                Password = "123",
                Status = UserStatus.Active
            };
            Add(user);

            #endregion

            #region Russian Subject

            var subjectRussian = new Subject() { Guid = Guid.NewGuid(), Name = "Русский язый" };

            #region topicFonetika
            var topic1Fonetika = new Topic() { Guid = Guid.NewGuid(), Name = "Фонетика", Subject = subjectRussian };
            


            #region s1


            var question1 = new Question() { Guid = Guid.NewGuid(), QuestionText = "В каком слове верно выделена буква, обозначающая ударный гласный звук?", Topic = topic1Fonetika };

            var variantA = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question1, VariantText = "набЕло" };
            Add(variantA);

            var variantB = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question1, VariantText = "НАдолго" };
            Add(variantB);

            var variantC = new Variant() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question1, VariantText = "надо Умить" };
            Add(variantC);

            var variantD = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question1, VariantText = "ОбеспечЕние" };
            Add(variantD);


            var javobB = new Answer() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question1, Variant = variantC, User = user };
            Add(javobB);
            #endregion


            #region s2

            var question2 = new Question() { Guid = Guid.NewGuid(), QuestionText = "В каком слове неверно выделена буква, обозначающая ударный гласный звук?", Topic = topic1Fonetika };

            var variantA2 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question2, VariantText = "подзАголовок" };
            Add(variantA2);

            var variantB2 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question2, VariantText = "простынЯ" };
            Add(variantB2);

            var variantC2 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question2, VariantText = "РакУшка" };
            Add(variantC2);

            var variantD2 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question2, VariantText = "сантимЕтр" };
            Add(variantD2);


            var javobB2 = new Answer() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question2, Variant = variantC, User = user };
            Add(javobB2);
            #endregion

            #region s3

            var question3 = new Question() { Guid = Guid.NewGuid(), QuestionText = "Имя существительное, употребляемое только во множественном числе:", Topic = topic1Fonetika };

            var variantA3 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question3, VariantText = "крестьянство" };
            Add(variantA3);

            var variantB3 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question3, VariantText = "перила" };
            Add(variantB3);

            var variantC3 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question3, VariantText = "старье" };
            Add(variantC3);

            var variantD3 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question3, VariantText = "аппаратура" };
            Add(variantD3);


            var javobB3 = new Answer() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question3, Variant = variantC, User = user };
            Add(javobB3);
            #endregion
            #endregion

            #region topicSintaksis
            var topic2Sintaksis = new Topic() { Guid = Guid.NewGuid(), Name = "Синтаксис", Subject = subjectRussian };

            #region s4

            var question4 = new Question() { Guid = Guid.NewGuid(), QuestionText = "Укажите слово, в котором есть мягкий согласный звук.", Topic = topic2Sintaksis };

             Add(new Variant() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question4, VariantText = "Мощь" });

            var variantB4 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question4, VariantText = "Блажь" };
            Add(variantB4);

            var variantC4 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question4, VariantText = "муж" };
            Add(variantC4);

            var variantD4 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question4, VariantText = "наотмашь" };
            Add(variantD4);


            var javobA4 = new Answer() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question4, Variant = variantC, User = user };
            Add(javobA4);
            #endregion
            #region s5
            var question5 = new Question() { Guid = Guid.NewGuid(), QuestionText = "Указать слово, образованное по модели: корень-суффикс-суффикс-окончание.", Topic = topic2Sintaksis };

            var variantA5 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question5, VariantText = "Первенство" };
            Add(variantA5);

            var variantB5 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question5, VariantText = "Холодно" };
            Add(variantB5);

            var variantC5 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question5, VariantText = "Застывший" };
            Add(variantC5);

            var variantD5 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question5, VariantText = "Упражнение" };
            Add(variantD5);


            var javobC5 = new Answer() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question5, Variant = variantC, User = user };
            Add(javobC5);
            #endregion
            #endregion

            #region topic_True_Writing
            var topic3_Writing = new Topic() { Guid = Guid.NewGuid(), Name = "Правописание наречий", Subject = subjectRussian };
            #region s6
            var question6 = new Question() { Guid = Guid.NewGuid(), QuestionText = "В каком ряду все наречия пишутся с НЕ раздельно?", Topic = topic3_Writing };

            var variantA6 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question6, VariantText = "(не)уклюжие, (не)по-дружески" };
            Add(variantA6);

            var variantB6 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question6, VariantText = "ничуть (не)весело; (не)глубоко, а мелко" };
            Add(variantB6);

            var variantC6 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question6, VariantText = "(не)тепло, а холодно; говорил (не)громко" };
            Add(variantC6);

            var variantD6 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question6, VariantText = "вовсе (не)интересно, (не)брежно" };
            Add(variantD6);


            var javobA6 = new Answer() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question6, Variant = variantC, User = user };
            Add(javobA6);
            #endregion
            #region s7
            var question7 = new Question() { Guid = Guid.NewGuid(), QuestionText = "В каком ряду все наречия пишутся с суффиксом -А?", Topic = topic3_Writing };

            var variantA7 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question7, VariantText = " засветл..., направ..., дочист..." };
            Add(variantA7);

            var variantB7 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question7, VariantText = "досух..., справ..., издавн..." };
            Add(variantB7);

            var variantC7 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question7, VariantText = "затемн..., снов..., досыт..." };
            Add(variantC7);

            var variantD7 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question7, VariantText = "сначал..., надолг..., слев..." };
            Add(variantD7);


            var javobA7 = new Answer() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question7, Variant = variantC, User = user };
            Add(javobA7);
            #endregion
            #region s8
            var question8 = new Question() { Guid = Guid.NewGuid(), QuestionText = "Укажите слово с ошибкой:", Topic = topic3_Writing };

            var variantA8 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question8, VariantText = "медленно" };
            Add(variantA8);

            var variantB8 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question8, VariantText = "на лево" };
            Add(variantB8);

            var variantC8 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question8, VariantText = "справа" };
            Add(variantC8);

            var variantD8 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question8, VariantText = "по-хорошему" };
            Add(variantD8);


            var javobA8 = new Answer() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question8, Variant = variantC, User = user };
            Add(javobA8);
            #endregion
            #endregion
            #endregion

            #region English Subject

            var subjectEnglish = new Subject() { Guid = Guid.NewGuid(), Name = "Английский язый" };
            #region topic1 Travel
            var topic4Travel = new Topic() { Guid = Guid.NewGuid(), Name = "Travel", Subject = subjectEnglish };
            #region s9
            var question9 = new Question() { Guid = Guid.NewGuid(), QuestionText = "Choose the appropriate verb. (Выберите подходящий по смыслу глагол.) \n  The father often ... kectures in universities. ", Topic = topic4Travel };

            var variantA9 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question9, VariantText = "gives" };
            Add(variantA9);

            var variantB9 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question9, VariantText = "takes" };
            Add(variantB9);

            var variantC9 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question9, VariantText = "invites" };
            Add(variantC9);

            var variantD9 = new Variant() { Guid = Guid.NewGuid(), IsCorrect = false, Question = question9, VariantText = "passes" };
            Add(variantD9);


            var javobA9 = new Answer() { Guid = Guid.NewGuid(), IsCorrect = true, Question = question9, Variant = variantC, User = user };
            Add(javobA9);
            #endregion


            #endregion
            #endregion




            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=TestDB14.db");
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
