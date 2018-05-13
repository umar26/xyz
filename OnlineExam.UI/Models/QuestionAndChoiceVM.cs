using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OnlineExam.UI.Models
{
    //to Add Questions for Admin
  public  class QuestionAndChoiceVM
    {
        public QuestionAndChoiceVM()
        {
            QuestionTypeList = new List<SelectListItem>();
            ExamPaperList = new List<SelectListItem>();
            Options = new OptionList();
            Options.Option1 = Options.Option2 = Options.Option3 = Options.Option4 = string.Empty;
        }
        public List<SelectListItem> QuestionTypeList { get; set; }
        public string SelectedQuestionType { get; set; }

        public List<SelectListItem> ExamPaperList { get; set; }
        public string SelectedExamPaper { get; set;}
        public string QuestionText { get; set; }
        
        public OptionList Options { get; set;}
        public string SelectedAnswer { get; set; }

    }

    public class OptionList

    {
        public string Option1 { get; set; }
        public int IsAnswer1 { get; set; }
        public string Option2 { get; set; }
        public int IsAnswer2 { get; set; }
        public string Option3 { get; set; }
        public int IsAnswer3 { get; set; }
        public string Option4 { get; set; }
        public int IsAnswer4 { get; set; }
    }

    public class Option
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

    public class QuestionsForExam
    {
        public QuestionsForExam()
        {
            Choices = new List<Option>();
        }
        public string QuestionText { get; set; }
        public int QuestionId { get; set; }
        public int QuestionTypeID { get; set;}
        public List<Option> Choices { get; set; }
        public int SelectedAnswer { get; set; }
    }

   
}
