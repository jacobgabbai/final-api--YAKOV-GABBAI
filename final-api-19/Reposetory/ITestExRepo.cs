using api_final_19.Dto;
using final_api_19.MainModels;

namespace api_final_19.Reposetory
{
    public interface ITestExRepo
    {
        List<TestEx1> GetByName1(FinalFContext context,string tname);
        int GetIdName(FinalFContext context,string sname, string stest);
        List<TestEx1> GetTestExes(FinalFContext context, string i);
        TestEx1 PostTestEx(FinalFContext context, TestExDto t);
        List<TestEx1>TestSearch(FinalFContext context,string g);
    }
}