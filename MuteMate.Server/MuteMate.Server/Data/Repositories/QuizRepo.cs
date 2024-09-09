using Microsoft.EntityFrameworkCore;
using MuteMate.Server.Models;

namespace MuteMate.Server.Data.Repositories
{
    public class QuizRepo : MuteMateGenericRepository<QuestionModel>
    {

        private readonly MuteMateDbContext _dbContext;

        public QuizRepo(MuteMateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<QuestionModel>> GetQuestionsById(List<int> id)
        {

            return await _dbContext.Questions
                .Where(q => id.Contains(q.Id))
                .Include(q => q.Answers.Where(a => a.IsCorrect))
                .ToListAsync();
        }


        public async Task<List<QuestionModel>> GetCategoryColor()
        {
            return await _dbContext.Questions
                .Where(q => q.Category == "Colors")
                .Include(q => q.Answers)
                .ToListAsync();

        }

        public async Task<List<QuestionModel>> GetCategoryLetters()
        {
            return await _dbContext.Questions
                .Where(q => q.Category == "Letters")
                .Include(q => q.Answers)
                .ToListAsync();

        }

        public async Task<List<QuestionModel>> GetCategoryAnimals()
        {
            return await _dbContext.Questions
                .Where(q => q.Category == "Animals")
                .Include(q => q.Answers)
                .ToListAsync();

        }

        public async Task<List<QuestionModel>> Get5RandomCategoryColor()
        {
            return await _dbContext.Questions
                                .Where(q => q.Category == "Colors")
                                .Include(q => q.Answers)
                                .OrderBy(q => Guid.NewGuid())  // Randomize
                                .Take(5)                      // Ta de 5 första frågorna
                                .ToListAsync();
        }


        public async Task<List<QuestionModel>> Get5RandomCategoryAnimals()
        {
            return await _dbContext.Questions
                                .Where(q => q.Category == "Animals")
                                .Include(q => q.Answers)
                                .OrderBy(q => Guid.NewGuid())
                                .ToListAsync();
        }


        public async Task<List<QuestionModel>> Get5RandomCategoryLetters()
        {
            return await _dbContext.Questions
                                .Where(q => q.Category == "Letters")
                                .Include(q => q.Answers)
                                .OrderBy(q => Guid.NewGuid())
                                .Take(5)
                                .ToListAsync();
        }

    }
}
