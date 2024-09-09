using Microsoft.AspNetCore.Mvc;
using MuteMate.Server.Data.Repositories;
using MuteMate.Server.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MuteMate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {

        private readonly QuizRepo _quizRepo;

        private JsonSerializerOptions _jsonSerializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve // Konfigurering av JSON-serialisering
        };


        public QuizController(QuizRepo quizRepo)
        {
            _quizRepo = quizRepo;
        }

        [HttpGet("GetQuestionsAnsweredWrong")]
        public async Task<IActionResult> GetQuestionsAnsweredWrongAsync([FromQuery] string? id = null)
        {
            List<QuestionModel> questions = new();

            if (!string.IsNullOrEmpty(id))
            {
                // Om id skickas, dela upp det till en lista av int och hämta frågorna baserat på dessa id.
                var idList = id.Split(',').Select(int.Parse).ToList();
                questions = await _quizRepo.GetQuestionsById(idList);
            }

            // Om inget id skickas, returnera en tom lista
            if (questions == null || questions.Count == 0)
            {
                return Ok(new List<QuestionModel>());  // Returnera en tom lista om inga frågor hittas eller om inga id skickas
            }

            var responsesJson = JsonSerializer.Serialize(questions, _jsonSerializerOptions);
            return Content(responsesJson, "application/json");
        }


        [HttpGet("GetCategoryColors")]
        public async Task<IActionResult> GetCategoryColorsAsync()
        {
            List<QuestionModel> categoryColors = await _quizRepo.GetCategoryColor();
            if (categoryColors == null)
            {
                return NotFound();
            }
            else
            {
                var responsesJson = JsonSerializer.Serialize(categoryColors, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
            }
        }




        [HttpGet("GetCategoryLetters")]

        public async Task<IActionResult> GetCategoryLettersAsync()
        {

            List<QuestionModel> categoryLetters = await _quizRepo.GetCategoryLetters();
            if (categoryLetters == null)
            {
                return NotFound();

            }
            else

            {

                var responsesJson = JsonSerializer.Serialize(categoryLetters, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
                //return Ok(categoryLetters);
            }

        }
        [HttpGet("GetCategoryAnimals")]

        public async Task<IActionResult> GetCategoryAnimalsAsync()
        {

            List<QuestionModel> categoryAnimals = await _quizRepo.GetCategoryAnimals();
            if (categoryAnimals == null)
            {
                return NotFound();

            }
            else
            {

                var responsesJson = JsonSerializer.Serialize(categoryAnimals, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
                //return Ok(categoryAnimals);
            }

        }



        [HttpGet("Get5RandomCategoryColor")]
        public async Task<IActionResult> Get5RandomCategoryColorAsync()
        {
            List<QuestionModel> randomCategoryColors = await _quizRepo.Get5RandomCategoryColor();
            if (randomCategoryColors == null)
            {
                return NotFound();
            }
            else
            {
                var responsesJson = JsonSerializer.Serialize(randomCategoryColors, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
            }
        }

        [HttpGet("Get5RandomCategoryAnimals")]
        public async Task<IActionResult> Get5RandomCategoryAnimalsAsync()
        {
            List<QuestionModel> randomCategoryAnimals = await _quizRepo.Get5RandomCategoryAnimals();
            if (randomCategoryAnimals == null)
            {
                return NotFound();
            }
            else
            {
                var responsesJson = JsonSerializer.Serialize(randomCategoryAnimals, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
            }
        }


        [HttpGet("Get5RandomCategoryLetters")]
        public async Task<IActionResult> Get5RandomCategoryLettersAsync()
        {
            List<QuestionModel> randomCategoryLetters = await _quizRepo.Get5RandomCategoryLetters();
            if (randomCategoryLetters == null)
            {
                return NotFound();
            }
            else
            {
                var responsesJson = JsonSerializer.Serialize(randomCategoryLetters, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
            }
        }

    }
}
