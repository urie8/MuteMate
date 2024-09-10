using Microsoft.EntityFrameworkCore;
using MuteMate.Server.Migrations;
using MuteMate.Server.Models;

namespace MuteMate.Server.Data.Repositories
{
    public class UserAnswerRepo : MuteMateGenericRepository<QuestionModel>
    {

        private readonly MuteMateDbContext _dbContext;

        public UserAnswerRepo(MuteMateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<AnswerModel>> GetCorrectAnswersForUserAsync(string userId) //total bananas points
        {
            var correctAnswers = await _dbContext.UserAnswers
                .Where(ua => ua.UserId == userId && ua.isCorrect)
                .Select(ua => ua.Answer)
                .ToListAsync();

            return correctAnswers;
        }


        //Hämta userns correct answers för category Colors

        public async Task<List<AnswerModel>> GetCorrectAnswersForCategoryColorsAsync(string userId)
        {
            return await _dbContext.UserAnswers
            .Where(ua => ua.UserId == userId && ua.isCorrect && ua.Answer.Question.Category == "Colors")
            .Include(ua => ua.Answer)
            .ThenInclude(a => a.Question)
            .Select(ua => ua.Answer)
            .ToListAsync();
        }


        //Hämta userns correct answers för category Letters

        public async Task<List<AnswerModel>> GetCorrectAnswersForCategoryLettersAsync(string userId)
        {
            return await _dbContext.UserAnswers
            .Where(ua => ua.UserId == userId && ua.isCorrect && ua.Answer.Question.Category == "Letters")
            .Include(ua => ua.Answer)
            .ThenInclude(a => a.Question)
            .Select(ua => ua.Answer)
            .ToListAsync();
        }



        //Hämta userns correct answers för category Animals

        public async Task<List<AnswerModel>> GetCorrectAnswersForCategoryAnimalsAsync(string userId)
        {
            return await _dbContext.UserAnswers
            .Where(ua => ua.UserId == userId && ua.isCorrect && ua.Answer.Question.Category == "Animals")
            .Include(ua => ua.Answer)
            .ThenInclude(a => a.Question)
            .Select(ua => ua.Answer)
            .ToListAsync();
        }

        //public async Task<List<UserAnswerModel>> PostCorrectAnswersAsync(List<UserAnswerModel> userAnswers)
        //{
        //    await _dbContext.UserAnswers.AddRangeAsync(userAnswers);
        //    await _dbContext.SaveChangesAsync();
        //    return userAnswers;
        //}

        public async Task<List<UserAnswerModel>> PostCorrectAnswersAsync(List<UserAnswerModel> userAnswers)
        {
            foreach (var userAnswer in userAnswers)
            {
                var existingAnswer = await _dbContext.UserAnswers
                    .FirstOrDefaultAsync(ua => ua.UserId == userAnswer.UserId && ua.AnswerId == userAnswer.AnswerId);

                if (existingAnswer != null)
                {
                    existingAnswer.isCorrect = userAnswer.isCorrect;
                    _dbContext.UserAnswers.Update(existingAnswer);
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
