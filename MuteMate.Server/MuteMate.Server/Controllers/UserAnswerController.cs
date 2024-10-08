﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MuteMate.Server.Data.Repositories;
using MuteMate.Server.Models;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MuteMate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]


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

        private string GetCurrentUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the current user's ID from claims
        }

        [HttpGet("/CorrectUserAnswers")]
        public async Task<IActionResult> GetCorrectAnswers()
        {
            var userId = GetCurrentUserId();
            var correctAnswers = await _userAnswerRepo.GetCorrectAnswersForUserAsync(userId);
            return Ok(correctAnswers);
        }


        [HttpGet("/CorrectUserAnswersForColors")]

        public async Task<IActionResult> GetCorrectAnswersForColors()
        {
            var userId = GetCurrentUserId();
            var correctAnswersForColors = await _userAnswerRepo.GetCorrectAnswersForCategoryColorsAsync(userId);
            var json = JsonSerializer.Serialize(correctAnswersForColors, _jsonSerializerOptions);
            return Content(json, "application/json");
        }

        [HttpGet("/CorrectUserAnswersForLetters")]
        public async Task<IActionResult> GetCorrectAnswersForLetters()
        {
            var userId = GetCurrentUserId();
            var correctAnswersForLetters = await _userAnswerRepo.GetCorrectAnswersForCategoryLettersAsync(userId);
            var json = JsonSerializer.Serialize(correctAnswersForLetters, _jsonSerializerOptions);
            return Content(json, "application/json");
        }

        [HttpGet("/CorrectUserAnswersForAnimals")]

        public async Task<IActionResult> GetCorrectAnswersForAnimals()
        {
            var userId = GetCurrentUserId();
            var correctAnswersForAnimals = await _userAnswerRepo.GetCorrectAnswersForCategoryAnimalsAsync(userId);
            var json = JsonSerializer.Serialize(correctAnswersForAnimals, _jsonSerializerOptions);
            return Content(json, "application/json");

        }

        [HttpPost("AddCorrectUserAnswers")]
        public async Task<IActionResult> PostCorrectUserAnswers([FromBody] List<UserAnswerModel> userAnswers)
        {
            var userId = GetCurrentUserId();

            if (userAnswers == null || !userAnswers.Any())
            {
                return BadRequest("No answers provided.");
            }

            foreach (var answer in userAnswers)
            {
                answer.UserId = userId;
            }

            try
            {
                var result = await _userAnswerRepo.PostCorrectAnswersAsync(userAnswers);
                return Ok(result);
            }

            catch (Exception ex)
            {
                // Log the exception and return a server error status code
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

    }
}