namespace DatabaseAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ValueObject;

    public partial class ExaminationContext : DbContext
    {
        public ExaminationContext()
            : base("name=ExaminationContextConn")
        {
        }

        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Examinee> Examinee { get; set; }
        public virtual DbSet<ExamTake> ExamTake { get; set; }
        public virtual DbSet<QuestionBank> QuestionBank { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<ExamineeResult> ExamineeResult { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>()
                .HasMany(e => e.ExamTake)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.QuestionBank)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Examinee>()
                .HasMany(e => e.ExamTake)
                .WithRequired(e => e.Examinee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExamTake>()
                .HasMany(e => e.ExamineeResult)
                .WithRequired(e => e.ExamTake)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuestionBank>()
                .HasMany(e => e.ExamineeResult)
                .WithRequired(e => e.QuestionBank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Exam)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
