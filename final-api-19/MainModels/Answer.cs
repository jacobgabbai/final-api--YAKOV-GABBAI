using System;
using System.Collections.Generic;

namespace final_api_19.MainModels;

public partial class Answer
{
    public string Id { get; set; } = null!;

    public string Answer1 { get; set; } = null!;

    public string QuestionIdRef { get; set; } = null!;

    public double RightWorng { get; set; }

    public virtual Question QuestionIdRefNavigation { get; set; } = null!;
}
