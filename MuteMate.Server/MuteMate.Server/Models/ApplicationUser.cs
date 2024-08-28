using Microsoft.AspNetCore.Identity;

namespace MuteMate.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Navigation property for the user's answers
        public ICollection<UserAnswerModel> UserAnswers { get; set; } = new List<UserAnswerModel>(); /// vill man new:a upp den varje gång?



    }
}
