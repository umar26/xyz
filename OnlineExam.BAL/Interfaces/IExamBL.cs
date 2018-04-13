using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DAL;
using OnlineExam.Model;

namespace OnlineExam.BAL
{
    interface IExamBL 
    {
        List<Exam> GetAllExam();
        List<ExamPaper> GetAllExamPaper();
    }
}
