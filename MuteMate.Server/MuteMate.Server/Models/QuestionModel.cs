using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuteMate.Server.Models
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }
        [Column("question")]
        public string Question { get; set; } = null!;
        [Column("image")]
        public string Image { get; set; } = null!;
        [Column("category")]
        public string Category { get; set; } = null!;
        public List<AnswerModel> Answers { get; set; } = new();
    }
}
