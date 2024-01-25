using api_final_19.Dto;
using final_api_19.MainModels;

namespace api_final_19.Reposetory
{
    public class QuestionExRepo : IQuestionExRepo
    {
        public QuestionEx PostQueEx(FinalFContext context, QuestionExDto d)
        {          
            List<QuestionEx> q = new List<QuestionEx>();
            QuestionEx qq = new QuestionEx();
            q = context.QuestionExes.ToList();
      
            string guid = Guid.NewGuid().ToString();
            qq.Id = guid;
            qq.TestEx1IdRef = d.TestEx1IdRef;
            qq.Questions = d.Questions;
            context.QuestionExes.Add(qq);
            context.SaveChanges();
            return qq;

        }



        public List<QuestionEx> GetQuestion3(FinalFContext context,string i)
        {         
            List<QuestionEx> q = new List<QuestionEx>();
            QuestionEx qq = new QuestionEx();
            q = context.QuestionExes.Where(r => r.TestEx1IdRef == i).ToList();
            return q;
        }
    }
}
