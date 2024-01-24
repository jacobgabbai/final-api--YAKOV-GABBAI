using final_api_19.MainModels;

namespace api_final_19.Reposetory
{
    public interface IStudentRepo
    {
        Student GetStuName(FinalFContext context, Student j);
        Student PostStudent(FinalFContext context, StudentDtocs s);
    }
}