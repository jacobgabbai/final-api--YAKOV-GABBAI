using System;
using System.Collections.Generic;

namespace final_api_19.MainModels;

public partial class QuestionEx
{
    public string Id { get; set; } = null!;

    public string TestEx1IdRef { get; set; } = null!;

    public string Questions { get; set; } = null!;

    public virtual ICollection<AnswerEx1> AnswerEx1s { get; set; } = new List<AnswerEx1>();

    public virtual TestEx1 TestEx1IdRefNavigation { get; set; } = null!;
}
