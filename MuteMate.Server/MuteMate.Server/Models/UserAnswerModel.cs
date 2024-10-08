﻿namespace MuteMate.Server.Models
{
    public class UserAnswerModel
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int QuestionId { get; set; }
        public QuestionModel? Question { get; set; }
        public int AnswerId { get; set; }
        public AnswerModel? Answer { get; set; }
    }
}
