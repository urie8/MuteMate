using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuteMate.Server.Models
{
    public class AnswerModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("answer")]
        public string Answer { get; set; } = null!;

        [Column("is_correct")]
        public bool IsCorrect { get; set; }

        [Column("question_id")]
        public int QuestionId { get; set; }

        //Navigation property
        public QuestionModel? Question { get; set; }
    }
}
