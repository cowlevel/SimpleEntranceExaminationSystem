namespace ConsoleApp2EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Examinee> Examinees { get; set; }
        public virtual DbSet<ExamTake> ExamTakes { get; set; }
        public virtual DbSet<QuestionBank> QuestionBanks { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ExamineeResult> ExamineeResults { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>()
                .HasMany(e => e.ExamTakes)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.QuestionBanks)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Examinee>()
                .HasMany(e => e.ExamTakes)
                .WithRequired(e => e.Examinee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExamTake>()
                .HasMany(e => e.ExamineeResults)
                .WithRequired(e => e.ExamTake)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuestionBank>()
                .HasMany(e => e.ExamineeResults)
                .WithRequired(e => e.QuestionBank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Exams)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
