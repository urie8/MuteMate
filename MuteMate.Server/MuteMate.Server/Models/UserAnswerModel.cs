namespace MuteMate.Server.Models
{
    public class UserAnswerModel
    {
        public int Id { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public int AnswerId { get; set; }
        public AnswerModel? Answer { get; set; } = null!;

        public bool isCorrect { get; set; }


    }
}
