//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineExam.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAnswer
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public Nullable<int> ChoiceID { get; set; }
        public string Answer { get; set; }
        public Nullable<int> ExamPaperID { get; set; }
    
        public virtual Choice Choice { get; set; }
        public virtual ExamPaper ExamPaper { get; set; }
        public virtual Question Question { get; set; }
    }
}
