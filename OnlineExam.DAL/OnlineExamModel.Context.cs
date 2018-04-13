﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineExam.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using OnlineExam.Model;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OnlineExamEntities : DbContext
    {
        public OnlineExamEntities()
            : base("name=OnlineExamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamPaper> ExamPapers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<UserAnswer> UserAnswers { get; set; }
        public virtual DbSet<UserExam> UserExams { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<PERMISSION> PERMISSIONS { get; set; }
        public virtual DbSet<ROLE> ROLES { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
    
        public virtual ObjectResult<uspInsertExam_Result> uspInsertExam(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspInsertExam_Result>("uspInsertExam", nameParameter);
        }
    
        public virtual ObjectResult<ErrorInfo_Result> uspInsertExam1(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ErrorInfo_Result>("uspInsertExam1", nameParameter);
        }
    }
}
