using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DAL;
using OnlineExam.Model;
using System.Data.Entity.Core.Objects;

namespace OnlineExam.BAL
{
  public  class ExamBL : IExamBL
    {
        private readonly IRepository<Exam> _Exam;
        private readonly IRepository<ExamPaper> _Exampaper;
        private readonly OnlineExamEntities _Entities;
        public ExamBL(IRepository<Exam> Exam, IRepository<ExamPaper> ExamPaper)
        {
            _Exam = new Repository<Exam>();
            _Exampaper = new Repository<ExamPaper>();
            _Entities = new OnlineExamEntities();
        }


        public List<Exam> GetAllExam()
        {
            return _Exam.GetAll().ToList();
        }

        public List<ExamPaper> GetAllExamPaper()
        {
            return _Exampaper.GetAll().ToList();
        }

        public ObjectResult<ErrorInfo_Result> InsertExam(string Name)
        {
         return _Entities.uspInsertExam1(Name);
        }
    }
}
