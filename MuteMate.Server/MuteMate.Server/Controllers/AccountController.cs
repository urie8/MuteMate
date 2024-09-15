using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MuteMate.Server.Data.Repositories;
using MuteMate.Server.Models;

namespace MuteMate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserAnswerRepo _userAnswerRepo;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, UserAnswerRepo userAnswerRepo)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userAnswerRepo = userAnswerRepo;
        }


        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new ApplicationUser { UserName = model.Username, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return Ok(new { Success = true, Message = "User registered successfully." });
            }

            return BadRequest(result.Errors);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return Ok(new { Success = true, Message = "Login successful." });
            }
            return BadRequest(new { Success = false, Message = "Invalid login attempt." });
        }

        [HttpPost]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok(new { success = true, message = "Logout Successful" });
        }

        [HttpGet]
        [Route("isAuthenticated")]
        public IActionResult IsAuthenticated()
        {


            if (User.Identity.IsAuthenticated)
            {
                return Ok(new { isLoggedIn = true });
            }
            return Ok(new { isLoggedIn = false });
        }

        [HttpGet]
        [Route("getLoggedInUser")]
        public IActionResult GetLoggedInUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                return Ok(new { Success = true, Username = userName });
            }
            return Unauthorized(new { Success = false, Message = "User is not authenticated." });
        }

        [HttpGet]
        [Route("getLoggedInUserPoints")]
        public async Task<IActionResult> GetLoggedInUserPoints()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    // Fetch the user's total correct answers (points)
                    var correctAnswers = await _userAnswerRepo.GetCorrectAnswersForUserAsync(user.Id);
                    var totalPoints = correctAnswers.Count(); // Assuming each correct answer is worth 1 point

                    return Ok(new
                    {
                        Success = true,
                        Username = user.UserName,
                        Points = totalPoints // Include points in the response
                    });
                }
                return NotFound(new { Success = false, Message = "User not found." });
            }
            return Unauthorized(new { Success = false, Message = "User is not authenticated." });
        }
    }
}