using api_final_19.Dto;
using final_api_19.MainModels;

namespace api_final_19.Reposetory
{
    public interface IQuestionExRepo
    {
        List<QuestionEx> GetQuestion3(FinalFContext context, string i);
        QuestionEx PostQueEx(FinalFContext context, QuestionExDto d);
    }
}