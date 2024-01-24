using final_api_19.MainModels;

namespace api_final_19.Reposetory
{
    public class QuaestionRepo : IQuaestionRepo
    {
        public List<Question> T3(FinalFContext context)
        {          
            Question F = new Question();
            List<Question> Y = context.Questions.ToList();
           return Y;

        }
        public List<Question> T31(FinalFContext context, string r)
        {            
            Question F = new Question();
            List<Question> Y = context.Questions.ToList();
            List<Question> U = Y.Where(f => f.TestIdRef == r).ToList();
            return U;
        }

        public Question TQ1(FinalFContext context, QuestionDto3 v)
        {           
            List<Question>? R = context.Questions.ToList();
            Question? tt = new Question();
            Test? rr = new Test();
            int i = 1;
            //if (R != null)
            //{
            //    foreach (Question a in R)
            //    {
            //        if (a.Id >= i)
            //        {
            //            i += 1;
            //        }

            //    }
            //}
            string guid = Guid.NewGuid().ToString();
            tt.Id = guid;
            tt.Picture = v.Picture;
            tt.TestIdRef = v.TestIdRef;
            tt.Questions = v.Questions;
            context.Questions.Add(tt);
            context.SaveChanges();
            return tt;
        }


        public int QuestionDelete(FinalFContext context, string id) {            
            List<Question>? R = context.Questions.ToList();
            Question? tt = new Question();
            tt = R.Where(x => x.Id == id).SingleOrDefault();
            if (tt != null)
            {
                context.Questions.Remove(tt);
                context.SaveChanges();
                return 1;
            }
            else return 0;
        }



        public Question TQ2(FinalFContext context, QuestionDto3 v)
        {
            
            List<Question>? R = context.Questions.ToList();
            Question? tt = new Question();
            tt = R.Where(x => x.Id == v.Id).SingleOrDefault();
            if (tt != null)
            {
                context.Questions.Remove(tt);
                context.SaveChanges();
                tt.Id = v.Id;
                tt.TestIdRef = v.TestIdRef;
                tt.Questions = v.Questions;
                if (v.Questions == "")
                {
                    tt.Picture = v.Picture;
                }
                else { v.Picture = null; }
            }
            context.Questions.Add(tt);
            context.SaveChanges();
            return tt;

        }

        public Question PostQuestion(FinalFContext context, QuestionDto3 v)
        {         
            List<Question>? R = context.Questions.ToList();
            Question? tt = new Question();
            long i = 0;
            //if (R.Count > 0)
            //{
            //    long e = R.Max(r => r.Id);
            //     i = 1 + e;
            //}
            //else {  i=1; }
            //tt.Id = i;
            string guid = Guid.NewGuid().ToString();
           tt.Id = guid;
            tt.TestIdRef = v.TestIdRef;
            tt.Questions = v.Questions;
            tt.Picture= v.Picture;
            context.Questions.Add(tt);
            context.SaveChanges();    
            return tt;
        }
    }
}
