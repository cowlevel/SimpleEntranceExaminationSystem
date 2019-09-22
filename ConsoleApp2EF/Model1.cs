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

        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Examinee> Examinee { get; set; }
        public virtual DbSet<ExamineeTake> ExamineeTake { get; set; }
        public virtual DbSet<QuestionBank> QuestionBank { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<SystemUser> SystemUser { get; set; }
        public virtual DbSet<ExamineeResult> ExamineeResult { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>()
                .HasMany(e => e.ExamineeTake)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.QuestionBank)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Examinee>()
                .HasMany(e => e.ExamineeTake)
                .WithRequired(e => e.Examinee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExamineeTake>()
                .HasMany(e => e.ExamineeResult)
                .WithRequired(e => e.ExamineeTake)
                .HasForeignKey(e => e.ExamTakeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuestionBank>()
                .HasMany(e => e.ExamineeResult)
                .WithRequired(e => e.QuestionBank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemUser>()
                .HasMany(e => e.Exam)
                .WithRequired(e => e.SystemUser)
                .WillCascadeOnDelete(false);
        }
    }
}
