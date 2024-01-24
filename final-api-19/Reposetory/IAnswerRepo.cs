using final_api_19.MainModels;

namespace api_final_19.Reposetory
{
    public interface IAnswerRepo
    {
        Answer AnswerPut(FinalFContext context, AnswerDto1 v);
        List<Answer> GetAnswer(FinalFContext context);
        List<Answer> GetAnswer1(FinalFContext context, string j);
        void TAnswer(FinalFContext context,AnswerDto1 o);
    }
}