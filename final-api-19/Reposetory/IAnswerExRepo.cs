using api_final_19.Dto;
using final_api_19.MainModels;

namespace api_final_19.Reposetory
{
    public interface IAnswerExRepo
    {
        
        AnswerEx1 GetAnswer1(FinalFContext context, string i);
        AnswerEx1 PostAnsEx(FinalFContext context,AnswerExDto a);
    }
}