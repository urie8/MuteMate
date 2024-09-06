namespace MuteMate.Server.Models
{
    public class UserAnswerModel
    {
        public int Id { get; set; }

        public string UserId { get; set; } = null!;

        public int AnswerId { get; set; }

        public bool isCorrect { get; set; }

        // Navigation properties
        public AnswerModel Answer { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;

    }
}
