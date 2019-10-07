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
        public virtual DbSet<ExamineeAnswer> ExamineeAnswer { get; set; }
        public virtual DbSet<ExamineeExam> ExamineeExam { get; set; }
        public virtual DbSet<ExamineeFailure> ExamineeFailure { get; set; }
        public virtual DbSet<ExamineeTake> ExamineeTake { get; set; }
        public virtual DbSet<PassingRate> PassingRate { get; set; }
        public virtual DbSet<QuestionBank> QuestionBank { get; set; }
        public virtual DbSet<QuestionBankHistory> QuestionBankHistory { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<SystemUser> SystemUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>()
                .HasMany(e => e.ExamineeExam)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Examinee>()
                .HasMany(e => e.ExamineeTake)
                .WithRequired(e => e.Examinee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExamineeExam>()
                .HasMany(e => e.ExamineeAnswer)
                .WithRequired(e => e.ExamineeExam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExamineeTake>()
                .HasMany(e => e.ExamineeExam)
                .WithRequired(e => e.ExamineeTake)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuestionBank>()
                .HasMany(e => e.ExamineeAnswer)
                .WithRequired(e => e.QuestionBank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Exam)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUser>()
                .HasMany(e => e.Exam)
                .WithRequired(e => e.SystemUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUser>()
                .HasMany(e => e.ExamineeFailure)
                .WithRequired(e => e.SystemUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUser>()
                .HasMany(e => e.PassingRate)
                .WithRequired(e => e.SystemUser)
                .WillCascadeOnDelete(false);
        }
    }
}