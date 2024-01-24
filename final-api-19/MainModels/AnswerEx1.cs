using System;
using System.Collections.Generic;

namespace final_api_19.MainModels;

public partial class AnswerEx1
{
    public string Id { get; set; } = null!;

    public string? RightAnswer { get; set; }

    public string? WorngAnswer { get; set; }

    public string QuestionEx1IdRef { get; set; } = null!;

    public virtual QuestionEx QuestionEx1IdRefNavigation { get; set; } = null!;
}
