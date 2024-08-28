using Microsoft.AspNetCore.Mvc;
using MuteMate.Server.Data.Repositories;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MuteMate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAnswerController : ControllerBase
    {

        private readonly UserAnswerRepo _userAnswerRepo;

        private JsonSerializerOptions _jsonSerializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve // Konfigurering av JSON-serialisering
        };


        public UserAnswerController(UserAnswerRepo userAnswerRepo)
        {
            _userAnswerRepo = userAnswerRepo;
        }


        [HttpGet("/CorrectUserAnswers/{userId}")]
        public async Task<IActionResult> GetCorrectAnswers(string userId)
        {
            var correctAnswers = await _userAnswerRepo.GetCorrectAnswersForUserAsync(userId);
            return Ok(correctAnswers);
        }


        //[HttpGet("{userId}/correct-answers/colors")]
        [HttpGet("/CorrectUserAnswersForColors/{userId}")]

        public async Task<IActionResult> GetCorrectAnswersForColors(string userId)
        {


            var correctAnswersForColors = await _userAnswerRepo.GetCorrectAnswersForCategoryColorsAsync(userId);
            var json = JsonSerializer.Serialize(correctAnswersForColors, _jsonSerializerOptions);
            return Content(json, "application/json");

        }


        //[HttpGet("{userId}/correct-answers/colors")]
        [HttpGet("/CorrectUserAnswersForLetters/{userId}")]

        public async Task<IActionResult> GetCorrectAnswersForLetters(string userId)
        {


            var correctAnswersForLetters = await _userAnswerRepo.GetCorrectAnswersForCategoryLettersAsync(userId);
            var json = JsonSerializer.Serialize(correctAnswersForLetters, _jsonSerializerOptions);
            return Content(json, "application/json");

        }

        //[HttpGet("{userId}/correct-answers/colors")]
        [HttpGet("/CorrectUserAnswersForAnimals/{userId}")]

        public async Task<IActionResult> GetCorrectAnswersForAnimals(string userId)
        {


            var correctAnswersForAnimals = await _userAnswerRepo.GetCorrectAnswersForCategoryAnimalsAsync(userId);
            var json = JsonSerializer.Serialize(correctAnswersForAnimals, _jsonSerializerOptions);
            return Content(json, "application/json");

        }



    }
}

