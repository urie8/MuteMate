using Microsoft.AspNetCore.Mvc;
using MuteMate.Server.Data.Repositories;
using MuteMate.Server.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MuteMate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {

        private readonly QuoteRepo _quoteRepo;

        private JsonSerializerOptions _jsonSerializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve // Konfigurering av JSON-serialisering
        };

        public QuoteController(QuoteRepo quoteRepo)
        {
            _quoteRepo = quoteRepo;
        }

        [HttpGet("GetPraiseCategory")]
        public async Task<IActionResult> GetCategoryPraise()
        {
            List<QuoteModel> praiseCategory = await _quoteRepo.GetCategoryPraise();

            if (praiseCategory == null)
            {
                return NotFound();
            }
            else
            {
                var responsesJson = JsonSerializer.Serialize(praiseCategory, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
            }
        }

        [HttpGet("GetEncouragementCategory")]
        public async Task<IActionResult> GetCategoryEncouragement()
        {
            List<QuoteModel> encouragementCategory = await _quoteRepo.GetCategoryEncouragement();

            if (encouragementCategory == null)
            {
                return NotFound();
            }
            else
            {
                var responsesJson = JsonSerializer.Serialize(encouragementCategory, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
            }
        }

        [HttpGet("GetRandomPraiseQuote")]
        public async Task<IActionResult> GetRandomPraiseQuote()
        {
            var randomPraiseQuote = await _quoteRepo.GetRandomPraiseQuote();
            if (randomPraiseQuote == null)
            {
                return NotFound();
            }
            else
            {
                var responsesJson = JsonSerializer.Serialize(randomPraiseQuote, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
            }
        }

        [HttpGet("GetRandomEncouragementQuote")]
        public async Task<IActionResult> GetRandomEncouragementQuote()
        {
            var randomEncouragementQuote = await _quoteRepo.GetRandomEncouragementQuote();

            if (randomEncouragementQuote == null)
            {
                return NotFound();
            }
            else
            {
                var responsesJson = JsonSerializer.Serialize(randomEncouragementQuote, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
            }
        }
    }
}
