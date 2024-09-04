using Microsoft.EntityFrameworkCore;
using MuteMate.Server.Models;

namespace MuteMate.Server.Data.Repositories
{
    public class QuoteRepo
    {

        private readonly MuteMateGenericRepository<QuoteModel> _repository;

        public QuoteRepo(MuteMateGenericRepository<QuoteModel> repository)
        {
            _repository = repository;
        }

        public async Task<List<QuoteModel>> GetCategoryPraise()
        {
            return await _repository.Context.Quotes
                .Where(q => q.Category == "Praise")
                .ToListAsync();
        }

        public async Task<List<QuoteModel>> GetCategoryEncouragement()
        {
            return await _repository.Context.Quotes
                .Where(q => q.Category == "Encouragement")
                .ToListAsync();

        }

        public async Task<QuoteModel> GetRandomPraiseQuote()
        {
            var praiseQuote = await _repository.Context.Quotes
                .Where(q => q.Category == "Praise")
                .ToListAsync();

            if (praiseQuote.Count == 0)
            {
                return null;
            }
            else
            {
                var randomQuoteIndex = new Random().Next(praiseQuote.Count);

                return praiseQuote[randomQuoteIndex];
            }

        }
        public async Task<QuoteModel> GetRandomEncouragementQuote()
        {
            var encouragementQuote = await _repository.Context.Quotes
                .Where(q => q.Category == "Encouragement")
                .ToListAsync();

            if (encouragementQuote.Count == 0)
            {
                return null;
            }
            else
            {
                var randomQuote = new Random().Next(encouragementQuote.Count);

                return encouragementQuote[randomQuote];
            }
        }

    }
}
