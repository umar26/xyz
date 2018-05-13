using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace OnlineExam.ViewModelMapper.ViewModels
{
  public  class QuestionAndChoiceVM
    {
        public List<SelectListItem> QuestionTypeList { get; set; }

        public List<SelectListItem> ExamPaperList { get; set; }

        public string QuestionText { get; set; }
        public OptionList Options { get; set;}
        public string SelectdAnswer { get; set; }

    }

    public class OptionList

    {
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
    }
}
