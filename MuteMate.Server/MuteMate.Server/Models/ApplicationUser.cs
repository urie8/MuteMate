using Microsoft.AspNetCore.Identity;

namespace MuteMate.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserAnswerModel> UserAnswers { get; set; } = new List<UserAnswerModel>();

    }
}
