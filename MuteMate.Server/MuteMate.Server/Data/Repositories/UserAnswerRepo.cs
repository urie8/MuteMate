using Microsoft.EntityFrameworkCore;
using MuteMate.Server.Models;

namespace MuteMate.Server.Data.Repositories
{
    public class UserAnswerRepo
    {

        private readonly MuteMateGenericRepository<UserAnswerRepo> _repository;

        public UserAnswerRepo(MuteMateGenericRepository<UserAnswerRepo> repository)
        {
            _repository = repository;
        }
        public async Task<List<AnswerModel>> GetCorrectAnswersForUserAsync(string userId) //total bananas points
        {
            var correctAnswers = await _repository.Context.UserAnswers
                .Where(ua => ua.UserId == userId && ua.isCorrect)
                .Select(ua => ua.Answer)
                .ToListAsync();

            return correctAnswers;
        }


        //Hämta userns correct answers för category Colors

        public async Task<List<AnswerModel>> GetCorrectAnswersForCategoryColorsAsync(string userId)
        {
            return await _repository.Context.UserAnswers
            .Where(ua => ua.UserId == userId && ua.isCorrect && ua.Answer.Question.Category == "Colors")
            .Include(ua => ua.Answer)
            .ThenInclude(a => a.Question)
            .Select(ua => ua.Answer)
            .ToListAsync();
        }


        //Hämta userns correct answers för category Letters

        public async Task<List<AnswerModel>> GetCorrectAnswersForCategoryLettersAsync(string userId)
        {
            return await _repository.Context.UserAnswers
            .Where(ua => ua.UserId == userId && ua.isCorrect && ua.Answer.Question.Category == "Letters")
            .Include(ua => ua.Answer)
            .ThenInclude(a => a.Question)
            .Select(ua => ua.Answer)
            .ToListAsync();
        }



        //Hämta userns correct answers för category Animals

        public async Task<List<AnswerModel>> GetCorrectAnswersForCategoryAnimalsAsync(string userId)
        {
            return await _repository.Context.UserAnswers
            .Where(ua => ua.UserId == userId && ua.isCorrect && ua.Answer.Question.Category == "Animals")
            .Include(ua => ua.Answer)
            .ThenInclude(a => a.Question)
            .Select(ua => ua.Answer)
            .ToListAsync();
        }

        public async Task<List<UserAnswerModel>> PostCorrectAnswersAsync(List<UserAnswerModel> userAnswers)
        {
            await _context.UserAnswers.AddRangeAsync(userAnswers);
            await _context.SaveChangesAsync();
            return userAnswers;
        }
    }
}
