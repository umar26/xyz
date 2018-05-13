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
        private readonly IRepository<QuestionType> _QuestionType;
        private readonly OnlineExamEntities _Entities;
        public ExamBL()
        {
            _Exam = new Repository<Exam>();
            _Exampaper = new Repository<ExamPaper>();
            _Entities = new OnlineExamEntities();
            _QuestionType = new Repository<QuestionType>();
        }


        public List<Exam> GetAllExam()
        {
            return _Exam.GetAll().ToList();
        }

        public List<ExamPaper> GetAllExamPaper()
        {
            return _Exampaper.GetAll().ToList();
        }

        public List<QuestionType>GetAllQuestionType()
        {
            return _QuestionType.GetAll().ToList();
        }
        public ObjectResult<uspInsertExam_Result> InsertExam(string Name)
        {
         return _Entities.uspInsertExam(Name);
        }

        public int InsertQuestionWithAnswer(int questiontype, int exampaperid, string questiontext, string chioce1, string chioce2, string chioce3, string chioce4, string answer)
        {
            try
            {
                  ObjectParameter QuestionId = new ObjectParameter("QUESTIONID", typeof(Int32));
                 _Entities.uspInsetQuestionWithAnswer(questiontype, exampaperid, questiontext, chioce1, chioce2, chioce3, chioce4, answer, QuestionId);

                return Convert.ToInt32(QuestionId.Value);
            }
            catch(Exception ex)
            {
                Exception s = ex.InnerException;
                return -1;
            }
        }

        public List<uspgetQuestionsByExamPaperId_Result> getQuestionsByExamPaperID(int exampaperid)
        {
            var result = _Entities.uspgetQuestionsByExamPaperId(exampaperid);
             return  result.ToList<uspgetQuestionsByExamPaperId_Result>();
        }

        public int InsertUserAnswer(int userid,int questionid, int choiceid,int exampaperid)
        {
            ObjectParameter UserAnswerID = new ObjectParameter("USERANSWERID", typeof(Int32));
            _Entities.uspInsertUserAnswer(userid, questionid, choiceid, exampaperid, UserAnswerID);
            return Convert.ToInt32(UserAnswerID.Value);
        }

        public int UpdateUserAnswer(int userAnswerId,int choiceId)
        {
           return _Entities.uspUpdateUserAnswerById(userAnswerId, choiceId);
        }

        public int SubmitAnswer(List<QuestionAnsModel> datatosave)
        {
            
            foreach (var item in datatosave)
            {

            }
        }

    }
}
