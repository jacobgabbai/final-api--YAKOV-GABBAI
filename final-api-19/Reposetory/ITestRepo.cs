using final_api_19.MainModels;

namespace api_final_19.Reposetory
{
    public interface ITestRepo
    {
        Test PutTest1(FinalFContext context,Test2Dto p);
        List<Test> T2(FinalFContext h);
        Test T21(FinalFContext context, string i, string v);
        Test T211(FinalFContext context, string i, string v);
        Test T22(FinalFContext context, string v);
        Test? T23(FinalFContext context, string name);
        int T24(FinalFContext context, Test1 t);
        Test T33(FinalFContext context, string v);
        Test TB1(FinalFContext context, Test1 z);
        int TestDelete(FinalFContext context, string i);
    }
}