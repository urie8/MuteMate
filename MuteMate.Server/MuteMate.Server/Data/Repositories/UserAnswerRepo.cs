using Microsoft.EntityFrameworkCore;
using MuteMate.Server.Models;

namespace MuteMate.Server.Data.Repositories
{
    public class UserAnswerRepo : MuteMateGenericRepository<UserAnswerModel>
    {

        private readonly MuteMateDbContext _dbContext;

        public UserAnswerRepo(MuteMateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<AnswerModel?>> GetCorrectAnswersForUserAsync(string userId) //total banana points
        {
            var correctAnswers = await _dbContext.UserAnswers
                .Where(ua => ua.UserId == userId && ua.Answer.IsCorrect)
                .Select(ua => ua.Answer)
                .ToListAsync();

            return correctAnswers;
        }


        //Hämta userns correct answers för category Colors

        public async Task<List<AnswerModel?>> GetCorrectAnswersForCategoryColorsAsync(string userId)
        {
            return await _dbContext.UserAnswers
            .Where(ua => ua.UserId == userId && ua.Answer.IsCorrect && ua.Answer.Question.Category == "Colors")
            .Include(ua => ua.Answer)
            .ThenInclude(a => a.Question)
            .Select(ua => ua.Answer)
            .ToListAsync();
        }

        //Hämta userns correct answers för category Letters

        public async Task<List<AnswerModel?>> GetCorrectAnswersForCategoryLettersAsync(string userId)
        {
            return await _dbContext.UserAnswers
            .Where(ua => ua.UserId == userId && ua.Answer.IsCorrect && ua.Answer.Question.Category == "Letters")
            .Include(ua => ua.Answer)
            .ThenInclude(a => a.Question)
            .Select(ua => ua.Answer)
            .ToListAsync();
        }

        //Hämta userns correct answers för category Animals

        public async Task<List<AnswerModel?>> GetCorrectAnswersForCategoryAnimalsAsync(string userId)
        {
            return await _dbContext.UserAnswers
            .Where(ua => ua.UserId == userId && ua.Answer.IsCorrect && ua.Answer.Question.Category == "Animals")
            .Include(ua => ua.Answer)
            .ThenInclude(a => a.Question)
            .Select(ua => ua.Answer)
            .ToListAsync();
        }

        public async Task<List<UserAnswerModel>> PostCorrectAnswersAsync(List<UserAnswerModel> userAnswers)
        {
            foreach (var userAnswer in userAnswers)
            {
                var existingUserAnswer = await _dbContext.UserAnswers
                    .FirstOrDefaultAsync(ua => ua.UserId == userAnswer.UserId && ua.QuestionId == userAnswer.QuestionId);

                if (existingUserAnswer != null)
                {
                    existingUserAnswer.AnswerId = userAnswer.AnswerId;
                    _dbContext.UserAnswers.Update(existingUserAnswer);
                }
                else
                {
                    await _dbContext.UserAnswers.AddAsync(userAnswer);
                }
            }

            await _dbContext.SaveChangesAsync();
            return userAnswers;
        }

    }
}
