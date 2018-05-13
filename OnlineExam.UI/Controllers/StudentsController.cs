using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineExam.BAL;
using OnlineExam.Model;
using OnlineExam.UI.Utility;
using OnlineExam.UI.Models;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace OnlineExam.UI.Controllers
{
    public class StudentsController : Controller
    {
        private ExamBL _ExamBL;
        public StudentsController()
        {
            _ExamBL = new ExamBL();
        }

        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QuestionsForExam()
        {
           List<uspgetQuestionsByExamPaperId_Result> Questions= _ExamBL.getQuestionsByExamPaperID(3);
            List<QuestionsForExam> Model = new List<Models.QuestionsForExam>();

           
            //    Questions.GroupBy(r=>r.QuestionID)
            var c = from q in Questions
                    group q by q.QuestionID into g
                    select new
                    {
                        QuestionId = g.Key,
                        QuestionText = g.Select(r => r.QuestionText).FirstOrDefault(),
                        QuestionTypeID = g.Select(r => r.QuestionTypeID).FirstOrDefault(),
                        ExampaperID = g.Select(r => r.ExamPaperID).FirstOrDefault(),
                        Choiceids = g.Select(r=>r.ChioceID),
                        ChoiceText=g.Select(r=>r.ChoiceText)

                    };
            foreach (var item in c)
            {
                QuestionsForExam qe = new Models.QuestionsForExam();
                qe.QuestionId = item.QuestionId;
                qe.QuestionText = item.QuestionText;
                qe.QuestionTypeID = item.QuestionTypeID;

                   var choiceids=   item.Choiceids.ToArray();
                   var choicetext = item.ChoiceText.ToArray();

                for (int i = 0; i < choiceids.Length; i++)
                {
                    qe.Choices.Add(new Option()
                    {
                        Id = choiceids[i],
                        Text=choicetext[i]
                    });
                }

                Model.Add(qe);
            }

            return View(Model);           

        }

      
        [HttpPost]
        public ActionResult SaveUserQuestionAnswer(string QuestionId,string ChoiceID,string UserAnswerId)
        {
           
            if (UserAnswerId != "0")
            {
                _ExamBL.UpdateUserAnswer(Convert.ToInt32(UserAnswerId), Convert.ToInt32(ChoiceID));
                return new EmptyResult();
            }
            else
            {
               int  userAnswerId = _ExamBL.InsertUserAnswer(1, Convert.ToInt32(QuestionId), Convert.ToInt32(ChoiceID), 3);
                return Content(userAnswerId.ToString());
            }
          

           
        }

        [HttpPost]
        public ActionResult SubmitAnswers(string QuestionAns)
        {
            //   var js = new JavaScriptSerializer();
            //var model=  (object[]) js.DeserializeObject(QuestionAns);

            var x=JsonConvert.DeserializeObject<List<QuestionAnsModel>>(QuestionAns);
            
            return new EmptyResult();

        }

       


    }
}