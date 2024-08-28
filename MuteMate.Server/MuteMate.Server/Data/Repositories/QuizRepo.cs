using Microsoft.EntityFrameworkCore;
using MuteMate.Server.Models;

namespace MuteMate.Server.Data.Repositories
{
    public class QuizRepo
    {
        private readonly MuteMateDbContext context;

        public QuizRepo(MuteMateDbContext context)
        {
            this.context = context;
        }


        public async Task<List<QuestionModel>> GetCategoryColor()
        {
            return await context.Questions.Where(q => q.Category == "Colors").Include(q => q.Answers).ToListAsync();

        }

        public async Task<List<QuestionModel>> GetCategoryLetters()
        {
            return await context.Questions.Where(q => q.Category == "Letters").Include(q => q.Answers).ToListAsync();

        }

        public async Task<List<QuestionModel>> GetCategoryAnimals()
        {
            return await context.Questions.Where(q => q.Category == "Animals").Include(q => q.Answers).ToListAsync();

        }

        public async Task<List<QuestionModel>> Get5RandomCategoryColor()
        {
            return await context.Questions
                                .Where(q => q.Category == "Colors")
                                .Include(q => q.Answers)
                                .OrderBy(q => Guid.NewGuid())  // Randomize
                                .Take(5)                      // Ta de 5 första frågorna
                                .ToListAsync();
        }


        public async Task<List<QuestionModel>> Get5RandomCategoryAnimals()
        {
            return await context.Questions
                                .Where(q => q.Category == "Animals")
                                .Include(q => q.Answers)
                                .OrderBy(q => Guid.NewGuid())
                                .ToListAsync();
        }


        public async Task<List<QuestionModel>> Get5RandomCategoryLetters()
        {
            return await context.Questions
                                .Where(q => q.Category == "Letters")
                                .Include(q => q.Answers)
                                .OrderBy(q => Guid.NewGuid())
                                .Take(5)
                                .ToListAsync();
        }

    }
}
