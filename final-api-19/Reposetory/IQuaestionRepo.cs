using final_api_19.MainModels;

namespace api_final_19.Reposetory
{
    public interface IQuaestionRepo
    {
        Question PostQuestion(FinalFContext context, QuestionDto3 v);
        int QuestionDelete(FinalFContext context,string id);
        List<Question> T3(FinalFContext context);
        List<Question> T31(FinalFContext context, string r);
       
        Question TQ1(FinalFContext context,QuestionDto3 v);
        Question TQ2(FinalFContext context, QuestionDto3 v);
    }
}